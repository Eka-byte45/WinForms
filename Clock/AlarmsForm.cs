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
using System.Diagnostics;
using System.Globalization;

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
			if (alarm.ShowDialog() == DialogResult.OK)
			{
				listBoxAlarms.Items.Add(new Alarm(alarm.Alarm));
			}
			//alarm.ShowDialog();
		}

		private void listBoxAlarms_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (listBoxAlarms.Items.Count > 0 && listBoxAlarms.SelectedItem != null)
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
		public void LoadAlarms()
		{
			string fileName = Path.Combine(Application.StartupPath, "Alarms.ini");
			if (!File.Exists(fileName))
				return; 
			StreamReader reader = new StreamReader(fileName);
			while (!reader.EndOfStream)
			{
				string line = reader.ReadLine().Trim(); 
				if (line.Length == 0 || String.IsNullOrWhiteSpace(line)) continue; 
				string[] parts = line.Split('\t');
				if (parts.Length >= 4)
				{
					Alarm alarm = new Alarm();
					if (parts[0].Equals("Каждый день"))
						alarm.Date = DateTime.MaxValue;
					else
						alarm.Date = DateTime.ParseExact(parts[0], "yyyy.MM.dd", CultureInfo.InvariantCulture);
					alarm.Time = TimeSpan.Parse(parts[1]);
					alarm.Days = ParseWeekdays(parts[2]);
					alarm.Filename = parts[3];
					listBoxAlarms.Items.Add(alarm);
				}
			}
			reader.Close(); 
		}

		private Week ParseWeekdays(string weekdaysStr)
		{
			byte daysMask = 0;

			foreach (string part in weekdaysStr.TrimEnd(',').Split(','))
			{
				switch (part)
				{
					case "Пн": daysMask |= 1 << 0; break;
					case "Вт": daysMask |= 1 << 1; break;
					case "Ср": daysMask |= 1 << 2; break;
					case "Чт": daysMask |= 1 << 3; break;
					case "Пт": daysMask |= 1 << 4; break;
					case "Сб": daysMask |= 1 << 5; break;
					case "Вс": daysMask |= 1 << 6; break;
				}
			}
			return new Week(daysMask);
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			int selectedIndex = listBoxAlarms.SelectedIndex;
			if (selectedIndex != -1)
			{
				listBoxAlarms.Items.RemoveAt(selectedIndex);
			}
			else
			{
				MessageBox.Show("Сначала выберите будильник.", "Удаление будильника", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
