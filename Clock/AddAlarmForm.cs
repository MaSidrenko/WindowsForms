﻿using ATL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Clock
{
	public partial class AddAlarmForm : Form
	{
		public Alarm Alarm { get; set; }
		OpenFileDialog openFileDialog = null;

		public AddAlarmForm()
		{
			InitializeComponent();
			dtpDate.Enabled = false;

			Alarm = new Alarm();
			openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "All sound files (*.mp3, *.wav, *.flac)|*.mp3;*.wav;*.flac|MP-3(*.mp3)|*.mp3|WAV(*.wav)|*.wav|Flac (*.flac)|*.flac";
		}

		private void cbUseDate_CheckedChanged(object sender, EventArgs e)
		{
			dtpDate.Enabled = cbUseDate.Checked;
			clbWeekDays.Enabled = !cbUseDate.Checked;
		}
		void SetWeekDays(bool[] days)
		{
			for (int i = 0; i < clbWeekDays.Items.Count; i++)
			{
				clbWeekDays.SetItemChecked(i, days[i]);
			}

		}
		private void btnOK_Click(object sender, EventArgs e)
		{
			Week week = new Week
				(
					clbWeekDays.Items.
					Cast<object>().
					Select((item, index) => clbWeekDays.
					GetItemChecked(index)).
					ToArray()
				);
			Alarm.Date = dtpDate.Enabled ? dtpDate.Value : DateTime.MinValue;
			Alarm.Time = dtpTime.Value.TimeOfDay;
			Alarm.Weekdays = week;
			Alarm.Filename = lblAlarmFile.Text;
			Alarm.Msg = rtbMsg.Text;
			if (Alarm.Filename == "" || Alarm.Filename == "File:")
			{
				this.DialogResult = DialogResult.None;
				MessageBox.Show
					(
					this,
					"Выбирите звуковой файл",
					"Warning",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
					);
			}
		}
		private void btnFile_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				lblAlarmFile.Text = openFileDialog.FileName;
			}
		}

		private void AddAlarmForm_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < clbWeekDays.Items.Count; i++)
			{
				clbWeekDays.SetItemChecked(i, true);
			}
			if ((object)Alarm != null)
			{
				if (Alarm.Date != DateTime.MinValue)
				{
					cbUseDate.Checked = true;
					dtpDate.Value = Alarm.Date;
				}
				dtpTime.Value = DateTime.Now.Date + Alarm.Time;
				SetWeekDays(Alarm.Weekdays.ExtractWeekDays());
				lblAlarmFile.Text = Alarm.Filename;
				rtbMsg.Text = Alarm.Msg;
			}

		}
	}

}