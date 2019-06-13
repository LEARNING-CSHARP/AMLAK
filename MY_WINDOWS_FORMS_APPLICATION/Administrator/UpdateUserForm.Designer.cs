namespace MY_WINDOWS_FORMS_APPLICATION.Administrator
{
	partial class UpdateUserForm
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
			this.fullNameLabel = new Dtx.Windows.Forms.Label();
			this.descriptionLabel = new Dtx.Windows.Forms.Label();
			this.fullNameTextBox = new Dtx.Windows.Forms.TextBox();
			this.descriptionTextBox = new Dtx.Windows.Forms.TextBox();
			this.isActiveCheckBox = new Dtx.Windows.Forms.CheckBox();
			this.isAdministratorCheckBox = new Dtx.Windows.Forms.CheckBox();
			this.saveButton = new Dtx.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// fullNameLabel
			// 
			this.fullNameLabel.AutoSize = true;
			this.fullNameLabel.Location = new System.Drawing.Point(12, 15);
			this.fullNameLabel.Name = "fullNameLabel";
			this.fullNameLabel.Size = new System.Drawing.Size(89, 13);
			this.fullNameLabel.TabIndex = 0;
			this.fullNameLabel.Text = "&نام و نام خانوادگی";
			// 
			// descriptionLabel
			// 
			this.descriptionLabel.AutoSize = true;
			this.descriptionLabel.Location = new System.Drawing.Point(12, 42);
			this.descriptionLabel.Name = "descriptionLabel";
			this.descriptionLabel.Size = new System.Drawing.Size(47, 13);
			this.descriptionLabel.TabIndex = 2;
			this.descriptionLabel.Text = "&توضیحات";
			// 
			// fullNameTextBox
			// 
			this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fullNameTextBox.Location = new System.Drawing.Point(107, 12);
			this.fullNameTextBox.Name = "fullNameTextBox";
			this.fullNameTextBox.Size = new System.Drawing.Size(265, 21);
			this.fullNameTextBox.TabIndex = 1;
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.descriptionTextBox.Location = new System.Drawing.Point(107, 39);
			this.descriptionTextBox.Multiline = true;
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.descriptionTextBox.Size = new System.Drawing.Size(265, 55);
			this.descriptionTextBox.TabIndex = 3;
			// 
			// isActiveCheckBox
			// 
			this.isActiveCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.isActiveCheckBox.AutoSize = true;
			this.isActiveCheckBox.Location = new System.Drawing.Point(107, 100);
			this.isActiveCheckBox.Name = "isActiveCheckBox";
			this.isActiveCheckBox.Size = new System.Drawing.Size(47, 17);
			this.isActiveCheckBox.TabIndex = 4;
			this.isActiveCheckBox.Text = "&فعال";
			this.isActiveCheckBox.UseVisualStyleBackColor = true;
			// 
			// isAdministratorCheckBox
			// 
			this.isAdministratorCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.isAdministratorCheckBox.AutoSize = true;
			this.isAdministratorCheckBox.Location = new System.Drawing.Point(107, 123);
			this.isAdministratorCheckBox.Name = "isAdministratorCheckBox";
			this.isAdministratorCheckBox.Size = new System.Drawing.Size(59, 17);
			this.isAdministratorCheckBox.TabIndex = 5;
			this.isAdministratorCheckBox.Text = "&مدیریت";
			this.isAdministratorCheckBox.UseVisualStyleBackColor = true;
			// 
			// saveButton
			// 
			this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.saveButton.Location = new System.Drawing.Point(107, 146);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 6;
			this.saveButton.Text = "&ذخیره";
			this.saveButton.UseVisualStyleBackColor = false;
			this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// UpdateUserForm
			// 
			this.AcceptButton = this.saveButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 176);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.isAdministratorCheckBox);
			this.Controls.Add(this.isActiveCheckBox);
			this.Controls.Add(this.descriptionTextBox);
			this.Controls.Add(this.fullNameTextBox);
			this.Controls.Add(this.descriptionLabel);
			this.Controls.Add(this.fullNameLabel);
			this.MaximumSize = new System.Drawing.Size(800, 400);
			this.MinimumSize = new System.Drawing.Size(400, 215);
			this.Name = "UpdateUserForm";
			this.Text = "ویرایش اطلاعات کاربر";
			this.Load += new System.EventHandler(this.UpdateUserForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Dtx.Windows.Forms.Label fullNameLabel;
		private Dtx.Windows.Forms.Label descriptionLabel;
		private Dtx.Windows.Forms.TextBox fullNameTextBox;
		private Dtx.Windows.Forms.TextBox descriptionTextBox;
		private Dtx.Windows.Forms.CheckBox isActiveCheckBox;
		private Dtx.Windows.Forms.CheckBox isAdministratorCheckBox;
		private Dtx.Windows.Forms.Button saveButton;
	}
}