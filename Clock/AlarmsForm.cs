﻿using System;
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
			addAlarmDialog = new AddAlarmForm();
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
		private void lbAlarms_DoubleClick(object sender, EventArgs e)
		{
			if (lbAlarms.Items.Count > 0)
			{
				if (lbAlarms.SelectedItem != null)
				{
					addAlarmDialog.Alarm = lbAlarms.SelectedItem as Alarm;
					addAlarmDialog.Location = new Point
					(
						this.Location.X + 25,
						this.Location.Y + 25
					);
					if (addAlarmDialog.ShowDialog() == DialogResult.OK)
					{
						lbAlarms.Items[lbAlarms.SelectedIndex] = addAlarmDialog.Alarm;
					}
				}
				else MessageBox.Show(this, "Выберите будильник", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else btnAdd_Click(sender, e);
		}
		private void btnDelAlarm_Click(object sender, EventArgs e)
		{
			lbAlarms.Items.Remove(lbAlarms.SelectedItem);
		}

		private void lbAlarms_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Delete)
			{
				btnDelAlarm_Click(sender, e);
			}
		}
	}
}
