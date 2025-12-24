using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public partial class MainForm : Form
	{
		ColorDialog backgroundColorDialog;
		ColorDialog foregroundColorDialog;
		private PrivateFontCollection fontFamilyCollection = new PrivateFontCollection();
		public MainForm()
		{
			
			InitializeComponent();
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			SetVisibility(false);
			backgroundColorDialog = new ColorDialog();
			foregroundColorDialog = new ColorDialog();
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
			if(foregroundColorDialog.ShowDialog(this) == DialogResult.OK)
			{
				labelTime.ForeColor = foregroundColorDialog.Color;
			}

		}

		private void tsmiBackgroundColor_Click(object sender, EventArgs e)
		{
			if(backgroundColorDialog.ShowDialog() == DialogResult.OK)
			{
				BackColor = backgroundColorDialog.Color;
			}
		}

		private void tsmiFont_Click(object sender, EventArgs e)
		{
			string fontFilePath = Path.Combine(Application.StartupPath, "SlackOnChristmasDemoRegular-e95jx.ttf");
			fontFamilyCollection.AddFontFile(fontFilePath);
			labelTime.Font = new Font(fontFamilyCollection.Families[0], 35);
			contextMenuStrip.Font = new Font(fontFamilyCollection.Families[0], 35);
			btnHideControls.Font = new Font(fontFamilyCollection.Families[0], 35);
			cbShowDate.Font = new Font(fontFamilyCollection.Families[0], 22);
			cbShowWeekday.Font = new Font(fontFamilyCollection.Families[0], 22);
		}
	}
}
