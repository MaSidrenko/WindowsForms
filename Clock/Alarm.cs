using Microsoft.Win32;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
	public class Alarm : IComparable<Alarm>
	{
		public DateTime Date { get; set; }
		public TimeSpan Time { get; set; }
		public Week Weekdays { get; set; }
		public string Filename { get; set; }
		public string Msg { get; set; }
		public Alarm()
		{
			Weekdays = new Week();
		}
		public Alarm(DateTime date, TimeSpan time, Week weekdays, string filename, string msg)
		{
			this.Date = date;
			this.Time = time;
			this.Weekdays = weekdays;
			this.Filename = filename;
			this.Msg = msg;
            Console.WriteLine("Constructor: " + this.GetHashCode());
		}
		public Alarm(Alarm other)
		{
			this.Date = other.Date;
			this.Time = other.Time;
			this.Weekdays = other.Weekdays;
			this.Filename = other.Filename;
			this.Msg = other.Msg;
            Console.WriteLine("CopyConstrucor: " + this.GetHashCode());
		}
		public override string ToString()
		{
			string info = "";
			info += DateTime.Today.Add(Time).ToString("hh:mm:ss tt");
			info += "\t";
			info += Weekdays;
			info += "\t";
			info += Filename;
			info += "\t";
			info += Msg;
			info += "\t";
			if (Date != DateTime.MinValue)
			{
				info += Date;
			}
			return info;
		}
		public int CompareTo(Alarm other)
		{
			return this.Time.CompareTo(other.Time);
		}
	}
}