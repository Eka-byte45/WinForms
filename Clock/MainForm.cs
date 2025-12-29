using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;
using System.Globalization;


namespace Clock
{
	public partial class MainForm : Form
	{
		FontDialog fontDialog;
		ColorDialog foregroundColorDialog;
		ColorDialog backgroundColorDialog;

		public MainForm()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point
				(
				Screen.PrimaryScreen.Bounds.Width-this.Width-25,
				50
				);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			SetVisibility(false);
			fontDialog = new FontDialog();
			foregroundColorDialog = new ColorDialog();
			backgroundColorDialog = new ColorDialog();
			this.TopMost = tsmiTopmost.Checked = true;
			LoadSettings();

		}
		void SetVisibility(bool visible)
		{
			cbShowDate.Visible = visible;
			cbShowWeekday.Visible = visible;
			btnHideControls.Visible = visible;
			this.ShowInTaskbar = visible;
			this.FormBorderStyle = visible ? FormBorderStyle.FixedSingle : FormBorderStyle.None;
			this.TransparencyKey = visible ? Color.Empty : this.BackColor;
		}
		void SaveSettings()
		{
			StreamWriter streamWrite = new StreamWriter("settings.txt");
			streamWrite.WriteLine(backgroundColorDialog.Color.ToArgb());
			streamWrite.WriteLine(foregroundColorDialog.Color.ToArgb());
			streamWrite.WriteLine(tsmiTopmost.Checked);
			streamWrite.WriteLine(tsmiShowDate.Checked);
			streamWrite.WriteLine(tsmiShowWeekday.Checked);
		
			streamWrite.Close();
			Process.Start("notepad", "settings.txt");
		}
		void LoadSettings()
		{
			StreamReader streamReader = new StreamReader("settings.txt");
			List<string> settings = new List<string>();
			while (!streamReader.EndOfStream)
			{
				settings.Add(streamReader.ReadLine());
			}
			streamReader.Close();
			string[]arr = settings.ToArray();
			if (arr.Length >= 5)
			{
				backgroundColorDialog.Color = Color.FromArgb(int.Parse(arr[0]));
				foregroundColorDialog.Color = Color.FromArgb(int.Parse(arr[1]));

				labelTime.BackColor = backgroundColorDialog.Color;
				labelTime.ForeColor = foregroundColorDialog.Color;

				tsmiTopmost.Checked = bool.Parse(arr[2]);
				tsmiShowDate.Checked = bool.Parse(arr[3]);
				tsmiShowWeekday.Checked = bool.Parse(arr[4]);	
			}

		}
		private void timer_Tick(object sender, EventArgs e)
		{
			labelTime.Text = DateTime.Now.ToString
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
				labelTime.Text += $"\n{DateTime.Now.ToString("yyyy.MM.dd")}";
			if (cbShowWeekday.Checked)
				labelTime.Text += $"\n{DateTime.Now.DayOfWeek}";
			notifyIcon.Text = labelTime.Text ;
		}

		private void btnHideControls_Click(object sender, EventArgs e)
		{
			//SetVisibility(false);
			SetVisibility(tsmiShowControls.Checked = false);
		}

		//private void labelTime_MouseHover(object sender, EventArgs e)
		//{
		//	SetVisibility(true);
		//}

		private void notifyIcon_DoubleClick(object sender, EventArgs e)
		{
			if(!TopMost)
			{
				this.TopMost = true;
				this.TopMost = false;
			}
		}

		private void tsmiTopmost_Click(object sender, EventArgs e)
		{
			this.TopMost = tsmiTopmost.Checked;
		}

		private void tsmiShowControls_CheckedChanged(object sender, EventArgs e)
		{
			SetVisibility((sender as ToolStripMenuItem).Checked);
			//Sender - отправитель события(Control,который присылал событие).
			//Если на элемент окна (Control) воздействует пользователь при помощи клавиатуры или мыши,
			//этот Control отправляет событие своему родителю, а родитель может обрабатывать или не обрабатывать это событие.

		}

		private void tsmiShowDate_CheckedChanged(object sender, EventArgs e) => cbShowDate.Checked = tsmiShowDate.Checked;

		private void cbShowDate_CheckedChanged(object sender, EventArgs e) =>
			tsmiShowDate.Checked = cbShowDate.Checked;

		private void tsmiShowWeekday_CheckedChanged(object sender, EventArgs e) =>
			cbShowWeekday.Checked = tsmiShowWeekday.Checked;

		private void cbShowWeekday_CheckedChanged(object sender, EventArgs e) =>
			tsmiShowWeekday.Checked = cbShowWeekday.Checked;

		private void tsmiQuit_Click(object sender, EventArgs e) => this.Close();

		private void tsmiForegroundColor_Click(object sender, EventArgs e)
		{

			DialogResult result = foregroundColorDialog.ShowDialog();
			if(result == DialogResult.OK)
			{
				labelTime.ForeColor = foregroundColorDialog.Color;
			}
		}

		private void tsmiBackgroundColor_Click(object sender, EventArgs e)
		{
			DialogResult result = backgroundColorDialog.ShowDialog();
			if( result == DialogResult.OK)
			{
				labelTime.BackColor = backgroundColorDialog.Color;
			}	
		}

		private void tsmiFont_Click(object sender, EventArgs e)
		{
			
			fontDialog.Location = new Point
				(
				this.Location.X - fontDialog.Width - 10,
				this.Location.Y
				);
			fontDialog.Font = labelTime.Font;
			DialogResult result = fontDialog.ShowDialog();
			if( result == DialogResult.OK )
			{
				labelTime.Font = fontDialog.Font;
			}
		}

		private void tsmiAutoStart_CheckedChanged(object sender, EventArgs e)
		{
			string key_name = "clockPV_521";
			RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run",true);//true - открыть ветку на запись
			if(tsmiAutoStart.Checked)rk.SetValue(key_name,Application.ExecutablePath);//false - не бросать исключение, если данная запись отсутствует в реестре
			else rk.DeleteValue(key_name,false);
			rk.Dispose();//Освобождение ресурсов
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveSettings();
		}
	}
}
