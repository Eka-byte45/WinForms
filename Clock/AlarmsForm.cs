using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Clock
{
	public partial class AlarmsForm : Form
	{
		private MainForm _parentForm;
		AlarmDialog alarm;
		public AlarmsForm(MainForm parent)
		{
			InitializeComponent();
			_parentForm = parent;
			alarm = new AlarmDialog(this);
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			alarm.ShowDialog();
		}
		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);
			this.Location = new Point(_parentForm.Location.X - this.Width - 10, _parentForm.Location.Y);
		}

	}
}
