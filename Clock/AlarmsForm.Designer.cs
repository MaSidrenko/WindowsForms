namespace Clock
{
	partial class AlarmsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmsForm));
			this.btnOK = new System.Windows.Forms.Button();
			this.btnDelAlarm = new System.Windows.Forms.Button();
			this.lbAlarms = new System.Windows.Forms.ListBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.Alarms = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(427, 12);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "Ok";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// btnDelAlarm
			// 
			this.btnDelAlarm.Location = new System.Drawing.Point(427, 70);
			this.btnDelAlarm.Name = "btnDelAlarm";
			this.btnDelAlarm.Size = new System.Drawing.Size(75, 23);
			this.btnDelAlarm.TabIndex = 2;
			this.btnDelAlarm.Text = "Delete";
			this.btnDelAlarm.UseVisualStyleBackColor = true;
			// 
			// lbAlarms
			// 
			this.lbAlarms.FormattingEnabled = true;
			this.lbAlarms.Location = new System.Drawing.Point(12, 12);
			this.lbAlarms.Name = "lbAlarms";
			this.lbAlarms.Size = new System.Drawing.Size(409, 264);
			this.lbAlarms.TabIndex = 3;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(427, 41);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// Alarms
			// 
			this.Alarms.Enabled = true;
			this.Alarms.Interval = 1000;
			this.Alarms.Tick += new System.EventHandler(this.Alarms_Tick);
			// 
			// AlarmsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(514, 280);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lbAlarms);
			this.Controls.Add(this.btnDelAlarm);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AlarmsForm";
			this.Text = "Alarms";
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnDelAlarm;
		private System.Windows.Forms.ListBox lbAlarms;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Timer Alarms;
	}
}