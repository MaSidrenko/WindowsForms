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
using System.IO;

namespace Clock
{
	public partial class ChooseFontForm : Form
	{
		public Font Font { get; set; }
		public string File_Name { get; set; }
		public ChooseFontForm()
		{
			InitializeComponent();
			LoadFonts();
			cbFonts.SelectedIndex = 0;
		}
		public ChooseFontForm(MainForm paranet, string Font_Name, int Font_Size)
		{
			InitializeComponent();
			this.Location = new Point
			(
				Screen.PrimaryScreen.Bounds.Width - paranet.Width - this.Width ,
				paranet.Location.Y*2
			);
			File_Name = Font_Name;
			nudFonstSize.Value = Font_Size;
			LoadFonts();
			cbFonts.SelectedIndex = cbFonts.Items.IndexOf(File_Name);
			Font = labelExample.Font;
		}
		void LoadFonts()
		{
			//Directory.SetCurrentDirectory("..\\..\\Font");
			Console.WriteLine(Directory.GetCurrentDirectory());

			cbFonts.Items.AddRange(GetFontsFromat("*.ttf"));
			cbFonts.Items.AddRange(GetFontsFromat("*.otf"));
		}
		static string[] GetFontsFromat(string format)
		{
			string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), format);
			for (int i = 0; i < files.Length; i++)
			{
				files[i] = files[i].Split('\\').Last();
			}
			return files;
		}
		private void btnOK_Click(object sender, EventArgs e)
		{
			cbFonts_SelectedIndexChanged(sender, e);
			Font = labelExample.Font;
			File_Name = cbFonts.SelectedItem.ToString();
		}

		private void cbFonts_SelectedIndexChanged(object sender, EventArgs e)
		{
			PrivateFontCollection pfc = new PrivateFontCollection();
			string full_name = Directory.GetCurrentDirectory() + "\\" + cbFonts.SelectedItem;
			//Console.WriteLine(full_name);
			pfc.AddFontFile(full_name);
			labelExample.Font = new Font(pfc.Families[0], Convert.ToInt32(nudFonstSize.Value));
		}

		private void btnApply_Click(object sender, EventArgs e)
		{
			cbFonts_SelectedIndexChanged(sender, e);
		}
	
	}
}
