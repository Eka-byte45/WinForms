using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public partial class AlarmsForm : Form
	{
		public ListBox List { get => listBoxAlarms; }
		//AlarmDialog alarm;
		public AlarmsForm()
		{
			InitializeComponent();
			//alarm = new AlarmDialog();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			AlarmDialog alarm = new AlarmDialog();
			if(alarm.ShowDialog() == DialogResult.OK)
			{
				listBoxAlarms.Items.Add(new Alarm(alarm.Alarm));
			}
			//alarm.ShowDialog();
		}

		private void listBoxAlarms_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if(listBoxAlarms.Items.Count > 0 && listBoxAlarms.SelectedItem!=null)
			{
				AlarmDialog alarm = new AlarmDialog(listBoxAlarms.SelectedItem as Alarm);
				alarm.ShowDialog();
				listBoxAlarms.Items[listBoxAlarms.SelectedIndex] = new Alarm(alarm.Alarm);
			}
			else
			{
				buttonAdd_Click(sender, e);
			}
		}

		public void SaveAlarms(string filename)
		{
			StreamWriter writer = new StreamWriter(filename);
			foreach (Alarm alarm in listBoxAlarms.Items)
			{
				writer.WriteLine(alarm.ToString());

			}
			writer.Close();
			Process.Start("notepad", filename);

		}
	}
}
