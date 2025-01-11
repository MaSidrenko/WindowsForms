using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
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
		//public static bool operator >(Alarm left, Alarm right)
		//{
		//	if (left.Date != DateTime.MinValue || right.Date != DateTime.MinValue)
		//		return
		//			left.Time > right.Time &&
		//			(left.Date == DateTime.MinValue ? DateTime.Today : left.Date) >=
		//			(right.Date == DateTime.MinValue ? DateTime.Today : right.Date);
		//	else
		//		return left.Time > right.Time;
		//}
		//public static bool operator <(Alarm left, Alarm right)
		//{
		//	if (left.Date != DateTime.MinValue || right.Date != DateTime.MinValue)
		//		return 
		//			left.Time < right.Time &&
		//			(left.Date == DateTime.MinValue ? DateTime.Today : left.Date) <=
		//			(right.Date == DateTime.MinValue ? DateTime.Today : right.Date);
		//	else
		//		return left.Time < right.Time;
		//}
		public int CompareTo(Alarm other)
		{
			return this.Time.CompareTo(other.Time);
		}
	}
}