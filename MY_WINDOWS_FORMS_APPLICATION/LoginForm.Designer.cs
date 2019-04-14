namespace MY_WINDOWS_FORMS_APPLICATION
{
    partial class LoginForm
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
			this.usernameTextBox = new Dtx.Windows.Forms.TextBox();
			this.passwordTextBox = new Dtx.Windows.Forms.TextBox();
			this.usernameLabel = new Dtx.Windows.Forms.Label();
			this.passwordLabel = new Dtx.Windows.Forms.Label();
			this.exitButton = new Dtx.Windows.Forms.Button();
			this.loginButton = new Dtx.Windows.Forms.Button();
			this.registerButton = new Dtx.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.usernameTextBox.Location = new System.Drawing.Point(97, 12);
			this.usernameTextBox.MaxLength = 20;
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(236, 21);
			this.usernameTextBox.TabIndex = 0;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordTextBox.Location = new System.Drawing.Point(97, 38);
			this.passwordTextBox.MaxLength = 40;
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(236, 21);
			this.passwordTextBox.TabIndex = 2;
			this.passwordTextBox.UseSystemPasswordChar = true;
			// 
			// usernameLabel
			// 
			this.usernameLabel.AutoSize = true;
			this.usernameLabel.Location = new System.Drawing.Point(12, 15);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(79, 13);
			this.usernameLabel.TabIndex = 1;
			this.usernameLabel.Text = "&شناسه کاربری:";
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(12, 41);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(43, 13);
			this.passwordLabel.TabIndex = 3;
			this.passwordLabel.Text = "&گذرواژه:";
			// 
			// exitButton
			// 
			this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.exitButton.Location = new System.Drawing.Point(259, 64);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 23);
			this.exitButton.TabIndex = 6;
			this.exitButton.Text = "&خروج";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(178, 64);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(75, 23);
			this.loginButton.TabIndex = 5;
			this.loginButton.Text = "&ورود";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// registerButton
			// 
			this.registerButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.registerButton.Location = new System.Drawing.Point(97, 64);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(75, 23);
			this.registerButton.TabIndex = 4;
			this.registerButton.Text = "&ثبت نام";
			this.registerButton.UseVisualStyleBackColor = true;
			this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
			// 
			// LoginForm
			// 
			this.AcceptButton = this.loginButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.registerButton;
			this.ClientSize = new System.Drawing.Size(345, 96);
			this.Controls.Add(this.registerButton);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.usernameLabel);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.usernameTextBox);
			this.MaximumSize = new System.Drawing.Size(450, 135);
			this.MinimumSize = new System.Drawing.Size(361, 135);
			this.Name = "LoginForm";
			this.Text = "ورود به برنامه";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Dtx.Windows.Forms.TextBox usernameTextBox;
        private Dtx.Windows.Forms.TextBox passwordTextBox;
        private Dtx.Windows.Forms.Label usernameLabel;
        private Dtx.Windows.Forms.Label passwordLabel;
        private Dtx.Windows.Forms.Button exitButton;
        private Dtx.Windows.Forms.Button loginButton;
        private Dtx.Windows.Forms.Button registerButton;
    }
}