using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Clock
{
	public class Week
	{
		public static readonly string[] WeekDays = new string[]
		{
			"Mo","Tu","We","Th","Fr","Sa","Su",
		};
		byte week;
		public Week()
		{
			week = 127;
		}
		public Week(bool[] days)
		{
			CompressWeekDays(days);
		}
		public void CompressWeekDays(bool[] days)
		{
			for (byte i = 0; i < days.Length; i++)
			{
				//byte day = 1;
				if (days[i]) week |= (byte)(1 << i);
			}
		}
		public bool[] ExtractWeekDays()
		{
			bool[] days = new bool[7];
			for (byte i = 0; i < days.Length; i++)
			{
				days[i] = (week & (byte)(1 << i)) != 0;
				//if(b == 1)days[i] = true;
			}
			return days;
		}
		public bool Contains(DayOfWeek day)
		{
			int i_Day = (int)day;
			i_Day -= 1;
			if (i_Day == -1) i_Day = 6;
			return (week & (1 << i_Day)) != 0;
		}
		public override string ToString()
		{
			string weekdays = "";
			for (byte i = 0; i < WeekDays.Length; i++)
			{
				//byte day = 1;
				if (((1 << i) & week) != 0)
					weekdays += WeekDays[i] + ",";
			}
			return weekdays;
		}
	}
}