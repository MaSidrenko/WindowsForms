﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using Microsoft.Win32;


namespace Clock
{
	public partial class MainForm : Form
	{
		ChooseFontForm fontDialog = null;
		AlarmsForm alarmsDialog = null;
		public MainForm()
		{
			//System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("fr");
			InitializeComponent();
			labelTime.BackColor = Color.Black;
			labelTime.ForeColor = Color.DarkGreen;


			this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, 50);

			SetVisibility(false);
			cmShowConsole.Checked = true;
			cmTopmost.Checked = true;
			LoadSettings();
			//fontDialog = new ChooseFontForm();
			alarmsDialog = new AlarmsForm();
		}
		void SetVisibility(bool visible)
		{
			cbShowDate.Visible = visible;
			cbShowWeekDay.Visible = visible;
			btnHideControls.Visible = visible;
			this.TransparencyKey = visible ? Color.Empty : this.BackColor;
			this.FormBorderStyle = visible ? FormBorderStyle.FixedToolWindow : FormBorderStyle.None;
			this.ShowInTaskbar = visible;
		}
		void SaveSettings()
		{
			StreamWriter sw = new StreamWriter("Settings.ini");
			sw.WriteLine(cmTopmost.Checked);
			sw.WriteLine(cmShowContorls.Checked);
			sw.WriteLine(cmShowDate.Checked);
			sw.WriteLine(cmShowWeekDay.Checked);
			sw.WriteLine(cmShowConsole.Checked);
			sw.WriteLine(labelTime.BackColor.ToArgb());
			sw.WriteLine(labelTime.ForeColor.ToArgb());
			sw.WriteLine(fontDialog.File_Name);
			sw.WriteLine(labelTime.Font.Size);
			sw.Close();
			//Process.Start("notepad", "Settings.ini");
		}
		void LoadSettings()
		{

			string execution_path = Path.GetDirectoryName(Application.ExecutablePath);
			Directory.SetCurrentDirectory(execution_path + "\\..\\..\\Font");
			StreamReader sr = new StreamReader("Settings.ini");
			cmTopmost.Checked = bool.Parse(sr.ReadLine());
			cmShowContorls.Checked = bool.Parse(sr.ReadLine());
			cmShowDate.Checked = bool.Parse(sr.ReadLine());
			cmShowWeekDay.Checked = bool.Parse(sr.ReadLine());
			cmShowConsole.Checked = bool.Parse(sr.ReadLine());
			labelTime.BackColor = Color.FromArgb(Convert.ToInt32(sr.ReadLine()));
			labelTime.ForeColor = Color.FromArgb(Convert.ToInt32(sr.ReadLine()));
			string Font_Name = sr.ReadLine();
			int Font_Size = (int)Convert.ToDouble(sr.ReadLine());
			sr.Close();
			fontDialog = new ChooseFontForm(this, Font_Name, Font_Size);
			labelTime.Font = fontDialog.Font;
		}
		private void timer_Tick(object sender, EventArgs e)
		{
			labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
			if (cbShowDate.Checked)
			{
				labelTime.Text += "\n";
				labelTime.Text += DateTime.Now.Date.ToString("yyyy.MM.dd");
			}
			if (cbShowWeekDay.Checked)
			{
				labelTime.Text += "\n";
				labelTime.Text += DateTime.Now.DayOfWeek;
			}
			notifyIcon.Text = labelTime.Text;
		}

		private void btnHideControls_Click(object sender, EventArgs e)
		{
			SetVisibility(cmShowContorls.Checked = false);
		}

		private void labelTime_DoubleClick(object sender, EventArgs e)
		{
			SetVisibility(cmShowContorls.Checked = true);
		}

		private void cmExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cmTopmost_CheckedChanged(object sender, EventArgs e)
		{
			this.TopMost = cmTopmost.Checked;
		}

		private void cmShowDate_CheckedChanged(object sender, EventArgs e)
		{
			cbShowDate.Checked = cmShowDate.Checked;
		}

		private void cbShowDate_CheckedChanged(object sender, EventArgs e)
		{
			cmShowDate.Checked = cbShowDate.Checked;
		}

		private void cbShowWeekDay_CheckedChanged(object sender, EventArgs e)
		{
			cmShowWeekDay.Checked = cbShowWeekDay.Checked;
		}

		private void cmShowWeekDay_CheckedChanged(object sender, EventArgs e)
		{
			cbShowWeekDay.Checked = cmShowWeekDay.Checked;
		}

		private void notifyIcon_DoubleClick(object sender, EventArgs e)
		{
			if (!this.TopMost)
			{
				this.TopMost = true;
				this.TopMost = false;
			}
		}

		private void cmShowContorls_CheckedChanged(object sender, EventArgs e)
		{
			SetVisibility(cmShowContorls.Checked);
		}

		private void SetColor(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			//dialog.
			switch (((ToolStripMenuItem)sender).Text)
			{
				case "BackGround color": dialog.Color = labelTime.BackColor; break;
				case "Foreground color": dialog.Color = labelTime.ForeColor; break;
			}
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				switch ((sender as ToolStripMenuItem).Text) // as - это оператор перобразования типов 
															// Оператор as значение слева приводит к типу данных справа 
				{
					case "BackGround color": labelTime.BackColor = dialog.Color; break;
					case "Foreground color": labelTime.ForeColor = dialog.Color; break;
				}
			}
		}

		private void chooseFontToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (fontDialog.ShowDialog() == DialogResult.OK)
				labelTime.Font = fontDialog.Font;
		}

		private void cmShowConsole_CheckedChanged(object sender, EventArgs e)
		{
			if ((sender as ToolStripMenuItem).Checked)
				AllocConsole();
			else
				FreeConsole();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveSettings();
		}

		private void cmLoadOnWinStartup_CheckedChanged(object sender, EventArgs e)
		{
			string key_name = "ClockPV_319";
			RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true); //true - откроет ветку на запись 
			if (cmLoadOnWinStartup.Checked)
				rk.SetValue(key_name, Application.ExecutablePath);
			else
				rk.DeleteValue(key_name, false);
			rk.Dispose();
		}
		private void cmAlarms_Click(object sender, EventArgs e)
		{
			alarmsDialog.StartPosition = FormStartPosition.Manual;
			alarmsDialog.Location = new Point
			(
				this.Location.X - alarmsDialog.Width,
				this.Location.Y
			);
			alarmsDialog.ShowDialog();
		}
		[DllImport("kernel32.dll")]
		public static extern bool AllocConsole();
		[DllImport("kernel32.dll")]
		public static extern bool FreeConsole();


	}
}
