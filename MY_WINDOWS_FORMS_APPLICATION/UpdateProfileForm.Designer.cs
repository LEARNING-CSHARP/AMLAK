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
			this.statusStrip1 = new Dtx.Windows.Forms.StatusStrip();
			this.welcomToolStripStatusLabel = new Dtx.Windows.Forms.ToolStripStatusLabel();
			this.descriptionTextBox = new Dtx.Windows.Forms.TextBox();
			this.decriptionLabel = new Dtx.Windows.Forms.Label();
			this.fullNameTextBox = new Dtx.Windows.Forms.TextBox();
			this.fullNameLabel = new Dtx.Windows.Forms.Label();
			this.updateButton = new Dtx.Windows.Forms.Button();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcomToolStripStatusLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 199);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(334, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// welcomToolStripStatusLabel
			// 
			this.welcomToolStripStatusLabel.Name = "welcomToolStripStatusLabel";
			this.welcomToolStripStatusLabel.Size = new System.Drawing.Size(32, 17);
			this.welcomToolStripStatusLabel.Text = "-----";
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.descriptionTextBox.Location = new System.Drawing.Point(83, 39);
			this.descriptionTextBox.MaxLength = 200;
			this.descriptionTextBox.Multiline = true;
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.descriptionTextBox.Size = new System.Drawing.Size(239, 124);
			this.descriptionTextBox.TabIndex = 10;
			// 
			// decriptionLabel
			// 
			this.decriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.decriptionLabel.AutoSize = true;
			this.decriptionLabel.Location = new System.Drawing.Point(12, 42);
			this.decriptionLabel.Name = "decriptionLabel";
			this.decriptionLabel.Size = new System.Drawing.Size(47, 13);
			this.decriptionLabel.TabIndex = 9;
			this.decriptionLabel.Text = "&توضیحات";
			// 
			// fullNameTextBox
			// 
			this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fullNameTextBox.Location = new System.Drawing.Point(83, 12);
			this.fullNameTextBox.MaxLength = 50;
			this.fullNameTextBox.Name = "fullNameTextBox";
			this.fullNameTextBox.Size = new System.Drawing.Size(239, 21);
			this.fullNameTextBox.TabIndex = 8;
			// 
			// fullNameLabel
			// 
			this.fullNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fullNameLabel.AutoSize = true;
			this.fullNameLabel.Location = new System.Drawing.Point(12, 20);
			this.fullNameLabel.Name = "fullNameLabel";
			this.fullNameLabel.Size = new System.Drawing.Size(65, 13);
			this.fullNameLabel.TabIndex = 7;
			this.fullNameLabel.Text = "&نام خانوادگی";
			// 
			// updateButton
			// 
			this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.updateButton.Location = new System.Drawing.Point(83, 169);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(95, 23);
			this.updateButton.TabIndex = 11;
			this.updateButton.Text = "&بروز رسانی";
			this.updateButton.UseVisualStyleBackColor = false;
			this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
			// 
			// UpdateProfileForm
			// 
			this.AcceptButton = this.updateButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 221);
			this.Controls.Add(this.descriptionTextBox);
			this.Controls.Add(this.decriptionLabel);
			this.Controls.Add(this.fullNameTextBox);
			this.Controls.Add(this.fullNameLabel);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.statusStrip1);
			this.MaximumSize = new System.Drawing.Size(800, 600);
			this.MinimumSize = new System.Drawing.Size(350, 260);
			this.Name = "UpdateProfileForm";
			this.Text = "ویرایش مشخصات";
			this.Load += new System.EventHandler(this.UpdateProfileForm_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private Dtx.Windows.Forms.StatusStrip statusStrip1;
		private Dtx.Windows.Forms.ToolStripStatusLabel welcomToolStripStatusLabel;
		public Dtx.Windows.Forms.TextBox descriptionTextBox;
		private Dtx.Windows.Forms.Label decriptionLabel;
		public Dtx.Windows.Forms.TextBox fullNameTextBox;
		private Dtx.Windows.Forms.Label fullNameLabel;
		private Dtx.Windows.Forms.Button updateButton;
	}
}