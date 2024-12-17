using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Clock
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			labelTime.BackColor = Color.Black;
			labelTime.ForeColor = Color.DarkGreen;


			this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, 50);
	
			PrivateFontCollection fontCollection = new PrivateFontCollection();
			fontCollection.AddFontFile("E:\\Users\\Maxim Sidorenko\\source\\repos\\WindowsForms\\Clock\\Font\\matrix-font\\Matrix-MZ4P.ttf");

			FontFamily family = fontCollection.Families[0];
			labelTime.Font = new Font(family, 30);
			SetVisibility(false);
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
		private void timer_Tick(object sender, EventArgs e)
		{
			labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
			if (cbShowDate.Checked)
			{
				labelTime.Text += "\n";
				labelTime.Text += DateTime.Now.Date.ToString("yyyy.MM.dd");
			}
			if(cbShowWeekDay.Checked)
			{
				labelTime.Text += "\n";
				labelTime.Text += DateTime.Now.DayOfWeek;
			}
			notifyIcon.Text = labelTime.Text;
		}
		
		private void btnHideControls_Click(object sender, EventArgs e)
		{
			SetVisibility(cmShowContorls.Checked =  false);
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
			if(!this.TopMost)
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
			switch (((ToolStripMenuItem)sender).Text)
			{
				case "BackGround color": dialog.Color = labelTime.BackColor; break;
				case "Foreground color": dialog.Color = labelTime.ForeColor; break;
			}
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				switch((sender as ToolStripMenuItem).Text) // as - это оператор перобразования типов 
													// Оператор as значение слева приводит к типу данных справа 
				{
					case "BackGround color": labelTime.BackColor = dialog.Color; break;
					case "Foreground color": labelTime.ForeColor = dialog.Color; break;
				}
			}
		}

	}
}
