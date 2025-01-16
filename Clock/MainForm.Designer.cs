namespace Clock
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.labelTime = new System.Windows.Forms.Label();
			this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cmTopmost = new System.Windows.Forms.ToolStripMenuItem();
			this.cmAlarms = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.cmShowDate = new System.Windows.Forms.ToolStripMenuItem();
			this.cmShowWeekDay = new System.Windows.Forms.ToolStripMenuItem();
			this.cmShowContorls = new System.Windows.Forms.ToolStripMenuItem();
			this.cmShowConsole = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.chooseFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cmBackColor = new System.Windows.Forms.ToolStripMenuItem();
			this.cmForeColor = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.cmLoadOnWinStartup = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.cmExit = new System.Windows.Forms.ToolStripMenuItem();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.cbShowDate = new System.Windows.Forms.CheckBox();
			this.btnHideControls = new System.Windows.Forms.Button();
			this.cbShowWeekDay = new System.Windows.Forms.CheckBox();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
			this.contextMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
			this.SuspendLayout();
			// 
			// labelTime
			// 
			this.labelTime.AutoSize = true;
			this.labelTime.ContextMenuStrip = this.contextMenu;
			this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelTime.Location = new System.Drawing.Point(12, 9);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(210, 51);
			this.labelTime.TabIndex = 0;
			this.labelTime.Text = "labelTime";
			this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelTime.DoubleClick += new System.EventHandler(this.labelTime_DoubleClick);
			// 
			// contextMenu
			// 
			this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmTopmost,
            this.cmAlarms,
            this.toolStripSeparator1,
            this.cmShowDate,
            this.cmShowWeekDay,
            this.cmShowContorls,
            this.cmShowConsole,
            this.toolStripSeparator3,
            this.chooseFontToolStripMenuItem,
            this.colorsToolStripMenuItem,
            this.toolStripSeparator2,
            this.cmLoadOnWinStartup,
            this.toolStripSeparator4,
            this.cmExit});
			this.contextMenu.Name = "contextMenu";
			this.contextMenu.Size = new System.Drawing.Size(210, 248);
			// 
			// cmTopmost
			// 
			this.cmTopmost.CheckOnClick = true;
			this.cmTopmost.Name = "cmTopmost";
			this.cmTopmost.Size = new System.Drawing.Size(209, 22);
			this.cmTopmost.Text = "Topmost";
			this.cmTopmost.CheckedChanged += new System.EventHandler(this.cmTopmost_CheckedChanged);
			// 
			// cmAlarms
			// 
			this.cmAlarms.Name = "cmAlarms";
			this.cmAlarms.Size = new System.Drawing.Size(209, 22);
			this.cmAlarms.Text = "Alarms";
			this.cmAlarms.Click += new System.EventHandler(this.cmAlarms_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
			// 
			// cmShowDate
			// 
			this.cmShowDate.CheckOnClick = true;
			this.cmShowDate.Name = "cmShowDate";
			this.cmShowDate.Size = new System.Drawing.Size(209, 22);
			this.cmShowDate.Text = "Show date";
			this.cmShowDate.CheckedChanged += new System.EventHandler(this.cmShowDate_CheckedChanged);
			// 
			// cmShowWeekDay
			// 
			this.cmShowWeekDay.CheckOnClick = true;
			this.cmShowWeekDay.Name = "cmShowWeekDay";
			this.cmShowWeekDay.Size = new System.Drawing.Size(209, 22);
			this.cmShowWeekDay.Text = "Show week day";
			this.cmShowWeekDay.CheckedChanged += new System.EventHandler(this.cmShowWeekDay_CheckedChanged);
			// 
			// cmShowContorls
			// 
			this.cmShowContorls.CheckOnClick = true;
			this.cmShowContorls.Name = "cmShowContorls";
			this.cmShowContorls.Size = new System.Drawing.Size(209, 22);
			this.cmShowContorls.Text = "Show controls";
			this.cmShowContorls.CheckedChanged += new System.EventHandler(this.cmShowContorls_CheckedChanged);
			// 
			// cmShowConsole
			// 
			this.cmShowConsole.CheckOnClick = true;
			this.cmShowConsole.Name = "cmShowConsole";
			this.cmShowConsole.Size = new System.Drawing.Size(209, 22);
			this.cmShowConsole.Text = "Show console";
			this.cmShowConsole.CheckedChanged += new System.EventHandler(this.cmShowConsole_CheckedChanged);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(206, 6);
			// 
			// chooseFontToolStripMenuItem
			// 
			this.chooseFontToolStripMenuItem.Name = "chooseFontToolStripMenuItem";
			this.chooseFontToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
			this.chooseFontToolStripMenuItem.Text = "Choose Font";
			this.chooseFontToolStripMenuItem.Click += new System.EventHandler(this.chooseFontToolStripMenuItem_Click);
			// 
			// colorsToolStripMenuItem
			// 
			this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmBackColor,
            this.cmForeColor});
			this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
			this.colorsToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
			this.colorsToolStripMenuItem.Text = "Colors";
			// 
			// cmBackColor
			// 
			this.cmBackColor.Name = "cmBackColor";
			this.cmBackColor.Size = new System.Drawing.Size(169, 22);
			this.cmBackColor.Text = "BackGround color";
			this.cmBackColor.Click += new System.EventHandler(this.SetColor);
			// 
			// cmForeColor
			// 
			this.cmForeColor.Name = "cmForeColor";
			this.cmForeColor.Size = new System.Drawing.Size(169, 22);
			this.cmForeColor.Text = "Foreground color";
			this.cmForeColor.Click += new System.EventHandler(this.SetColor);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(206, 6);
			// 
			// cmLoadOnWinStartup
			// 
			this.cmLoadOnWinStartup.CheckOnClick = true;
			this.cmLoadOnWinStartup.Name = "cmLoadOnWinStartup";
			this.cmLoadOnWinStartup.Size = new System.Drawing.Size(209, 22);
			this.cmLoadOnWinStartup.Text = "Load on Windows startup";
			this.cmLoadOnWinStartup.CheckedChanged += new System.EventHandler(this.cmLoadOnWinStartup_CheckedChanged);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(206, 6);
			// 
			// cmExit
			// 
			this.cmExit.Name = "cmExit";
			this.cmExit.Size = new System.Drawing.Size(209, 22);
			this.cmExit.Text = "Exit";
			this.cmExit.Click += new System.EventHandler(this.cmExit_Click);
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// cbShowDate
			// 
			this.cbShowDate.AutoSize = true;
			this.cbShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbShowDate.Location = new System.Drawing.Point(21, 198);
			this.cbShowDate.Name = "cbShowDate";
			this.cbShowDate.Size = new System.Drawing.Size(179, 30);
			this.cbShowDate.TabIndex = 1;
			this.cbShowDate.Text = "Показать дату";
			this.cbShowDate.UseVisualStyleBackColor = true;
			this.cbShowDate.CheckedChanged += new System.EventHandler(this.cbShowDate_CheckedChanged);
			// 
			// btnHideControls
			// 
			this.btnHideControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnHideControls.Location = new System.Drawing.Point(21, 279);
			this.btnHideControls.Name = "btnHideControls";
			this.btnHideControls.Size = new System.Drawing.Size(179, 58);
			this.btnHideControls.TabIndex = 2;
			this.btnHideControls.Text = "Hide controls";
			this.btnHideControls.UseVisualStyleBackColor = true;
			this.btnHideControls.Click += new System.EventHandler(this.btnHideControls_Click);
			// 
			// cbShowWeekDay
			// 
			this.cbShowWeekDay.AutoSize = true;
			this.cbShowWeekDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbShowWeekDay.Location = new System.Drawing.Point(21, 235);
			this.cbShowWeekDay.Name = "cbShowWeekDay";
			this.cbShowWeekDay.Size = new System.Drawing.Size(262, 30);
			this.cbShowWeekDay.TabIndex = 3;
			this.cbShowWeekDay.Text = "Показать день недели";
			this.cbShowWeekDay.UseVisualStyleBackColor = true;
			this.cbShowWeekDay.CheckedChanged += new System.EventHandler(this.cbShowWeekDay_CheckedChanged);
			// 
			// notifyIcon
			// 
			this.notifyIcon.ContextMenuStrip = this.contextMenu;
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "notifyIcon1";
			this.notifyIcon.Visible = true;
			this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
			// 
			// axWindowsMediaPlayer
			// 
			this.axWindowsMediaPlayer.Enabled = true;
			this.axWindowsMediaPlayer.Location = new System.Drawing.Point(12, 75);
			this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
			this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
			this.axWindowsMediaPlayer.Size = new System.Drawing.Size(262, 47);
			this.axWindowsMediaPlayer.TabIndex = 4;
			this.axWindowsMediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.SetPlayerInvisible);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(290, 345);
			this.Controls.Add(this.axWindowsMediaPlayer);
			this.Controls.Add(this.cbShowWeekDay);
			this.Controls.Add(this.btnHideControls);
			this.Controls.Add(this.cbShowDate);
			this.Controls.Add(this.labelTime);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "ClockPV_319 ";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.contextMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelTime;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.CheckBox cbShowDate;
		private System.Windows.Forms.Button btnHideControls;
		private System.Windows.Forms.CheckBox cbShowWeekDay;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ContextMenuStrip contextMenu;
		private System.Windows.Forms.ToolStripMenuItem cmTopmost;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem cmShowDate;
		private System.Windows.Forms.ToolStripMenuItem cmShowWeekDay;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem cmExit;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cmBackColor;
		private System.Windows.Forms.ToolStripMenuItem cmForeColor;
		private System.Windows.Forms.ToolStripMenuItem cmShowContorls;
		private System.Windows.Forms.ToolStripMenuItem chooseFontToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cmShowConsole;
		private System.Windows.Forms.ToolStripMenuItem cmLoadOnWinStartup;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem cmAlarms;
		private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
	}
}

