using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
			this.MaximizeBox = false;
			this.MinimizeBox = false;
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
			SetVisibility(false);
		}

		private void labelTime_MouseHover(object sender, EventArgs e)
		{
			SetVisibility(true);
		}

		private void notifyIcon_DoubleClick(object sender, EventArgs e)
		{
			this.TopMost = true;
			this.TopMost = false;
		}
	}
}
