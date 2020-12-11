namespace GeforceNowQueVB
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualSelectFilePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectLogFileManuallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convienceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opacityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.timerIntervalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hideProgressbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.totalRunTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.currentPositionLabel = new System.Windows.Forms.Label();
            this.bgPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.averageQueueTime = new System.Windows.Forms.Label();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.clickToForceUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTimer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.averageQueTimeInMinutesLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.totalDifferentQueueStagesLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(404, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualSelectFilePathToolStripMenuItem,
            this.convienceToolStripMenuItem,
            this.creditsToolStripMenuItem,
            this.modeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // manualSelectFilePathToolStripMenuItem
            // 
            this.manualSelectFilePathToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectLogFileManuallyToolStripMenuItem});
            this.manualSelectFilePathToolStripMenuItem.Name = "manualSelectFilePathToolStripMenuItem";
            this.manualSelectFilePathToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.manualSelectFilePathToolStripMenuItem.Text = "File path";
            // 
            // selectLogFileManuallyToolStripMenuItem
            // 
            this.selectLogFileManuallyToolStripMenuItem.Name = "selectLogFileManuallyToolStripMenuItem";
            this.selectLogFileManuallyToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.selectLogFileManuallyToolStripMenuItem.Text = "Select log file manually";
            this.selectLogFileManuallyToolStripMenuItem.Click += new System.EventHandler(this.selectLogFileManuallyToolStripMenuItem_Click);
            // 
            // convienceToolStripMenuItem
            // 
            this.convienceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysOnTopToolStripMenuItem,
            this.opacityToolStripMenuItem,
            this.timerIntervalToolStripMenuItem,
            this.hideProgressbarToolStripMenuItem});
            this.convienceToolStripMenuItem.Name = "convienceToolStripMenuItem";
            this.convienceToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.convienceToolStripMenuItem.Text = "Convenience";
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "Always on top";
            this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
            // 
            // opacityToolStripMenuItem
            // 
            this.opacityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem5,
            this.toolStripMenuItem4});
            this.opacityToolStripMenuItem.Name = "opacityToolStripMenuItem";
            this.opacityToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.opacityToolStripMenuItem.Text = "Opacity";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem2.Text = "25%";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem3.Text = "50%";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem5.Text = "75%";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem4.Text = "100%";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // timerIntervalToolStripMenuItem
            // 
            this.timerIntervalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secondsToolStripMenuItem,
            this.secondsToolStripMenuItem1});
            this.timerIntervalToolStripMenuItem.Name = "timerIntervalToolStripMenuItem";
            this.timerIntervalToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.timerIntervalToolStripMenuItem.Text = "Timer Interval";
            // 
            // secondsToolStripMenuItem
            // 
            this.secondsToolStripMenuItem.Name = "secondsToolStripMenuItem";
            this.secondsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.secondsToolStripMenuItem.Text = "30 Seconds";
            this.secondsToolStripMenuItem.Click += new System.EventHandler(this.secondsToolStripMenuItem_Click);
            // 
            // secondsToolStripMenuItem1
            // 
            this.secondsToolStripMenuItem1.Name = "secondsToolStripMenuItem1";
            this.secondsToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.secondsToolStripMenuItem1.Text = "10 Seconds";
            this.secondsToolStripMenuItem1.Click += new System.EventHandler(this.secondsToolStripMenuItem1_Click);
            // 
            // hideProgressbarToolStripMenuItem
            // 
            this.hideProgressbarToolStripMenuItem.Name = "hideProgressbarToolStripMenuItem";
            this.hideProgressbarToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.hideProgressbarToolStripMenuItem.Text = "Toggle Progressbar";
            this.hideProgressbarToolStripMenuItem.Click += new System.EventHandler(this.hideProgressbarToolStripMenuItem_Click);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.githubToolStripMenuItem,
            this.websiteToolStripMenuItem});
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            // 
            // githubToolStripMenuItem
            // 
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            this.githubToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.githubToolStripMenuItem.Text = "Github";
            this.githubToolStripMenuItem.Click += new System.EventHandler(this.githubToolStripMenuItem_Click);
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.websiteToolStripMenuItem.Text = "Website";
            this.websiteToolStripMenuItem.Click += new System.EventHandler(this.websiteToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AllowMerge = false;
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripProgressBar1,
            this.totalRunTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 183);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(404, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // totalRunTime
            // 
            this.totalRunTime.Name = "totalRunTime";
            this.totalRunTime.Size = new System.Drawing.Size(101, 17);
            this.totalRunTime.Text = "15 minutes in que";
            // 
            // currentPositionLabel
            // 
            this.currentPositionLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentPositionLabel.Font = new System.Drawing.Font("ISL_Jupiter", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPositionLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.currentPositionLabel.Location = new System.Drawing.Point(0, 139);
            this.currentPositionLabel.Name = "currentPositionLabel";
            this.currentPositionLabel.Size = new System.Drawing.Size(196, 41);
            this.currentPositionLabel.TabIndex = 1;
            this.currentPositionLabel.Text = "0";
            this.currentPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bgPanel
            // 
            this.bgPanel.BackColor = System.Drawing.Color.White;
            this.bgPanel.Controls.Add(this.label1);
            this.bgPanel.Controls.Add(this.label2);
            this.bgPanel.Controls.Add(this.averageQueueTime);
            this.bgPanel.Controls.Add(this.currentPositionLabel);
            this.bgPanel.Controls.Add(this.statusStrip1);
            this.bgPanel.Controls.Add(this.menuStrip1);
            this.bgPanel.Controls.Add(this.pictureBox1);
            this.bgPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgPanel.Location = new System.Drawing.Point(0, 0);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Size = new System.Drawing.Size(404, 205);
            this.bgPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("ISL_Jupiter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Estimated Queue Time";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // averageQueueTime
            // 
            this.averageQueueTime.BackColor = System.Drawing.Color.Transparent;
            this.averageQueueTime.Font = new System.Drawing.Font("ISL_Jupiter", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageQueueTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.averageQueueTime.Location = new System.Drawing.Point(205, 139);
            this.averageQueueTime.Name = "averageQueueTime";
            this.averageQueueTime.Size = new System.Drawing.Size(196, 41);
            this.averageQueueTime.TabIndex = 7;
            this.averageQueueTime.Text = "105 minutes";
            this.averageQueueTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.compactToolStripMenuItem,
            this.darkToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            // 
            // compactToolStripMenuItem
            // 
            this.compactToolStripMenuItem.Name = "compactToolStripMenuItem";
            this.compactToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.compactToolStripMenuItem.Text = "Compact";
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("ISL_Jupiter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Current Position";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clickToForceUpdateToolStripMenuItem,
            this.labelTimer,
            this.toolStripMenuItem1});
            this.toolStripSplitButton1.Image = global::GeforceNowQueueDisplay.Properties.Resources.setting2;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // clickToForceUpdateToolStripMenuItem
            // 
            this.clickToForceUpdateToolStripMenuItem.Name = "clickToForceUpdateToolStripMenuItem";
            this.clickToForceUpdateToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.clickToForceUpdateToolStripMenuItem.Text = "Force Update";
            this.clickToForceUpdateToolStripMenuItem.Click += new System.EventHandler(this.clickToForceUpdateToolStripMenuItem_Click);
            // 
            // labelTimer
            // 
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(215, 22);
            this.labelTimer.Text = "Next update in (0) seconds";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.averageQueTimeInMinutesLabel,
            this.totalDifferentQueueStagesLabel});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
            this.toolStripMenuItem1.Text = "Information";
            // 
            // averageQueTimeInMinutesLabel
            // 
            this.averageQueTimeInMinutesLabel.Name = "averageQueTimeInMinutesLabel";
            this.averageQueTimeInMinutesLabel.Size = new System.Drawing.Size(216, 22);
            this.averageQueTimeInMinutesLabel.Text = "averageQueTimeInMinutes";
            // 
            // totalDifferentQueueStagesLabel
            // 
            this.totalDifferentQueueStagesLabel.Name = "totalDifferentQueueStagesLabel";
            this.totalDifferentQueueStagesLabel.Size = new System.Drawing.Size(216, 22);
            this.totalDifferentQueueStagesLabel.Text = "totalDifferentQueueStages";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GeforceNowQueueDisplay.Properties.Resources.NV_GeForce_Now_logo_2C_vert_CMYK_1443609475_640x209;
            this.pictureBox1.Location = new System.Drawing.Point(42, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 205);
            this.Controls.Add(this.bgPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeForce Now Queue Display";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.bgPanel.ResumeLayout(false);
            this.bgPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualSelectFilePathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem labelTimer;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Label currentPositionLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel bgPanel;
        private System.Windows.Forms.ToolStripStatusLabel totalRunTime;
        private System.Windows.Forms.ToolStripMenuItem clickToForceUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convienceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opacityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem selectLogFileManuallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerIntervalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hideProgressbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label averageQueueTime;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem averageQueTimeInMinutesLabel;
        private System.Windows.Forms.ToolStripMenuItem totalDifferentQueueStagesLabel;
    }
}

