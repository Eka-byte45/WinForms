using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Globalization;
using System.Diagnostics;

namespace Clock
{
	public partial class MainForm : Form
	{
		FontDialog fontDialog;
		ColorDialog foregroundColorDialog;
		ColorDialog backgroundColorDialog;
		private Alarm alarmForm;
		public MainForm()//Конструктор MainForm,вызывается автоматически при создании экземпляра объекта
		{
			InitializeComponent();//Метод, который генерируется автоматически, он создает и настраивает визуальные элементы формы
								  //Здесь устанавливаем положение окна в правом верхнем углу экрана

			alarmForm = new Alarm(this);
			
			timer.Interval = 200;
			timer.Tick += new EventHandler(timer_Tick); // Подписываемся на событие тикера
			timer.Start();

			this.StartPosition = FormStartPosition.Manual;//Здесь мы говорим программе, что мы сами устанавливаем начальное положение окна
			this.Location = new Point
				(
				Screen.PrimaryScreen.Bounds.Width-this.Width-25,
				50
				);//Здесь устанавливаем точное расположение окна на экране, здесь две координаты:
				  //первая координата вычисляется ширина основного монитора минус ширина окна минус отступ справа 25 пикселей
				  //вторая координата: равна 50 пикселей сверху

				  //Screen — это статический класс из пространства имен System.Windows.Forms, предназначенный для работы с информацией о мониторах и экранах компьютера.
				  //PrimaryScreen — это статическое свойство класса Screen, возвращающее объект типа Screen, соответствующий основному монитору компьютера.
				  //Основной монитор — это монитор, на котором расположена панель задач.

				  //Bounds — это свойство объекта Screen, которое возвращает прямоугольник(Rectangle), ограничивающий область экрана(рабочего стола).
				  //Этот прямоугольник представлен четырьмя свойствами: Left, Top, Width и Height.
				  //Width — это одно из свойств прямоугольника, возвращаемое методом Bounds.Оно возвращает ширину указанного прямоугольника(экранного рабочего пространства),
				  //измеренную в пикселах.

			//Отключение максимизации и минимизации окна
			this.MaximizeBox = false;//нельзя развернуть
			this.MinimizeBox = false;//нельзя свернуть

			SetVisibility(false);// Здесь мы используем метод, который скрывает элементы интерфейса и делает форму прозрачной


			fontDialog = new FontDialog();//FontDialog - диалог выбора шрифта
			foregroundColorDialog = new ColorDialog();//цвет текста
			backgroundColorDialog = new ColorDialog();//цвет фона

			LoadSettings();	//Метод, который загружает предыдущие настройки из реестра Windows
			//Реестр - это хранилище конфигурационных данных, доступное приложениям для сохранения 
			//собственных натсроек между запусками
		}
		void SetVisibility(bool visible)//метод принимает один аргумент, true - содержимое формы видимое, false - скрыто
		{
			//Visibile - свойство
			cbShowDate.Visible = visible;//дата
			cbShowWeekday.Visible = visible;//день недели
			btnHideControls.Visible = visible;//кнопка, которая скрывает элементы управления
			this.ShowInTaskbar = visible;//ShowInTaskbar - свойство,которое контролирует  иконки формы в панели задач Windows
			this.FormBorderStyle = visible ? FormBorderStyle.FixedSingle : FormBorderStyle.None;//FormBorderStyle -  свойство регулирует тип рамки вокруг формы
			//Если visible == true, граница формы становится фиксированной одинарной (FixedSingle).
			//Если visible == false, граница исчезает (None).
			this.TransparencyKey = visible ? Color.Empty : this.BackColor;//TransparencyKey - свойство отвечает за создание эффекта прозрачности формы
			//путем установки определенного цвета в качестве ключа прозрачности
			//Если visible == true, ключ прозрачности сбрасывается на пустое значение (Color.Empty), что делает всю форму непрозрачной.
			//Если visible == false, цветом прозрачности назначается текущий фон формы (BackColor), благодаря чему форма становится прозрачной.
		}

