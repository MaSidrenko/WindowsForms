using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.AudioVideoPlayback;

namespace Clock
{
	public partial class AlarmsForm : Form
	{
		AddAlarmForm addAlarmDialog = null;
		OpenFileDialog openFile = null;
		Week Week = null;
		DateTimeFormatInfo formatInfo = null;
		Audio audio;
		public ListBox lb_Alarms
		{
			get => lbAlarms;
		}
		public AlarmsForm()
		{
			InitializeComponent();
			addAlarmDialog = new AddAlarmForm();
			openFile = new OpenFileDialog();
			Week = new Week();
			formatInfo = new DateTimeFormatInfo();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			addAlarmDialog.StartPosition = FormStartPosition.Manual;
			addAlarmDialog.Location = new Point
			(
				this.Location.X + 25,
				this.Location.Y + 25
			);
			DialogResult result = addAlarmDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				lbAlarms.Items.Add(new Alarm(addAlarmDialog.Alarm));
			}
		}

		private void Alarms_Tick(object sender, EventArgs e)
		{

			//if (lbAlarms.Items.Count != 0)
			//{
			//	lbAlarms.SetSelected(0, true);
			//	string[] alarms = lbAlarms.SelectedItem.ToString().Split('\t');
			//	if (DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture) == alarms[0] && formatInfo.GetShortestDayName(DateTime.Now.DayOfWeek) == alarms[1])
			//	{
			//		audio = new Audio(alarms[2]);
			//		audio.Play();
			//		MessageBox.Show
			//			(
			//			this,
			//			alarms[3] != null ? alarms[3] : "Алярм!",
			//			"Warning",
			//			MessageBoxButtons.OK,
			//			MessageBoxIcon.Warning
			//			);
			//		lbAlarms.Items.RemoveAt(0);
			//	}
			//}
		}

		private void lbAlarms_DoubleClick(object sender, EventArgs e)
		{
			addAlarmDialog.Alarm = lbAlarms.SelectedItem as Alarm;
			if (addAlarmDialog.ShowDialog() == DialogResult.OK)
			{
				lbAlarms.Items[lbAlarms.SelectedIndex] = addAlarmDialog.Alarm;
			}
		}
	}
}
