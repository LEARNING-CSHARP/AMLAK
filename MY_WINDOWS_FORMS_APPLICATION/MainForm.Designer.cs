namespace MY_WINDOWS_FORMS_APPLICATION
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

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
			this.myMenuStrip = new Dtx.Windows.Forms.MenuStrip();
			this.settingsToolStripMenuItem = new Dtx.Windows.Forms.ToolStripMenuItem();
			this.updateProfileToolStripMenuItem = new Dtx.Windows.Forms.ToolStripMenuItem();
			this.changePasswordToolStripMenuItem = new Dtx.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.logoutToolStripMenuItem = new Dtx.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new Dtx.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new Dtx.Windows.Forms.ToolStripMenuItem();
			this.administratorToolStripMenuItem = new Dtx.Windows.Forms.ToolStripMenuItem();
			this.displayUsersListFormToolStripMenuItem = new Dtx.Windows.Forms.ToolStripMenuItem();
			this.myStatusStrip = new Dtx.Windows.Forms.StatusStrip();
			this.welcomeToolStripStatusLabel = new Dtx.Windows.Forms.ToolStripStatusLabel();
			this.splitToolStripStatusLabel = new Dtx.Windows.Forms.ToolStripStatusLabel();
			this.persianCalendarToolStripStatusLabel = new Dtx.Windows.Forms.ToolStripStatusLabel();
			this.myMenuStrip.SuspendLayout();
			this.myStatusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// myMenuStrip
			// 
			this.myMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.administratorToolStripMenuItem});
			this.myMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.myMenuStrip.Name = "myMenuStrip";
			this.myMenuStrip.Size = new System.Drawing.Size(624, 24);
			this.myMenuStrip.TabIndex = 1;
			this.myMenuStrip.Text = "menuStrip1";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateProfileToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.toolStripSeparator1,
            this.logoutToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.settingsToolStripMenuItem.Text = "&تنظیمات";
			// 
			// updateProfileToolStripMenuItem
			// 
			this.updateProfileToolStripMenuItem.Name = "updateProfileToolStripMenuItem";
			this.updateProfileToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.updateProfileToolStripMenuItem.Text = "&ویرایش اطلاعات";
			this.updateProfileToolStripMenuItem.Click += new System.EventHandler(this.UpdateProfileToolStripMenuItem_Click);
			// 
			// changePasswordToolStripMenuItem
			// 
			this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
			this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.changePasswordToolStripMenuItem.Text = "تغییر &گذرواژه";
			this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.ChangePasswordToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
			// 
			// logoutToolStripMenuItem
			// 
			this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
			this.logoutToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.logoutToolStripMenuItem.Text = "&ورود مجدد";
			this.logoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.aboutToolStripMenuItem.Text = "&درباره ما";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.exitToolStripMenuItem.Text = "&خروج";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// administratorToolStripMenuItem
			// 
			this.administratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayUsersListFormToolStripMenuItem});
			this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
			this.administratorToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
			this.administratorToolStripMenuItem.Text = "تنظیمات مدیریتی";
			// 
			// displayUsersListFormToolStripMenuItem
			// 
			this.displayUsersListFormToolStripMenuItem.Name = "displayUsersListFormToolStripMenuItem";
			this.displayUsersListFormToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.displayUsersListFormToolStripMenuItem.Text = "مدیریت کاربران";
			this.displayUsersListFormToolStripMenuItem.Click += new System.EventHandler(this.DisplayUsersListFormToolStripMenuItem_Click);
			// 
			// myStatusStrip
			// 
			this.myStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcomeToolStripStatusLabel,
            this.splitToolStripStatusLabel,
            this.persianCalendarToolStripStatusLabel});
			this.myStatusStrip.Location = new System.Drawing.Point(0, 294);
			this.myStatusStrip.Name = "myStatusStrip";
			this.myStatusStrip.Size = new System.Drawing.Size(624, 22);
			this.myStatusStrip.TabIndex = 3;
			this.myStatusStrip.Text = "statusStrip1";
			// 
			// welcomeToolStripStatusLabel
			// 
			this.welcomeToolStripStatusLabel.Name = "welcomeToolStripStatusLabel";
			this.welcomeToolStripStatusLabel.Size = new System.Drawing.Size(32, 17);
			this.welcomeToolStripStatusLabel.Text = "-----";
			// 
			// splitToolStripStatusLabel
			// 
			this.splitToolStripStatusLabel.Name = "splitToolStripStatusLabel";
			this.splitToolStripStatusLabel.Size = new System.Drawing.Size(10, 17);
			this.splitToolStripStatusLabel.Text = "|";
			// 
			// persianCalendarToolStripStatusLabel
			// 
			this.persianCalendarToolStripStatusLabel.Name = "persianCalendarToolStripStatusLabel";
			this.persianCalendarToolStripStatusLabel.Size = new System.Drawing.Size(40, 17);
			this.persianCalendarToolStripStatusLabel.Text = "(-----)";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 316);
			this.Controls.Add(this.myStatusStrip);
			this.Controls.Add(this.myMenuStrip);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.myMenuStrip;
			this.Name = "MainForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "املاک";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.myMenuStrip.ResumeLayout(false);
			this.myMenuStrip.PerformLayout();
			this.myStatusStrip.ResumeLayout(false);
			this.myStatusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Dtx.Windows.Forms.MenuStrip myMenuStrip;
		private Dtx.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private Dtx.Windows.Forms.ToolStripMenuItem updateProfileToolStripMenuItem;
		private Dtx.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private Dtx.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
		private Dtx.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private Dtx.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private Dtx.Windows.Forms.StatusStrip myStatusStrip;
		private Dtx.Windows.Forms.ToolStripStatusLabel welcomeToolStripStatusLabel;
		private Dtx.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
		private Dtx.Windows.Forms.ToolStripMenuItem displayUsersListFormToolStripMenuItem;
		private Dtx.Windows.Forms.ToolStripStatusLabel splitToolStripStatusLabel;
		private Dtx.Windows.Forms.ToolStripStatusLabel persianCalendarToolStripStatusLabel;
	}
}
