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
	public partial class Alarm2 : Form
	{
		private readonly MainForm _mainForm; // Хранится ссылка на MainForm
		public Alarm2(MainForm mainForm)
		{
			InitializeComponent();
			_mainForm = mainForm;
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			Alarm alarm = new Clock.Alarm(_mainForm);
			this.Close();
			alarm.Show();
		}
	}
}
