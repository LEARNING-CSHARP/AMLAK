namespace MY_WINDOWS_FORMS_APPLICATION
{
	partial class ChangePasswordForm
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
			this.ChangepasswordButton = new Dtx.Windows.Forms.Button();
			this.showConfirmPasswordPictureBox = new Dtx.Windows.Forms.PictureBox();
			this.showNewPasswordPictureBox = new Dtx.Windows.Forms.PictureBox();
			this.showOldPasswordPictureBox = new Dtx.Windows.Forms.PictureBox();
			this.confiramPasswordTextBox = new Dtx.Windows.Forms.TextBox();
			this.confirampasswordLabel = new Dtx.Windows.Forms.Label();
			this.newPasswordTextBox = new Dtx.Windows.Forms.TextBox();
			this.newpasswordLlabel = new Dtx.Windows.Forms.Label();
			this.oldPasswordTextBox = new Dtx.Windows.Forms.TextBox();
			this.oldpasswordLabel = new Dtx.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.showConfirmPasswordPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.showNewPasswordPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.showOldPasswordPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// ChangepasswordButton
			// 
			this.ChangepasswordButton.Location = new System.Drawing.Point(106, 93);
			this.ChangepasswordButton.Name = "ChangepasswordButton";
			this.ChangepasswordButton.Size = new System.Drawing.Size(100, 23);
			this.ChangepasswordButton.TabIndex = 6;
			this.ChangepasswordButton.Text = "تغییر &گذرواژه";
			this.ChangepasswordButton.UseVisualStyleBackColor = false;
			this.ChangepasswordButton.Click += new System.EventHandler(this.ChangepasswordButton_Click);
			// 
			// showConfirmPasswordPictureBox
			// 
			this.showConfirmPasswordPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.showConfirmPasswordPictureBox.Image = global::MY_WINDOWS_FORMS_APPLICATION.Properties.Resources.icons8_eye_100;
			this.showConfirmPasswordPictureBox.Location = new System.Drawing.Point(351, 66);
			this.showConfirmPasswordPictureBox.Name = "showConfirmPasswordPictureBox";
			this.showConfirmPasswordPictureBox.Size = new System.Drawing.Size(21, 21);
			this.showConfirmPasswordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.showConfirmPasswordPictureBox.TabIndex = 17;
			this.showConfirmPasswordPictureBox.TabStop = false;
			this.showConfirmPasswordPictureBox.Click += new System.EventHandler(this.ShowconfirmpasswordPictureBox_Click);
			// 
			// showNewPasswordPictureBox
			// 
			this.showNewPasswordPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.showNewPasswordPictureBox.Image = global::MY_WINDOWS_FORMS_APPLICATION.Properties.Resources.icons8_eye_100;
			this.showNewPasswordPictureBox.Location = new System.Drawing.Point(351, 39);
			this.showNewPasswordPictureBox.Name = "showNewPasswordPictureBox";
			this.showNewPasswordPictureBox.Size = new System.Drawing.Size(21, 21);
			this.showNewPasswordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.showNewPasswordPictureBox.TabIndex = 16;
			this.showNewPasswordPictureBox.TabStop = false;
			this.showNewPasswordPictureBox.Click += new System.EventHandler(this.ShownewpasswordPictureBox_Click);
			// 
			// showOldPasswordPictureBox
			// 
			this.showOldPasswordPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.showOldPasswordPictureBox.Image = global::MY_WINDOWS_FORMS_APPLICATION.Properties.Resources.icons8_eye_100;
			this.showOldPasswordPictureBox.Location = new System.Drawing.Point(351, 12);
			this.showOldPasswordPictureBox.Name = "showOldPasswordPictureBox";
			this.showOldPasswordPictureBox.Size = new System.Drawing.Size(21, 21);
			this.showOldPasswordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.showOldPasswordPictureBox.TabIndex = 15;
			this.showOldPasswordPictureBox.TabStop = false;
			this.showOldPasswordPictureBox.Click += new System.EventHandler(this.ShowoldpawwordPictureBox_Click);
			// 
			// confiramPasswordTextBox
			// 
			this.confiramPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.confiramPasswordTextBox.Location = new System.Drawing.Point(106, 66);
			this.confiramPasswordTextBox.MaxLength = 40;
			this.confiramPasswordTextBox.Name = "confiramPasswordTextBox";
			this.confiramPasswordTextBox.Size = new System.Drawing.Size(239, 21);
			this.confiramPasswordTextBox.TabIndex = 5;
			this.confiramPasswordTextBox.UseSystemPasswordChar = true;
			// 
			// confirampasswordLabel
			// 
			this.confirampasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.confirampasswordLabel.AutoSize = true;
			this.confirampasswordLabel.Location = new System.Drawing.Point(12, 66);
			this.confirampasswordLabel.Name = "confirampasswordLabel";
			this.confirampasswordLabel.Size = new System.Drawing.Size(88, 13);
			this.confirampasswordLabel.TabIndex = 4;
			this.confirampasswordLabel.Text = "&تکرار گذرواژه جدید";
			// 
			// newPasswordTextBox
			// 
			this.newPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.newPasswordTextBox.Location = new System.Drawing.Point(106, 39);
			this.newPasswordTextBox.MaxLength = 40;
			this.newPasswordTextBox.Name = "newPasswordTextBox";
			this.newPasswordTextBox.Size = new System.Drawing.Size(239, 21);
			this.newPasswordTextBox.TabIndex = 3;
			this.newPasswordTextBox.UseSystemPasswordChar = true;
			// 
			// newpasswordLlabel
			// 
			this.newpasswordLlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.newpasswordLlabel.AutoSize = true;
			this.newpasswordLlabel.Location = new System.Drawing.Point(12, 39);
			this.newpasswordLlabel.Name = "newpasswordLlabel";
			this.newpasswordLlabel.Size = new System.Drawing.Size(64, 13);
			this.newpasswordLlabel.TabIndex = 2;
			this.newpasswordLlabel.Text = "گذرواژه &جدید";
			// 
			// oldPasswordTextBox
			// 
			this.oldPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.oldPasswordTextBox.Location = new System.Drawing.Point(106, 12);
			this.oldPasswordTextBox.MaxLength = 40;
			this.oldPasswordTextBox.Name = "oldPasswordTextBox";
			this.oldPasswordTextBox.Size = new System.Drawing.Size(239, 21);
			this.oldPasswordTextBox.TabIndex = 1;
			this.oldPasswordTextBox.UseSystemPasswordChar = true;
			// 
			// oldpasswordLabel
			// 
			this.oldpasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.oldpasswordLabel.AutoSize = true;
			this.oldpasswordLabel.Location = new System.Drawing.Point(12, 12);
			this.oldpasswordLabel.Name = "oldpasswordLabel";
			this.oldpasswordLabel.Size = new System.Drawing.Size(64, 13);
			this.oldpasswordLabel.TabIndex = 0;
			this.oldpasswordLabel.Text = "گذرواژه &قدیم";
			// 
			// ChangePasswordForm
			// 
			this.AcceptButton = this.ChangepasswordButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 146);
			this.Controls.Add(this.showConfirmPasswordPictureBox);
			this.Controls.Add(this.showNewPasswordPictureBox);
			this.Controls.Add(this.showOldPasswordPictureBox);
			this.Controls.Add(this.confiramPasswordTextBox);
			this.Controls.Add(this.confirampasswordLabel);
			this.Controls.Add(this.newPasswordTextBox);
			this.Controls.Add(this.newpasswordLlabel);
			this.Controls.Add(this.oldPasswordTextBox);
			this.Controls.Add(this.oldpasswordLabel);
			this.Controls.Add(this.ChangepasswordButton);
			this.MaximumSize = new System.Drawing.Size(800, 190);
			this.MinimumSize = new System.Drawing.Size(400, 185);
			this.Name = "ChangePasswordForm";
			this.Text = "تغییر گذر واژه";
			this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.showConfirmPasswordPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.showNewPasswordPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.showOldPasswordPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Dtx.Windows.Forms.Button ChangepasswordButton;
		private Dtx.Windows.Forms.PictureBox showConfirmPasswordPictureBox;
		private Dtx.Windows.Forms.PictureBox showNewPasswordPictureBox;
		private Dtx.Windows.Forms.PictureBox showOldPasswordPictureBox;
		private Dtx.Windows.Forms.TextBox confiramPasswordTextBox;
		private Dtx.Windows.Forms.Label confirampasswordLabel;
		private Dtx.Windows.Forms.TextBox newPasswordTextBox;
		private Dtx.Windows.Forms.Label newpasswordLlabel;
		private Dtx.Windows.Forms.TextBox oldPasswordTextBox;
		private Dtx.Windows.Forms.Label oldpasswordLabel;
	}
}