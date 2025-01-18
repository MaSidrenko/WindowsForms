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
			if (Date != DateTime.MinValue)
			{
				info += Date + "\t";
			}
			info += DateTime.Today.Add(Time).ToString("hh:mm:ss tt");
			info += "\t";
			info += Weekdays + "\t";
			info += Filename + "\t";
			info += Msg + "\t";
			return info;
		}
		public string ToFileString()
		{
			string info = "";
			if (Date != DateTime.MinValue)
			{
				info += Date.Ticks;
			}
			info += "," + Time.Ticks + ","/*ToString("hh:mm:ss tt")*/;
			info += Weekdays.ToFileString() + ",";
			info += Filename + ",";
			info += Msg + ",";
			return info;
		}
		public static bool operator ==(Alarm left, Alarm right)
		{
			return
				left.Date == right.Date &&
				left.Time == right.Time &&
				left.Weekdays == right.Weekdays &&
				left.Filename == right.Filename &&
				left.Msg == right.Msg;
		}
		public static bool operator !=(Alarm left, Alarm right)
		{
			return !(left == right);
		}
		public int CompareTo(Alarm other)
		{
			return this.Time.CompareTo(other.Time);
		}
	}
}