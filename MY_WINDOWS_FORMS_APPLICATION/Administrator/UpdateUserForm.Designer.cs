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
			this.label1 = new Dtx.Windows.Forms.Label();
			this.label2 = new Dtx.Windows.Forms.Label();
			this.fullNameTextBox = new Dtx.Windows.Forms.TextBox();
			this.descriptionTextBox = new Dtx.Windows.Forms.TextBox();
			this.isActiveCheckBox = new Dtx.Windows.Forms.CheckBox();
			this.isAdministratorCheckBox = new Dtx.Windows.Forms.CheckBox();
			this.saveButton = new Dtx.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "label2";
			// 
			// fullNameTextBox
			// 
			this.fullNameTextBox.Location = new System.Drawing.Point(133, 12);
			this.fullNameTextBox.Name = "fullNameTextBox";
			this.fullNameTextBox.Size = new System.Drawing.Size(233, 21);
			this.fullNameTextBox.TabIndex = 2;
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.Location = new System.Drawing.Point(133, 39);
			this.descriptionTextBox.Multiline = true;
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.descriptionTextBox.Size = new System.Drawing.Size(233, 20);
			this.descriptionTextBox.TabIndex = 3;
			// 
			// isActiveCheckBox
			// 
			this.isActiveCheckBox.AutoSize = true;
			this.isActiveCheckBox.Location = new System.Drawing.Point(133, 66);
			this.isActiveCheckBox.Name = "isActiveCheckBox";
			this.isActiveCheckBox.Size = new System.Drawing.Size(77, 17);
			this.isActiveCheckBox.TabIndex = 4;
			this.isActiveCheckBox.Text = "checkBox1";
			this.isActiveCheckBox.UseVisualStyleBackColor = true;
			// 
			// isAdministratorCheckBox
			// 
			this.isAdministratorCheckBox.AutoSize = true;
			this.isAdministratorCheckBox.Location = new System.Drawing.Point(133, 89);
			this.isAdministratorCheckBox.Name = "isAdministratorCheckBox";
			this.isAdministratorCheckBox.Size = new System.Drawing.Size(77, 17);
			this.isAdministratorCheckBox.TabIndex = 5;
			this.isAdministratorCheckBox.Text = "checkBox1";
			this.isAdministratorCheckBox.UseVisualStyleBackColor = true;
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(133, 112);
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
			this.ClientSize = new System.Drawing.Size(378, 265);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.isAdministratorCheckBox);
			this.Controls.Add(this.isActiveCheckBox);
			this.Controls.Add(this.descriptionTextBox);
			this.Controls.Add(this.fullNameTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "UpdateUserForm";
			this.Text = "ویرایش اطلاعات کاربر";
			this.Load += new System.EventHandler(this.UpdateUserForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Dtx.Windows.Forms.Label label1;
		private Dtx.Windows.Forms.Label label2;
		private Dtx.Windows.Forms.TextBox fullNameTextBox;
		private Dtx.Windows.Forms.TextBox descriptionTextBox;
		private Dtx.Windows.Forms.CheckBox isActiveCheckBox;
		private Dtx.Windows.Forms.CheckBox isAdministratorCheckBox;
		private Dtx.Windows.Forms.Button saveButton;
	}
}