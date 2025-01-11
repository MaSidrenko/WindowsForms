using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			week = 0;
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
				if(days[i]) week |= (byte)(1 << i);
			}
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