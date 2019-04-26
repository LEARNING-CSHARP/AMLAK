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
			this.changepasswordGroupBox = new Dtx.Windows.Forms.GroupBox();
			this.showconfirmpasswordPictureBox = new Dtx.Windows.Forms.PictureBox();
			this.shownewpasswordPictureBox = new Dtx.Windows.Forms.PictureBox();
			this.showoldpawwordPictureBox = new Dtx.Windows.Forms.PictureBox();
			this.confirampasswordTextBox = new Dtx.Windows.Forms.TextBox();
			this.confirampasswordLabel = new Dtx.Windows.Forms.Label();
			this.newpasswordTextBox = new Dtx.Windows.Forms.TextBox();
			this.newpasswordLlabel = new Dtx.Windows.Forms.Label();
			this.oldpasswordTextBox = new Dtx.Windows.Forms.TextBox();
			this.oldpasswordLabel = new Dtx.Windows.Forms.Label();
			this.ChangepasswordButton = new Dtx.Windows.Forms.Button();
			this.resetButton = new Dtx.Windows.Forms.Button();
			this.mainformButton = new Dtx.Windows.Forms.Button();
			this.exitButton = new Dtx.Windows.Forms.Button();
			this.changepasswordGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.showconfirmpasswordPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.shownewpasswordPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.showoldpawwordPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// changepasswordGroupBox
			// 
			this.changepasswordGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.changepasswordGroupBox.Controls.Add(this.showconfirmpasswordPictureBox);
			this.changepasswordGroupBox.Controls.Add(this.shownewpasswordPictureBox);
			this.changepasswordGroupBox.Controls.Add(this.showoldpawwordPictureBox);
			this.changepasswordGroupBox.Controls.Add(this.confirampasswordTextBox);
			this.changepasswordGroupBox.Controls.Add(this.confirampasswordLabel);
			this.changepasswordGroupBox.Controls.Add(this.newpasswordTextBox);
			this.changepasswordGroupBox.Controls.Add(this.newpasswordLlabel);
			this.changepasswordGroupBox.Controls.Add(this.oldpasswordTextBox);
			this.changepasswordGroupBox.Controls.Add(this.oldpasswordLabel);
			this.changepasswordGroupBox.Location = new System.Drawing.Point(15, 12);
			this.changepasswordGroupBox.Name = "changepasswordGroupBox";
			this.changepasswordGroupBox.Size = new System.Drawing.Size(417, 104);
			this.changepasswordGroupBox.TabIndex = 0;
			this.changepasswordGroupBox.TabStop = false;
			// 
			// showconfirmpasswordPictureBox
			// 
			this.showconfirmpasswordPictureBox.Image = global::MY_WINDOWS_FORMS_APPLICATION.Properties.Resources.icons8_eye_100;
			this.showconfirmpasswordPictureBox.Location = new System.Drawing.Point(6, 74);
			this.showconfirmpasswordPictureBox.Name = "showconfirmpasswordPictureBox";
			this.showconfirmpasswordPictureBox.Size = new System.Drawing.Size(21, 21);
			this.showconfirmpasswordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.showconfirmpasswordPictureBox.TabIndex = 8;
			this.showconfirmpasswordPictureBox.TabStop = false;
			this.showconfirmpasswordPictureBox.Click += new System.EventHandler(this.ShowconfirmpasswordPictureBox_Click);
			// 
			// shownewpasswordPictureBox
			// 
			this.shownewpasswordPictureBox.Image = global::MY_WINDOWS_FORMS_APPLICATION.Properties.Resources.icons8_eye_100;
			this.shownewpasswordPictureBox.Location = new System.Drawing.Point(6, 47);
			this.shownewpasswordPictureBox.Name = "shownewpasswordPictureBox";
			this.shownewpasswordPictureBox.Size = new System.Drawing.Size(21, 21);
			this.shownewpasswordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.shownewpasswordPictureBox.TabIndex = 7;
			this.shownewpasswordPictureBox.TabStop = false;
			this.shownewpasswordPictureBox.Click += new System.EventHandler(this.ShownewpasswordPictureBox_Click);
			// 
			// showoldpawwordPictureBox
			// 
			this.showoldpawwordPictureBox.Image = global::MY_WINDOWS_FORMS_APPLICATION.Properties.Resources.icons8_eye_100;
			this.showoldpawwordPictureBox.Location = new System.Drawing.Point(6, 20);
			this.showoldpawwordPictureBox.Name = "showoldpawwordPictureBox";
			this.showoldpawwordPictureBox.Size = new System.Drawing.Size(21, 21);
			this.showoldpawwordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.showoldpawwordPictureBox.TabIndex = 6;
			this.showoldpawwordPictureBox.TabStop = false;
			this.showoldpawwordPictureBox.Click += new System.EventHandler(this.ShowoldpawwordPictureBox_Click);
			// 
			// confirampasswordTextBox
			// 
			this.confirampasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.confirampasswordTextBox.Location = new System.Drawing.Point(33, 74);
			this.confirampasswordTextBox.MaxLength = 40;
			this.confirampasswordTextBox.Name = "confirampasswordTextBox";
			this.confirampasswordTextBox.Size = new System.Drawing.Size(308, 21);
			this.confirampasswordTextBox.TabIndex = 5;
			this.confirampasswordTextBox.UseSystemPasswordChar = true;
			// 
			// confirampasswordLabel
			// 
			this.confirampasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.confirampasswordLabel.AutoSize = true;
			this.confirampasswordLabel.Location = new System.Drawing.Point(350, 77);
			this.confirampasswordLabel.Name = "confirampasswordLabel";
			this.confirampasswordLabel.Size = new System.Drawing.Size(61, 13);
			this.confirampasswordLabel.TabIndex = 4;
			this.confirampasswordLabel.Text = "&تایید گذرواژه";
			// 
			// newpasswordTextBox
			// 
			this.newpasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.newpasswordTextBox.Location = new System.Drawing.Point(33, 47);
			this.newpasswordTextBox.MaxLength = 40;
			this.newpasswordTextBox.Name = "newpasswordTextBox";
			this.newpasswordTextBox.Size = new System.Drawing.Size(308, 21);
			this.newpasswordTextBox.TabIndex = 3;
			this.newpasswordTextBox.UseSystemPasswordChar = true;
			// 
			// newpasswordLlabel
			// 
			this.newpasswordLlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.newpasswordLlabel.AutoSize = true;
			this.newpasswordLlabel.Location = new System.Drawing.Point(347, 50);
			this.newpasswordLlabel.Name = "newpasswordLlabel";
			this.newpasswordLlabel.Size = new System.Drawing.Size(64, 13);
			this.newpasswordLlabel.TabIndex = 2;
			this.newpasswordLlabel.Text = "گذرواژه &جدید";
			// 
			// oldpasswordTextBox
			// 
			this.oldpasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.oldpasswordTextBox.Location = new System.Drawing.Point(33, 20);
			this.oldpasswordTextBox.MaxLength = 40;
			this.oldpasswordTextBox.Name = "oldpasswordTextBox";
			this.oldpasswordTextBox.Size = new System.Drawing.Size(308, 21);
			this.oldpasswordTextBox.TabIndex = 1;
			this.oldpasswordTextBox.UseSystemPasswordChar = true;
			// 
			// oldpasswordLabel
			// 
			this.oldpasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.oldpasswordLabel.AutoSize = true;
			this.oldpasswordLabel.Location = new System.Drawing.Point(347, 23);
			this.oldpasswordLabel.Name = "oldpasswordLabel";
			this.oldpasswordLabel.Size = new System.Drawing.Size(64, 13);
			this.oldpasswordLabel.TabIndex = 0;
			this.oldpasswordLabel.Text = "گذرواژه &قدیم";
			// 
			// ChangepasswordButton
			// 
			this.ChangepasswordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ChangepasswordButton.Location = new System.Drawing.Point(15, 122);
			this.ChangepasswordButton.Name = "ChangepasswordButton";
			this.ChangepasswordButton.Size = new System.Drawing.Size(100, 23);
			this.ChangepasswordButton.TabIndex = 1;
			this.ChangepasswordButton.Text = "تغییر &گذرواژه";
			this.ChangepasswordButton.UseVisualStyleBackColor = false;
			this.ChangepasswordButton.Click += new System.EventHandler(this.ChangepasswordButton_Click);
			// 
			// resetButton
			// 
			this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.resetButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.resetButton.Location = new System.Drawing.Point(88, 89);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(133, 56);
			this.resetButton.TabIndex = 2;
			this.resetButton.Text = "&حالت اولیه";
			this.resetButton.UseVisualStyleBackColor = false;
			this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// mainformButton
			// 
			this.mainformButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mainformButton.Location = new System.Drawing.Point(228, 122);
			this.mainformButton.Name = "mainformButton";
			this.mainformButton.Size = new System.Drawing.Size(100, 23);
			this.mainformButton.TabIndex = 3;
			this.mainformButton.Text = "&صفحه اصلی";
			this.mainformButton.UseVisualStyleBackColor = false;
			this.mainformButton.Click += new System.EventHandler(this.MainformButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.exitButton.Location = new System.Drawing.Point(334, 122);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(100, 23);
			this.exitButton.TabIndex = 4;
			this.exitButton.Text = "&خروج";
			this.exitButton.UseVisualStyleBackColor = false;
			this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// ChangePasswordForm
			// 
			this.AcceptButton = this.ChangepasswordButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.resetButton;
			this.ClientSize = new System.Drawing.Size(444, 151);
			this.Controls.Add(this.ChangepasswordButton);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.mainformButton);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.changepasswordGroupBox);
			this.MaximumSize = new System.Drawing.Size(800, 190);
			this.MinimumSize = new System.Drawing.Size(460, 190);
			this.Name = "ChangePasswordForm";
			this.Text = "تغییر گذر واژه";
			this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
			this.changepasswordGroupBox.ResumeLayout(false);
			this.changepasswordGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.showconfirmpasswordPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.shownewpasswordPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.showoldpawwordPictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Dtx.Windows.Forms.GroupBox changepasswordGroupBox;
		private Dtx.Windows.Forms.TextBox confirampasswordTextBox;
		private Dtx.Windows.Forms.Label confirampasswordLabel;
		private Dtx.Windows.Forms.TextBox newpasswordTextBox;
		private Dtx.Windows.Forms.Label newpasswordLlabel;
		private Dtx.Windows.Forms.TextBox oldpasswordTextBox;
		private Dtx.Windows.Forms.Label oldpasswordLabel;
		private Dtx.Windows.Forms.PictureBox showoldpawwordPictureBox;
		private Dtx.Windows.Forms.Button ChangepasswordButton;
		private Dtx.Windows.Forms.Button resetButton;
		private Dtx.Windows.Forms.Button mainformButton;
		private Dtx.Windows.Forms.Button exitButton;
		private Dtx.Windows.Forms.PictureBox showconfirmpasswordPictureBox;
		private Dtx.Windows.Forms.PictureBox shownewpasswordPictureBox;
	}
}