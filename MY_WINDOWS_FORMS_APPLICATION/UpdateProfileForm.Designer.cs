namespace MY_WINDOWS_FORMS_APPLICATION
{
	partial class UpdateProfileForm
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
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.informationAccountGroupBox = new Dtx.Windows.Forms.GroupBox();
			this.exitButton = new Dtx.Windows.Forms.Button();
			this.mainFormButton = new Dtx.Windows.Forms.Button();
			this.resetButton = new Dtx.Windows.Forms.Button();
			this.updateButton = new Dtx.Windows.Forms.Button();
			this.pictureChangeLinkLabel = new Dtx.Windows.Forms.linkLabel();
			this.appliedIinformationGroupBox = new Dtx.Windows.Forms.GroupBox();
			this.descriptionTextBox = new Dtx.Windows.Forms.TextBox();
			this.decriptionLabel = new Dtx.Windows.Forms.Label();
			this.fullNameTextBox = new Dtx.Windows.Forms.TextBox();
			this.fullNameLabel = new Dtx.Windows.Forms.Label();
			this.userImagePictureBox = new Dtx.Windows.Forms.PictureBox();
			this.informationUserGoupBox = new Dtx.Windows.Forms.GroupBox();
			this.statususerCheckBox = new Dtx.Windows.Forms.CheckBox();
			this.IDTextBox = new Dtx.Windows.Forms.TextBox();
			this.IDLabel = new Dtx.Windows.Forms.Label();
			this.changePasswordLinkLabel = new Dtx.Windows.Forms.linkLabel();
			this.passwordTextBox = new Dtx.Windows.Forms.TextBox();
			this.usernameTextBox = new Dtx.Windows.Forms.TextBox();
			this.passworLabel = new Dtx.Windows.Forms.Label();
			this.usernameLabel = new Dtx.Windows.Forms.Label();
			this.statusStrip1 = new Dtx.Windows.Forms.StatusStrip();
			this.welcomToolStripStatusLabel = new Dtx.Windows.Forms.ToolStripStatusLabel();
			this.informationAccountGroupBox.SuspendLayout();
			this.appliedIinformationGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.userImagePictureBox)).BeginInit();
			this.informationUserGoupBox.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// informationAccountGroupBox
			// 
			this.informationAccountGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.informationAccountGroupBox.Controls.Add(this.exitButton);
			this.informationAccountGroupBox.Controls.Add(this.mainFormButton);
			this.informationAccountGroupBox.Controls.Add(this.resetButton);
			this.informationAccountGroupBox.Controls.Add(this.updateButton);
			this.informationAccountGroupBox.Controls.Add(this.pictureChangeLinkLabel);
			this.informationAccountGroupBox.Controls.Add(this.appliedIinformationGroupBox);
			this.informationAccountGroupBox.Controls.Add(this.userImagePictureBox);
			this.informationAccountGroupBox.Controls.Add(this.informationUserGoupBox);
			this.informationAccountGroupBox.Location = new System.Drawing.Point(13, 12);
			this.informationAccountGroupBox.Name = "informationAccountGroupBox";
			this.informationAccountGroupBox.Size = new System.Drawing.Size(499, 423);
			this.informationAccountGroupBox.TabIndex = 0;
			this.informationAccountGroupBox.TabStop = false;
			this.informationAccountGroupBox.Text = "اطلاعات حساب";
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(6, 288);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(137, 23);
			this.exitButton.TabIndex = 6;
			this.exitButton.Text = "&خروج";
			this.exitButton.UseVisualStyleBackColor = false;
			this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// mainFormButton
			// 
			this.mainFormButton.Location = new System.Drawing.Point(6, 259);
			this.mainFormButton.Name = "mainFormButton";
			this.mainFormButton.Size = new System.Drawing.Size(137, 23);
			this.mainFormButton.TabIndex = 5;
			this.mainFormButton.Text = "&صفحه اصلی";
			this.mainFormButton.UseVisualStyleBackColor = false;
			this.mainFormButton.Click += new System.EventHandler(this.MainFormButton_Click);
			// 
			// resetButton
			// 
			this.resetButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.resetButton.Location = new System.Drawing.Point(6, 230);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(137, 23);
			this.resetButton.TabIndex = 4;
			this.resetButton.Text = "&حالت اولیه";
			this.resetButton.UseVisualStyleBackColor = false;
			this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// updateButton
			// 
			this.updateButton.Location = new System.Drawing.Point(6, 203);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(137, 23);
			this.updateButton.TabIndex = 3;
			this.updateButton.Text = "&بروز رسانی";
			this.updateButton.UseVisualStyleBackColor = false;
			this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
			// 
			// pictureChangeLinkLabel
			// 
			this.pictureChangeLinkLabel.AutoSize = true;
			this.pictureChangeLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.pictureChangeLinkLabel.Location = new System.Drawing.Point(47, 178);
			this.pictureChangeLinkLabel.Name = "pictureChangeLinkLabel";
			this.pictureChangeLinkLabel.Size = new System.Drawing.Size(59, 13);
			this.pictureChangeLinkLabel.TabIndex = 2;
			this.pictureChangeLinkLabel.TabStop = true;
			this.pictureChangeLinkLabel.Text = "تغییر عکس";
			this.pictureChangeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PictureChangeLinkLabel_LinkClicked);
			// 
			// appliedIinformationGroupBox
			// 
			this.appliedIinformationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.appliedIinformationGroupBox.Controls.Add(this.descriptionTextBox);
			this.appliedIinformationGroupBox.Controls.Add(this.decriptionLabel);
			this.appliedIinformationGroupBox.Controls.Add(this.fullNameTextBox);
			this.appliedIinformationGroupBox.Controls.Add(this.fullNameLabel);
			this.appliedIinformationGroupBox.Location = new System.Drawing.Point(151, 203);
			this.appliedIinformationGroupBox.Name = "appliedIinformationGroupBox";
			this.appliedIinformationGroupBox.Size = new System.Drawing.Size(342, 210);
			this.appliedIinformationGroupBox.TabIndex = 1;
			this.appliedIinformationGroupBox.TabStop = false;
			this.appliedIinformationGroupBox.Text = "اطلاعات کاربردی";
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.descriptionTextBox.Location = new System.Drawing.Point(6, 47);
			this.descriptionTextBox.MaxLength = 200;
			this.descriptionTextBox.Multiline = true;
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.descriptionTextBox.Size = new System.Drawing.Size(248, 158);
			this.descriptionTextBox.TabIndex = 3;
			// 
			// decriptionLabel
			// 
			this.decriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.decriptionLabel.AutoSize = true;
			this.decriptionLabel.Location = new System.Drawing.Point(289, 50);
			this.decriptionLabel.Name = "decriptionLabel";
			this.decriptionLabel.Size = new System.Drawing.Size(47, 13);
			this.decriptionLabel.TabIndex = 2;
			this.decriptionLabel.Text = "&توضیحات";
			// 
			// fullNameTextBox
			// 
			this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fullNameTextBox.Location = new System.Drawing.Point(6, 20);
			this.fullNameTextBox.MaxLength = 50;
			this.fullNameTextBox.Name = "fullNameTextBox";
			this.fullNameTextBox.Size = new System.Drawing.Size(248, 21);
			this.fullNameTextBox.TabIndex = 1;
			// 
			// fullNameLabel
			// 
			this.fullNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.fullNameLabel.AutoSize = true;
			this.fullNameLabel.Location = new System.Drawing.Point(271, 23);
			this.fullNameLabel.Name = "fullNameLabel";
			this.fullNameLabel.Size = new System.Drawing.Size(65, 13);
			this.fullNameLabel.TabIndex = 0;
			this.fullNameLabel.Text = "&نام خانوادگی";
			// 
			// userImagePictureBox
			// 
			this.userImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.userImagePictureBox.Location = new System.Drawing.Point(6, 20);
			this.userImagePictureBox.Name = "userImagePictureBox";
			this.userImagePictureBox.Size = new System.Drawing.Size(137, 150);
			this.userImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.userImagePictureBox.TabIndex = 1;
			this.userImagePictureBox.TabStop = false;
			// 
			// informationUserGoupBox
			// 
			this.informationUserGoupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.informationUserGoupBox.Controls.Add(this.statususerCheckBox);
			this.informationUserGoupBox.Controls.Add(this.IDTextBox);
			this.informationUserGoupBox.Controls.Add(this.IDLabel);
			this.informationUserGoupBox.Controls.Add(this.changePasswordLinkLabel);
			this.informationUserGoupBox.Controls.Add(this.passwordTextBox);
			this.informationUserGoupBox.Controls.Add(this.usernameTextBox);
			this.informationUserGoupBox.Controls.Add(this.passworLabel);
			this.informationUserGoupBox.Controls.Add(this.usernameLabel);
			this.informationUserGoupBox.Location = new System.Drawing.Point(151, 20);
			this.informationUserGoupBox.Name = "informationUserGoupBox";
			this.informationUserGoupBox.Size = new System.Drawing.Size(342, 150);
			this.informationUserGoupBox.TabIndex = 0;
			this.informationUserGoupBox.TabStop = false;
			this.informationUserGoupBox.Text = "مشخصات کاربر";
			// 
			// statususerCheckBox
			// 
			this.statususerCheckBox.AutoSize = true;
			this.statususerCheckBox.Enabled = false;
			this.statususerCheckBox.Location = new System.Drawing.Point(172, 101);
			this.statususerCheckBox.Name = "statususerCheckBox";
			this.statususerCheckBox.Size = new System.Drawing.Size(83, 17);
			this.statususerCheckBox.TabIndex = 8;
			this.statususerCheckBox.Text = "وضعیت کاربر";
			this.statususerCheckBox.UseVisualStyleBackColor = true;
			// 
			// IDTextBox
			// 
			this.IDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.IDTextBox.Enabled = false;
			this.IDTextBox.Location = new System.Drawing.Point(6, 20);
			this.IDTextBox.MaxLength = 20;
			this.IDTextBox.Name = "IDTextBox";
			this.IDTextBox.Size = new System.Drawing.Size(249, 21);
			this.IDTextBox.TabIndex = 7;
			// 
			// IDLabel
			// 
			this.IDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.IDLabel.AutoSize = true;
			this.IDLabel.Location = new System.Drawing.Point(269, 23);
			this.IDLabel.Name = "IDLabel";
			this.IDLabel.Size = new System.Drawing.Size(67, 13);
			this.IDLabel.TabIndex = 6;
			this.IDLabel.Text = "کد شناسایی";
			// 
			// changePasswordLinkLabel
			// 
			this.changePasswordLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.changePasswordLinkLabel.AutoSize = true;
			this.changePasswordLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.changePasswordLinkLabel.Location = new System.Drawing.Point(6, 102);
			this.changePasswordLinkLabel.Name = "changePasswordLinkLabel";
			this.changePasswordLinkLabel.Size = new System.Drawing.Size(64, 13);
			this.changePasswordLinkLabel.TabIndex = 4;
			this.changePasswordLinkLabel.TabStop = true;
			this.changePasswordLinkLabel.Text = "تغییر گذرواژه";
			this.changePasswordLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChangePasswordLinkLabel_LinkClicked);
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordTextBox.Enabled = false;
			this.passwordTextBox.Location = new System.Drawing.Point(6, 74);
			this.passwordTextBox.MaxLength = 40;
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(249, 21);
			this.passwordTextBox.TabIndex = 3;
			this.passwordTextBox.UseSystemPasswordChar = true;
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.usernameTextBox.Enabled = false;
			this.usernameTextBox.Location = new System.Drawing.Point(6, 47);
			this.usernameTextBox.MaxLength = 20;
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(249, 21);
			this.usernameTextBox.TabIndex = 1;
			// 
			// passworLabel
			// 
			this.passworLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.passworLabel.AutoSize = true;
			this.passworLabel.Location = new System.Drawing.Point(294, 77);
			this.passworLabel.Name = "passworLabel";
			this.passworLabel.Size = new System.Drawing.Size(42, 13);
			this.passworLabel.TabIndex = 2;
			this.passworLabel.Text = "گذر واژه";
			// 
			// usernameLabel
			// 
			this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.usernameLabel.AutoSize = true;
			this.usernameLabel.Location = new System.Drawing.Point(261, 50);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(75, 13);
			this.usernameLabel.TabIndex = 0;
			this.usernameLabel.Text = "شناسه کاربری";
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcomToolStripStatusLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 439);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(524, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// welcomToolStripStatusLabel
			// 
			this.welcomToolStripStatusLabel.Name = "welcomToolStripStatusLabel";
			this.welcomToolStripStatusLabel.Size = new System.Drawing.Size(32, 17);
			this.welcomToolStripStatusLabel.Text = "-----";
			// 
			// UpdateProfileForm
			// 
			this.AcceptButton = this.updateButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.resetButton;
			this.ClientSize = new System.Drawing.Size(524, 461);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.informationAccountGroupBox);
			this.MaximumSize = new System.Drawing.Size(800, 600);
			this.MinimumSize = new System.Drawing.Size(540, 500);
			this.Name = "UpdateProfileForm";
			this.Text = "ویرایش مشخصات";
			this.Load += new System.EventHandler(this.UpdateProfileForm_Load);
			this.informationAccountGroupBox.ResumeLayout(false);
			this.informationAccountGroupBox.PerformLayout();
			this.appliedIinformationGroupBox.ResumeLayout(false);
			this.appliedIinformationGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.userImagePictureBox)).EndInit();
			this.informationUserGoupBox.ResumeLayout(false);
			this.informationUserGoupBox.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Dtx.Windows.Forms.GroupBox informationAccountGroupBox;
		private Dtx.Windows.Forms.GroupBox informationUserGoupBox;
		private Dtx.Windows.Forms.Label passworLabel;
		private Dtx.Windows.Forms.Label usernameLabel;
		private Dtx.Windows.Forms.linkLabel pictureChangeLinkLabel;
		private Dtx.Windows.Forms.GroupBox appliedIinformationGroupBox;
		private Dtx.Windows.Forms.Label decriptionLabel;
		private Dtx.Windows.Forms.Label fullNameLabel;
		private Dtx.Windows.Forms.linkLabel changePasswordLinkLabel;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private Dtx.Windows.Forms.Button mainFormButton;
		private Dtx.Windows.Forms.Button resetButton;
		private Dtx.Windows.Forms.Button updateButton;
		private Dtx.Windows.Forms.Button exitButton;
		public Dtx.Windows.Forms.TextBox passwordTextBox;
		public Dtx.Windows.Forms.TextBox usernameTextBox;
		public Dtx.Windows.Forms.TextBox descriptionTextBox;
		public Dtx.Windows.Forms.TextBox fullNameTextBox;
		public Dtx.Windows.Forms.PictureBox userImagePictureBox;
		public Dtx.Windows.Forms.TextBox IDTextBox;
		private Dtx.Windows.Forms.Label IDLabel;
		private Dtx.Windows.Forms.CheckBox statususerCheckBox;
		private Dtx.Windows.Forms.StatusStrip statusStrip1;
		private Dtx.Windows.Forms.ToolStripStatusLabel welcomToolStripStatusLabel;
	}
}