namespace MY_WINDOWS_FORMS_APPLICATION
{
	partial class RegisterForm
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
			this.usernameLabel = new Dtx.Windows.Forms.Label();
			this.passwordLabel = new Dtx.Windows.Forms.Label();
			this.fullNameLabel = new Dtx.Windows.Forms.Label();
			this.usernameTextBox = new Dtx.Windows.Forms.TextBox();
			this.passwordTextBox = new Dtx.Windows.Forms.TextBox();
			this.fullNameTextBox = new Dtx.Windows.Forms.TextBox();
			this.registerButton = new Dtx.Windows.Forms.Button();
			this.resetButton = new Dtx.Windows.Forms.Button();
			this.loginButton = new Dtx.Windows.Forms.Button();
			this.exitButton = new Dtx.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// usernameLabel
			// 
			this.usernameLabel.AutoSize = true;
			this.usernameLabel.Location = new System.Drawing.Point(12, 15);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(76, 13);
			this.usernameLabel.TabIndex = 0;
			this.usernameLabel.Text = "&شناسه کاربری";
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(12, 41);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(44, 13);
			this.passwordLabel.TabIndex = 2;
			this.passwordLabel.Text = "&گذرواژه";
			// 
			// fullNameLabel
			// 
			this.fullNameLabel.AutoSize = true;
			this.fullNameLabel.Location = new System.Drawing.Point(12, 67);
			this.fullNameLabel.Name = "fullNameLabel";
			this.fullNameLabel.Size = new System.Drawing.Size(94, 13);
			this.fullNameLabel.TabIndex = 4;
			this.fullNameLabel.Text = "&نام و نام خانوادگی";
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.usernameTextBox.Location = new System.Drawing.Point(112, 12);
			this.usernameTextBox.MaxLength = 20;
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(318, 20);
			this.usernameTextBox.TabIndex = 1;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordTextBox.Location = new System.Drawing.Point(112, 38);
			this.passwordTextBox.MaxLength = 40;
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(318, 20);
			this.passwordTextBox.TabIndex = 3;
			this.passwordTextBox.UseSystemPasswordChar = true;
			// 
			// fullNameTextBox
			// 
			this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fullNameTextBox.Location = new System.Drawing.Point(112, 64);
			this.fullNameTextBox.MaxLength = 50;
			this.fullNameTextBox.Name = "fullNameTextBox";
			this.fullNameTextBox.Size = new System.Drawing.Size(318, 20);
			this.fullNameTextBox.TabIndex = 5;
			// 
			// registerButton
			// 
			this.registerButton.Location = new System.Drawing.Point(112, 90);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(75, 23);
			this.registerButton.TabIndex = 6;
			this.registerButton.Text = "&ثبت‌نام";
			this.registerButton.UseVisualStyleBackColor = true;
			this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
			// 
			// resetButton
			// 
			this.resetButton.Location = new System.Drawing.Point(193, 90);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(75, 23);
			this.resetButton.TabIndex = 7;
			this.resetButton.Text = "&حالت اولیه";
			this.resetButton.UseVisualStyleBackColor = true;
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(274, 90);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(75, 23);
			this.loginButton.TabIndex = 8;
			this.loginButton.Text = "&ورود";
			this.loginButton.UseVisualStyleBackColor = true;
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(355, 90);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 23);
			this.exitButton.TabIndex = 9;
			this.exitButton.Text = "&خروج";
			this.exitButton.UseVisualStyleBackColor = true;
			// 
			// RegisterForm
			// 
			this.AcceptButton = this.registerButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.resetButton;
			this.ClientSize = new System.Drawing.Size(442, 126);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.registerButton);
			this.Controls.Add(this.fullNameTextBox);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.usernameTextBox);
			this.Controls.Add(this.fullNameLabel);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.usernameLabel);
			this.MaximumSize = new System.Drawing.Size(800, 165);
			this.MinimumSize = new System.Drawing.Size(458, 165);
			this.Name = "RegisterForm";
			this.Text = "ثبت‌نام";
			this.Load += new System.EventHandler(this.RegisterForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Dtx.Windows.Forms.Label usernameLabel;
		private Dtx.Windows.Forms.Label passwordLabel;
		private Dtx.Windows.Forms.Label fullNameLabel;
		private Dtx.Windows.Forms.TextBox usernameTextBox;
		private Dtx.Windows.Forms.TextBox passwordTextBox;
		private Dtx.Windows.Forms.TextBox fullNameTextBox;
		private Dtx.Windows.Forms.Button registerButton;
		private Dtx.Windows.Forms.Button resetButton;
		private Dtx.Windows.Forms.Button loginButton;
		private Dtx.Windows.Forms.Button exitButton;
	}
}
