using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			////I вариант
			//// Получаем размеры экрана
			//int screenWidth = Screen.PrimaryScreen.Bounds.Width;
			////this.StartPosition = FormStartPosition.Manual;//если не подключили в визуальном конструкторе среды
			//// Расчёт позиции окна
			//this.Left = screenWidth - this.Width; // Ставим окно в правый край экрана
			//this.Top = 0;                         // Оставляем окно в верхней части экрана

			//II вариант
			this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, 0); // Ставим окно в верхний правый угол экрана

			this.MaximizeBox = false;
		    this.MinimizeBox = false;

		}
		
		void SetVisibility(bool visible)//Метод управления видимостью элементов
		{
			cbShowDate.Visible = visible;//чекбокс дата
			cbShowWeekday.Visible = visible;//чекбокс день недели
			btnHideControls.Visible = visible;//кнопка
			this.ShowInTaskbar = visible;//присутствмие формы в панели задач
			this.FormBorderStyle = visible ? FormBorderStyle.FixedSingle : FormBorderStyle.None;//FormBorderStyle - стиль рамки окна(FixedSingle - фиксированная рамка вокруг окна
																								//None - удаляет границу окна и делает ее невидимой
			this.TransparencyKey = visible ? Color.Empty : this.BackColor;//TransparencyKey - прозрачность окна(Empty - отсутствие прозрачного цвета, то есть эффекта прозрачности не прмиеняется
																		  //BackColor - присваивает цвет фона самой формы, что делает именно этот цвет прозрачным
		}
		private void timer_Tick(object sender, EventArgs e)//Обработчик события таймера
		{
			labelTime.Text = DateTime.Now.ToString//Текущее время в форимате ч:м : с AM/PM
				(
				"hh:mm:ss tt",
				System.Globalization.CultureInfo.InvariantCulture
				);
			//if(cbShowDate.Checked )
			//{
			//	labelTime.Text += "\n";
			//	labelTime.Text += DateTime.Now.ToString("yyyy.MM.dd");
			//}
			if (cbShowDate.Checked)
				labelTime.Text += $"\n{DateTime.Now.ToString("yyyy.MM.dd")}";//Добавляем дату в формате ГГГГ : ММ : ДД
			if (cbShowWeekday.Checked)
				labelTime.Text += $"\n{DateTime.Now.DayOfWeek}";//Добавляем название текущего дня недели
			notifyIcon.Text = labelTime.Text ;//Устанавливаем текст уведомления в трей(увидим время на иконке с часами, находящейся на области уведомлений)

		}

		private void btnHideControls_Click(object sender, EventArgs e)//Нажатие кнопки btnHidwControls скрывает элементы управления
		{
			SetVisibility(false);
		}

		private void labelTime_MouseHover(object sender, EventArgs e)//Наведение мышью на метку времени labelTime_MouseHover снова показывает элементы управления
		{
			SetVisibility(true);
		}

		private void notifyIcon_DoubleClick(object sender, EventArgs e)//Отображение формы поверх остальных окон
		{
			this.TopMost = true;//Формируем сверху всех окон
			this.TopMost = false;//Возвращаемся к обычному поведению
		}

		private void labelTime_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				contextMenuStripMain.Show(Cursor.Position); // Показываем контекстное меню
			}
		}

		private void ToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			SetVisibility(!cbShowDate.Visible && !cbShowWeekday.Visible && !btnHideControls.Visible);
		}

		private void ToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			cbShowDate.Checked = !cbShowDate.Checked;
		}

		private void ToolStripMenuItem6_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ToolStripMenuItem5_Click(object sender, EventArgs e)
		{
			this.TopMost = !this.TopMost;	
		}

		private void ToolStripMenuItem7_Click(object sender, EventArgs e)
		{
			cbShowWeekday.Checked = !cbShowWeekday.Checked;
		}

		private void notifyIcon_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				contextMenuStripMain.Show(Cursor.Position); // Показываем контекстное меню
			}
		}
		
	}
}