		void SaveSettings()//Метод для сохранения текущих настроек приложения
		{
			Directory.SetCurrentDirectory($"{Application.ExecutablePath}\\..\\..\\..");//Установка рабочего каталога
			//MessageBox.Show
			//	(
			//	this, 
			//	Directory.GetCurrentDirectory(),
			//	"Settings path",
			//	MessageBoxButtons.OK,
			//	MessageBoxIcon.Information
			//	);
			StreamWriter writer = new StreamWriter("Settings.ini");//Создается поток для записи в файл "Settings.ini"
			writer.WriteLine(this.Location.X);//Запись координат окна X и Y
			writer.WriteLine(this.Location.Y);

			//Сохранение пунктов меню(включено/выключено)
			writer.WriteLine(tsmiTopmost.Checked);
			writer.WriteLine(tsmiShowControls.Checked);
			writer.WriteLine(tsmiShowConsole.Checked);

			writer.WriteLine(tsmiShowDate.Checked);//дата
			writer.WriteLine(tsmiShowWeekday.Checked);//день нееди
			writer.WriteLine(tsmiAutoStart.Checked);//автостарт
		
			writer.WriteLine(labelTime.BackColor.ToArgb());	//цвет фона
			writer.WriteLine(labelTime.ForeColor.ToArgb());//цвет текста
			
			writer.WriteLine(fontDialog.Filename);//имя файла шрифта
			writer.WriteLine(labelTime.Font.Size);//размер шрифта

			writer.Close();//поток записи закрываем
			System.Diagnostics.Process.Start("notepad", "Settings.ini");//файл автоматически открывается в программе Notepad для просмотра
		}
		void LoadSettings()//Метод для загрузки настроек из файла
		{
			Directory.SetCurrentDirectory($"{Application.ExecutablePath}\\..\\..\\..");
			try
			{
				StreamReader reader = new StreamReader("Settings.ini");//Создается объект чтения потока для файла "Settings.ini"

				this.Location = new Point//Загрузка координат окна
					(
					Convert.ToInt32(reader.ReadLine()),//Конвертация в целые числа
					Convert.ToInt32(reader.ReadLine())
					);

				this.TopMost = tsmiTopmost.Checked = bool.Parse(reader.ReadLine());
				tsmiShowControls.Checked = bool.Parse(reader.ReadLine());
				tsmiShowConsole.Checked = bool.Parse(reader.ReadLine());
				tsmiShowDate.Checked = bool.Parse(reader.ReadLine());
				tsmiShowWeekday.Checked = bool.Parse(reader.ReadLine());
				tsmiAutoStart.Checked = bool.Parse(reader.ReadLine());

				labelTime.BackColor = backgroundColorDialog.Color = Color.FromArgb(Convert.ToInt32(reader.ReadLine()));//FromArgb - преобразование целого числа в цвет фона и текста
				labelTime.ForeColor = foregroundColorDialog.Color = Color.FromArgb(Convert.ToInt32(reader.ReadLine()));

				fontDialog = new FontDialog(reader.ReadLine(),reader.ReadLine());//из файла настроек считывается имя шрифта и размер шрифта, эти параметры передаются в коструктор FontDialog и создается новый объект шрифта с укащанными характеристиками
				labelTime.Font = fontDialog.Font;//полученный шрифт и размер применяется к labelTime

				reader.Close();//Закрытие файла(поток чтения закрывается и происходит освобождение ресурсов)
			}
			catch(Exception ex)
			{
				MessageBox.Show(this, ex.Message, "Settings issue", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		void CheckAlarm()
		{
			
			if (alarmForm.alarmTime != DateTime.MinValue && DateTime.Now >= alarmForm.alarmTime)
			{
				MessageBox.Show("Будильник сработал!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
				alarmForm.ResetAlarm(); // сбросим установку будильника
			}
		}
		private void timer_Tick(object sender, EventArgs e)//при каждом тике таймера
		{
			labelTime.Text = DateTime.Now.ToString//DateTime.Now возвращает текущий момент времени, ToString используем чтобы преобразовать время в строку
				//часы:минуты:секунды, tt это AM/PM
				(
				"hh:mm:ss tt",
				System.Globalization.CultureInfo.InvariantCulture//CultureInfo.InvariantCulture - задает универсальный формат времени
																 //независимо от текущих региональных настроек
				);
			
			//if(cbShowDate.Checked )
			//{
			//	labelTime.Text += "\n";
			//	labelTime.Text += DateTime.Now.ToString("yyyy.MM.dd");
			//}
			if (cbShowDate.Checked)//Если включен чекбокс для отображения даты
				labelTime.Text += $"\n{DateTime.Now.ToString("yyyy.MM.dd")}";
			if (cbShowWeekday.Checked)//Если включен чекбокс для отображения дня недели
				labelTime.Text += $"\n{DateTime.Now.DayOfWeek}";
			notifyIcon.Text = labelTime.Text;//notifyIcon.Text - устанавливает текст уведомления в трее такой же как в labelTime.Text
											 //Трей - это область панели задач в нижней части экрана,правый нижний угол(область уведомлений)
			CheckAlarm();

		}
		
		private void btnHideControls_Click(object sender, EventArgs e)//Задача метода скрыть элементы управления на форме
		{
			//SetVisibility(false);
			SetVisibility(tsmiShowControls.Checked = false);
		}

		//private void labelTime_MouseHover(object sender, EventArgs e)
		//{
		//	SetVisibility(true);
		//}

		private void notifyIcon_DoubleClick(object sender, EventArgs e)//Обработчик события двойного щелчка по иконке уведомления NotifyIcon
		{
			if(!TopMost)//Если форма не установлена поверх всех окон
			{
				this.TopMost = true;//временно помещает поверх всех окно
				this.TopMost = false;//восстанавливает прежнее поведение
			}
		}

		private void tsmiTopmost_Click(object sender, EventArgs e)//Обработчик события клика по пункту меню "Всегда сверху"
		{
			this.TopMost = tsmiTopmost.Checked;//tsmiTopmost - tsmi ToolStripMenuItem(пункт меню)
			//TopMost - свойство формы 
		}

		private void tsmiShowControls_CheckedChanged(object sender, EventArgs e)//Обработчик события изменеия состояния пункта меню "Показывать элементы управления"
		{
			SetVisibility((sender as ToolStripMenuItem).Checked);
			//Sender -это ссылка на компонент, вызывающий событие.Событием управляют пункты меню.
			//sender as ToolStripMenuItem - преобразует объект в тип ToolStripMenuItem,после преобразования получаем доступ к свойству Checked
			//Если флаг поставлен, то Checked == true,если снят, то Checked == false
			//Метод SetVisibility принимает булевый параметр true/false
			//Sender - отправитель события(Control,который присылал событие).
			//Если на элемент окна (Control) воздействует пользователь при помощи клавиатуры или мыши,
			//этот Control отправляет событие своему родителю, а родитель может обрабатывать или не обрабатывать это событие.
		}
		private void tsmiShowDate_CheckedChanged(object sender, EventArgs e)
			=> cbShowDate.Checked = tsmiShowDate.Checked;//Обработчик события изменения состояния пункта меню "Показывать дату"
											            //Синхронизирует состояние чекбокса cbShowDate с состоянием пункта меню

		private void cbShowDate_CheckedChanged(object sender, EventArgs e) //Обработчик события изменения состояния чекбокса "Показывать дату"
																		   //Синхронизирует состояние пункта меню с состоянием чекбокса
			=> tsmiShowDate.Checked = cbShowDate.Checked;

		private void tsmiShowWeekday_CheckedChanged(object sender, EventArgs e) //Обработчик события изменения состояния пункта меню "Показывать день недели"
																		        //Синхронизирует состояние чекбокса cbShowWeekday с пунктом меню.
			=> cbShowWeekday.Checked = tsmiShowWeekday.Checked;

		private void cbShowWeekday_CheckedChanged(object sender, EventArgs e)//Обработчик события изменения состояния чекбокса "Показывать день недели"
			=> tsmiShowWeekday.Checked = cbShowWeekday.Checked;             //Синхронизирует состояние пункта меню с состоянием чекбокса

		private void tsmiQuit_Click(object sender, EventArgs e) => this.Close();//Обработчик события клика по пункту меню "Выход",Закрывает основное окно приложения

		private void tsmiForegroundColor_Click(object sender, EventArgs e)//Обработчик события клика по пункту меню "Цвет текста"
		{

			DialogResult result = foregroundColorDialog.ShowDialog();//Сначала открывается диалог выбора цвета (foregroundColorDialog.ShowDialog()).
																	 //Результат сохраняется в переменную result
			if (result == DialogResult.OK)//Если пользователь подтвердил выбор цвета (результат равен OK), выбранный цвет назначается цвету текста метки (labelTime.ForeColor).
			{
				labelTime.ForeColor = foregroundColorDialog.Color;
			}
		}

		private void tsmiBackgroundColor_Click(object sender, EventArgs e)//Обработчик события клика по пункту меню "Цвет фона"
		{
			DialogResult result = backgroundColorDialog.ShowDialog();
			if( result == DialogResult.OK)
			{
				labelTime.BackColor = backgroundColorDialog.Color;
			}	
		}

		private void tsmiFont_Click(object sender, EventArgs e)//Метод обрабатывает событие клика по пункту меню «Шрифт».
															   //Его задача — вызвать диалог выбора шрифта, позволить пользователю
															   //выбрать новый шрифт и применить его к метке (labelTime)
		{
			
			fontDialog.Location = new Point//Установка положения диалогового окна
				(
				this.Location.X - fontDialog.Width - 10,//положение слева от главного окна(минус свой размер в ширине и 10 пикселей на отсуп между окнами)
				this.Location.Y
				);
			fontDialog.Font = labelTime.Font;//Устанавливается начальное значение шрифта в диалоге, которое соответствует текущему шрифту метки labelTime 
			DialogResult result = fontDialog.ShowDialog();//Показ диалогового окна, а результат выбора сохраняется в в пременную result
			if( result == DialogResult.OK)//Если пользователь сделал выбор и нажал кнопку подтверждения (результат равен OK)
			{
				labelTime.Font = fontDialog.Font;//новый шрифт из диалога (fontDialog.Font) применяется к метке (labelTime.Font).
			}
		}

		private void tsmiAutoStart_CheckedChanged(object sender, EventArgs e)
		{
			string key_name = "clockPV_521";//Создание имени ключа
			RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run",true);//true - открыть ветку на запись,получение раздела реестра
			if (tsmiAutoStart.Checked)rk.SetValue(key_name,Application.ExecutablePath);//false - не бросать исключение, если данная запись отсутствует в реестре
			else rk.DeleteValue(key_name,false);
			rk.Dispose();//Освобождение ресурсов
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)//для вызова процедуры сохранения настроек при завершении работы приложения
		{
			SaveSettings();
		}

		private void tsmiAlarms_Click(object sender, EventArgs e)
		{
			Alarm2 alarm2 = new Alarm2(this);
			alarm2.Show();
		}
		
	}
}
