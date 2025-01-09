using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
	public class Alarm
	{
		public DateTime Date { get; set; }
		public TimeSpan Time { get; set; }
		public Week Weekdays {  get; set; }
		public string Filename { get; set; }
		public string Msg { get; set; }
		public Alarm()
		{
			
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
	}
}
