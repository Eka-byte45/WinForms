using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;


namespace Clock
{
	public partial class FontDialog : Form
	{
		public Font Font {  get; set; }//Свойство для хранения текущего шрифта
		public string Filename {  get; set; }//Свойство хранит имя файла шрифта
		int lastChosenIndex;//Индекс последнего выбранного шрифта в списке
		//Конструктор по умолчанию
		public FontDialog()
		{
			InitializeComponent();//Инициализация компонентов формы
			lastChosenIndex = 0;//Начинаем индекс с 0
			LoadFonts("*.ttf");//Загружаем ttf - шрифты
			LoadFonts("*.otf");//Загружаем otf - шрифты
			comboBoxFont.SelectedIndex = 1;//Изначально выбираем второй элемент списка
		}
		//Перегруженный конструктор для передачи существующего шрифта
		public FontDialog(string font_name,string font_size):this()
		{
			Filename = font_name;//Имя файла шрифта
			if(font_size!= null)//Если передан размер шрифта
				numericUpDownFontSize.Value = Convert.ToDecimal(font_size);
			lastChosenIndex = comboBoxFont.FindString(font_name);//Находим индекс по имени шрифта
			if (lastChosenIndex == -1) lastChosenIndex = 2;//Если не нашли, то ставим на третий элемент
			comboBoxFont.SelectedIndex = lastChosenIndex; //Выбираем найденный индекс
			SetFont();//Устанавливаем шрифт
			Font = labelExample.Font;//Присваиваем текущий шрифт полю Font
		}
		//Обработчик события загрузки формы
		private void FontDialog_Load(object sender, EventArgs e)
		{
			numericUpDownFontSize.Value = (decimal)Font.Size;//Устанавливаем числовое поле размером текущего шрифта
		}
		//Метод зарузки шрифтов из файлов
		void LoadFonts(string extension)
		{
			string currentDir = Application.ExecutablePath;//Берем путь к исполняемому файлу
			Directory.SetCurrentDirectory($"{currentDir}\\..\\..\\..\\Fonts");//переходим в папку Fonts
			//MessageBox.Show
			//	(
			//	this,
			//	Directory.GetCurrentDirectory(),
			//	//currentDir,
			//	"CurrentDyrectory",
			//	MessageBoxButtons.OK,
			//	MessageBoxIcon.Information
			//	);
			string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(),extension);//Получаем файл нужного расширения
			//comboBoxFont.Items.AddRange(files);//добавляем все содержимое массива files в выпадающий список(комбо бокс)
			for (int i = 0; i < files.Length; i++)//Проходим по каждому файлу
			{
				comboBoxFont.Items.Add( files[i].Split('\\').Last());//Добавляем имя файла шрифта в комбобокс
			}
		}
		//Обработчик смены выбора шрифта в комбобоксе
		private void comboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
		{
			string info =$"Selected:\nIndex:\t{comboBoxFont.SelectedIndex.ToString()}";
			info += $"\nItem:\t{comboBoxFont.SelectedItem}";
			info += $"\nText:\t{comboBoxFont.SelectedText}";
			info += $"\nValue:\t{comboBoxFont.SelectedValue}";
			//MessageBox.Show(this, info,"SelectedIndexChanged", MessageBoxButtons.OK,MessageBoxIcon.Information);
			SetFont();//Установка шрифта
		}
		//Метод установки шрифта
		void SetFont()
		{
			Directory.SetCurrentDirectory($"{Application.ExecutablePath}\\..\\..\\..\\Fonts");//Переходим в папку Fonts
			PrivateFontCollection pfc = new PrivateFontCollection();//Создаем коллекцию приватных шрифтов
			//pfc.AddFontFile(filename);
			pfc.AddFontFile(comboBoxFont.SelectedItem.ToString());//Добавляем выбранный шрифт в коллекцию
			labelExample.Font = new Font(pfc.Families[0], (float)numericUpDownFontSize.Value);//Применяем шрифт к примеру

		}
		//Обработчик кнопки окей
		private void buttonOK_Click(object sender, EventArgs e)
		{
			this.Font = labelExample.Font;//Запоминаем выбранный шрифт
			this.Filename = comboBoxFont.SelectedItem.ToString();//Запоминаем имя файла шрифта
			this.lastChosenIndex = comboBoxFont.SelectedIndex;//Запоминаем последний выбранный
		}
		//Обработчик кнопки Cancel
		private void buttonCancel_Click(object sender, EventArgs e)
		{
			labelExample.Font = this.Font;//Восстанавливаем предыдущий шрифт
			comboBoxFont.SelectedIndex = lastChosenIndex;//Восстанавливаем предыдущий индекс
		}
		//Обработчик изменения размера шрифта
		private void numericUpDownFontSize_ValueChanged(object sender, EventArgs e)
		{
			SetFont();//Пересчитываем шрифт при изменении размера
		}
	}
}
