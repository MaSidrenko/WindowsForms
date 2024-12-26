using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public partial class AlarmsForm : Form
	{
		AddAlarmForm addAlarmDialog = null;
		OpenFileDialog openFile = null;
		public AlarmsForm()
		{
			InitializeComponent();
			addAlarmDialog = new AddAlarmForm();
			openFile = new OpenFileDialog();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			addAlarmDialog.StartPosition = FormStartPosition.Manual;
			addAlarmDialog.Location = new Point
			(
				this.Location.X + 25,
				this.Location.Y + 25
			);
			addAlarmDialog.ShowDialog();
		}
	}
}
