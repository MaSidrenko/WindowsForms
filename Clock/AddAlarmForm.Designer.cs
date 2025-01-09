namespace Clock
{
	partial class AddAlarmForm
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
			this.cbUseDate = new System.Windows.Forms.CheckBox();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.dtpTime = new System.Windows.Forms.DateTimePicker();
			this.lblAlarmFile = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnFile = new System.Windows.Forms.Button();
			this.clbWeekDays = new System.Windows.Forms.CheckedListBox();
			this.rtbMsg = new System.Windows.Forms.RichTextBox();
			this.lblMsg = new System.Windows.Forms.Label();
			this.cbCallOnce = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// cbUseDate
			// 
			this.cbUseDate.AutoSize = true;
			this.cbUseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbUseDate.Location = new System.Drawing.Point(13, 13);
			this.cbUseDate.Name = "cbUseDate";
			this.cbUseDate.Size = new System.Drawing.Size(120, 29);
			this.cbUseDate.TabIndex = 0;
			this.cbUseDate.Text = "Use Date";
			this.cbUseDate.UseVisualStyleBackColor = true;
			this.cbUseDate.CheckedChanged += new System.EventHandler(this.cbUseDate_CheckedChanged);
			// 
			// dtpDate
			// 
			this.dtpDate.CustomFormat = "yyyy.MM.dd";
			this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDate.Location = new System.Drawing.Point(13, 49);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(166, 32);
			this.dtpDate.TabIndex = 1;
			this.dtpDate.Value = new System.DateTime(2025, 1, 7, 0, 0, 0, 0);
			// 
			// dtpTime
			// 
			this.dtpTime.CustomFormat = "hh:mm:ss tt";
			this.dtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpTime.Location = new System.Drawing.Point(185, 49);
			this.dtpTime.Name = "dtpTime";
			this.dtpTime.ShowUpDown = true;
			this.dtpTime.Size = new System.Drawing.Size(200, 32);
			this.dtpTime.TabIndex = 2;
			// 
			// lblAlarmFile
			// 
			this.lblAlarmFile.AutoSize = true;
			this.lblAlarmFile.Location = new System.Drawing.Point(12, 195);
			this.lblAlarmFile.Name = "lblAlarmFile";
			this.lblAlarmFile.Size = new System.Drawing.Size(26, 13);
			this.lblAlarmFile.TabIndex = 3;
			this.lblAlarmFile.Text = "File:";
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(229, 230);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "Ok";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(310, 230);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnFile
			// 
			this.btnFile.Location = new System.Drawing.Point(12, 230);
			this.btnFile.Name = "btnFile";
			this.btnFile.Size = new System.Drawing.Size(75, 23);
			this.btnFile.TabIndex = 6;
			this.btnFile.Text = "Choose File";
			this.btnFile.UseVisualStyleBackColor = true;
			this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
			// 
			// clbWeekDays
			// 
			this.clbWeekDays.CheckOnClick = true;
			this.clbWeekDays.ColumnWidth = 48;
			this.clbWeekDays.FormattingEnabled = true;
			this.clbWeekDays.HorizontalScrollbar = true;
			this.clbWeekDays.Items.AddRange(new object[] {
            "Mo",
            "Tu",
            "We",
            "Th",
            "Fr",
            "Sa",
            "Su"});
			this.clbWeekDays.Location = new System.Drawing.Point(12, 87);
			this.clbWeekDays.MultiColumn = true;
			this.clbWeekDays.Name = "clbWeekDays";
			this.clbWeekDays.Size = new System.Drawing.Size(373, 19);
			this.clbWeekDays.TabIndex = 7;
			// 
			// rtbMsg
			// 
			this.rtbMsg.Location = new System.Drawing.Point(13, 132);
			this.rtbMsg.Name = "rtbMsg";
			this.rtbMsg.Size = new System.Drawing.Size(372, 60);
			this.rtbMsg.TabIndex = 8;
			this.rtbMsg.Text = "";
			// 
			// lblMsg
			// 
			this.lblMsg.AutoSize = true;
			this.lblMsg.Location = new System.Drawing.Point(12, 113);
			this.lblMsg.Name = "lblMsg";
			this.lblMsg.Size = new System.Drawing.Size(77, 13);
			this.lblMsg.TabIndex = 9;
			this.lblMsg.Text = "Input Message";
			// 
			// cbCallOnce
			// 
			this.cbCallOnce.AutoSize = true;
			this.cbCallOnce.Checked = true;
			this.cbCallOnce.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbCallOnce.Location = new System.Drawing.Point(233, 109);
			this.cbCallOnce.Name = "cbCallOnce";
			this.cbCallOnce.Size = new System.Drawing.Size(145, 17);
			this.cbCallOnce.TabIndex = 10;
			this.cbCallOnce.Text = "Call several times a week";
			this.cbCallOnce.UseVisualStyleBackColor = true;
			this.cbCallOnce.CheckedChanged += new System.EventHandler(this.cbCallOnce_CheckedChanged);
			// 
			// AddAlarmForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(390, 259);
			this.Controls.Add(this.cbCallOnce);
			this.Controls.Add(this.lblMsg);
			this.Controls.Add(this.rtbMsg);
			this.Controls.Add(this.clbWeekDays);
			this.Controls.Add(this.btnFile);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.lblAlarmFile);
			this.Controls.Add(this.dtpTime);
			this.Controls.Add(this.dtpDate);
			this.Controls.Add(this.cbUseDate);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AddAlarmForm";
			this.Text = "AddAlarm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox cbUseDate;
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.DateTimePicker dtpTime;
		private System.Windows.Forms.Label lblAlarmFile;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnFile;
		private System.Windows.Forms.CheckedListBox clbWeekDays;
		private System.Windows.Forms.RichTextBox rtbMsg;
		private System.Windows.Forms.Label lblMsg;
		private System.Windows.Forms.CheckBox cbCallOnce;
	}
}