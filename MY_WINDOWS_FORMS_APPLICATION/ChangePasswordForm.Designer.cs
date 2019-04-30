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
			this.showconfirmpasswordPictureBox = new Dtx.Windows.Forms.PictureBox();
			this.shownewpasswordPictureBox = new Dtx.Windows.Forms.PictureBox();
			this.showoldpawwordPictureBox = new Dtx.Windows.Forms.PictureBox();
			this.confirampasswordTextBox = new Dtx.Windows.Forms.TextBox();
			this.confirampasswordLabel = new Dtx.Windows.Forms.Label();
			this.newpasswordTextBox = new Dtx.Windows.Forms.TextBox();
			this.newpasswordLlabel = new Dtx.Windows.Forms.Label();
			this.oldpasswordTextBox = new Dtx.Windows.Forms.TextBox();
			this.oldpasswordLabel = new Dtx.Windows.Forms.Label();
			this.statusStrip1 = new Dtx.Windows.Forms.StatusStrip();
			this.welcomToolStripStatusLabel = new Dtx.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.showconfirmpasswordPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.shownewpasswordPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.showoldpawwordPictureBox)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ChangepasswordButton
			// 
			this.ChangepasswordButton.Location = new System.Drawing.Point(106, 93);
			this.ChangepasswordButton.Name = "ChangepasswordButton";
			this.ChangepasswordButton.Size = new System.Drawing.Size(100, 23);
			this.ChangepasswordButton.TabIndex = 1;
			this.ChangepasswordButton.Text = "تغییر &گذرواژه";
			this.ChangepasswordButton.UseVisualStyleBackColor = false;
			this.ChangepasswordButton.Click += new System.EventHandler(this.ChangepasswordButton_Click);
			// 
			// showconfirmpasswordPictureBox
			// 
			this.showconfirmpasswordPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.showconfirmpasswordPictureBox.Image = global::MY_WINDOWS_FORMS_APPLICATION.Properties.Resources.icons8_eye_100;
			this.showconfirmpasswordPictureBox.Location = new System.Drawing.Point(351, 66);
			this.showconfirmpasswordPictureBox.Name = "showconfirmpasswordPictureBox";
			this.showconfirmpasswordPictureBox.Size = new System.Drawing.Size(21, 21);
			this.showconfirmpasswordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.showconfirmpasswordPictureBox.TabIndex = 17;
			this.showconfirmpasswordPictureBox.TabStop = false;
			this.showconfirmpasswordPictureBox.Click += new System.EventHandler(this.ShowconfirmpasswordPictureBox_Click);
			// 
			// shownewpasswordPictureBox
			// 
			this.shownewpasswordPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.shownewpasswordPictureBox.Image = global::MY_WINDOWS_FORMS_APPLICATION.Properties.Resources.icons8_eye_100;
			this.shownewpasswordPictureBox.Location = new System.Drawing.Point(351, 39);
			this.shownewpasswordPictureBox.Name = "shownewpasswordPictureBox";
			this.shownewpasswordPictureBox.Size = new System.Drawing.Size(21, 21);
			this.shownewpasswordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.shownewpasswordPictureBox.TabIndex = 16;
			this.shownewpasswordPictureBox.TabStop = false;
			this.shownewpasswordPictureBox.Click += new System.EventHandler(this.ShownewpasswordPictureBox_Click);
			// 
			// showoldpawwordPictureBox
			// 
			this.showoldpawwordPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.showoldpawwordPictureBox.Image = global::MY_WINDOWS_FORMS_APPLICATION.Properties.Resources.icons8_eye_100;
			this.showoldpawwordPictureBox.Location = new System.Drawing.Point(351, 12);
			this.showoldpawwordPictureBox.Name = "showoldpawwordPictureBox";
			this.showoldpawwordPictureBox.Size = new System.Drawing.Size(21, 21);
			this.showoldpawwordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.showoldpawwordPictureBox.TabIndex = 15;
			this.showoldpawwordPictureBox.TabStop = false;
			this.showoldpawwordPictureBox.Click += new System.EventHandler(this.ShowoldpawwordPictureBox_Click);
			// 
			// confirampasswordTextBox
			// 
			this.confirampasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.confirampasswordTextBox.Location = new System.Drawing.Point(106, 66);
			this.confirampasswordTextBox.MaxLength = 40;
			this.confirampasswordTextBox.Name = "confirampasswordTextBox";
			this.confirampasswordTextBox.Size = new System.Drawing.Size(239, 21);
			this.confirampasswordTextBox.TabIndex = 14;
			this.confirampasswordTextBox.UseSystemPasswordChar = true;
			// 
			// confirampasswordLabel
			// 
			this.confirampasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.confirampasswordLabel.AutoSize = true;
			this.confirampasswordLabel.Location = new System.Drawing.Point(12, 66);
			this.confirampasswordLabel.Name = "confirampasswordLabel";
			this.confirampasswordLabel.Size = new System.Drawing.Size(88, 13);
			this.confirampasswordLabel.TabIndex = 13;
			this.confirampasswordLabel.Text = "&تکرار گذرواژه جدید";
			// 
			// newpasswordTextBox
			// 
			this.newpasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.newpasswordTextBox.Location = new System.Drawing.Point(106, 39);
			this.newpasswordTextBox.MaxLength = 40;
			this.newpasswordTextBox.Name = "newpasswordTextBox";
			this.newpasswordTextBox.Size = new System.Drawing.Size(239, 21);
			this.newpasswordTextBox.TabIndex = 12;
			this.newpasswordTextBox.UseSystemPasswordChar = true;
			// 
			// newpasswordLlabel
			// 
			this.newpasswordLlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.newpasswordLlabel.AutoSize = true;
			this.newpasswordLlabel.Location = new System.Drawing.Point(12, 39);
			this.newpasswordLlabel.Name = "newpasswordLlabel";
			this.newpasswordLlabel.Size = new System.Drawing.Size(64, 13);
			this.newpasswordLlabel.TabIndex = 11;
			this.newpasswordLlabel.Text = "گذرواژه &جدید";
			// 
			// oldpasswordTextBox
			// 
			this.oldpasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.oldpasswordTextBox.Location = new System.Drawing.Point(106, 12);
			this.oldpasswordTextBox.MaxLength = 40;
			this.oldpasswordTextBox.Name = "oldpasswordTextBox";
			this.oldpasswordTextBox.Size = new System.Drawing.Size(239, 21);
			this.oldpasswordTextBox.TabIndex = 10;
			this.oldpasswordTextBox.UseSystemPasswordChar = true;
			// 
			// oldpasswordLabel
			// 
			this.oldpasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.oldpasswordLabel.AutoSize = true;
			this.oldpasswordLabel.Location = new System.Drawing.Point(12, 12);
			this.oldpasswordLabel.Name = "oldpasswordLabel";
			this.oldpasswordLabel.Size = new System.Drawing.Size(64, 13);
			this.oldpasswordLabel.TabIndex = 9;
			this.oldpasswordLabel.Text = "گذرواژه &قدیم";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcomToolStripStatusLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 124);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(384, 22);
			this.statusStrip1.TabIndex = 18;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// welcomToolStripStatusLabel
			// 
			this.welcomToolStripStatusLabel.BackColor = System.Drawing.SystemColors.Control;
			this.welcomToolStripStatusLabel.Name = "welcomToolStripStatusLabel";
			this.welcomToolStripStatusLabel.Size = new System.Drawing.Size(32, 17);
			this.welcomToolStripStatusLabel.Text = "-----";
			// 
			// ChangePasswordForm
			// 
			this.AcceptButton = this.ChangepasswordButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 146);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.showconfirmpasswordPictureBox);
			this.Controls.Add(this.shownewpasswordPictureBox);
			this.Controls.Add(this.showoldpawwordPictureBox);
			this.Controls.Add(this.confirampasswordTextBox);
			this.Controls.Add(this.confirampasswordLabel);
			this.Controls.Add(this.newpasswordTextBox);
			this.Controls.Add(this.newpasswordLlabel);
			this.Controls.Add(this.oldpasswordTextBox);
			this.Controls.Add(this.oldpasswordLabel);
			this.Controls.Add(this.ChangepasswordButton);
			this.MaximumSize = new System.Drawing.Size(800, 190);
			this.MinimumSize = new System.Drawing.Size(400, 185);
			this.Name = "ChangePasswordForm";
			this.Text = "تغییر گذر واژه";
			this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.showconfirmpasswordPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.shownewpasswordPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.showoldpawwordPictureBox)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Dtx.Windows.Forms.Button ChangepasswordButton;
		private Dtx.Windows.Forms.PictureBox showconfirmpasswordPictureBox;
		private Dtx.Windows.Forms.PictureBox shownewpasswordPictureBox;
		private Dtx.Windows.Forms.PictureBox showoldpawwordPictureBox;
		private Dtx.Windows.Forms.TextBox confirampasswordTextBox;
		private Dtx.Windows.Forms.Label confirampasswordLabel;
		private Dtx.Windows.Forms.TextBox newpasswordTextBox;
		private Dtx.Windows.Forms.Label newpasswordLlabel;
		private Dtx.Windows.Forms.TextBox oldpasswordTextBox;
		private Dtx.Windows.Forms.Label oldpasswordLabel;
		private Dtx.Windows.Forms.StatusStrip statusStrip1;
		private Dtx.Windows.Forms.ToolStripStatusLabel welcomToolStripStatusLabel;
	}
}