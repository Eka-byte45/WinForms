using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
	public class Alarm : IComparable<Alarm>
	{
		public DateTime Date {  get; set; }
		public TimeSpan Time { get; set; }
		public Week Days { get; set; }
		public string Filename {  get; set; }
		public Alarm() { }
		public Alarm(Alarm other)
		{
			this.Date = other.Date;
			this.Time = other.Time;
			this.Days = other.Days;
			this.Filename = other.Filename;
		}
		public int CompareTo(Alarm other)//Метод для сравнения двух экземпляров класса Alarm
		{
			if (other == null) return 1;
			int timeComparison = Time.CompareTo(other.Time);
			if (timeComparison != 0) return timeComparison;

			return Date.CompareTo(other.Date);
		}
		public override string ToString()
		{
			//return $"{Date},{Time},{Days.ToString()},{Filename}";
			string info = "";
			info += Date != DateTime.MaxValue ? Date.ToString("yyyy.MM.dd") : "Каждый день";
			info += $"\t{DateTime.Today.Add(Time).ToString("HH:mm:ss")}";
			info += $"\t{Days}";
			info += $"\t{Filename.Split('\\').Last()}";
			return info;
		}
	}
}
