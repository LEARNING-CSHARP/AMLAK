namespace MY_WINDOWS_FORMS_APPLICATION.Administrator
{
	partial class UsersListForm
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
			this.components = new System.ComponentModel.Container();
			this.usernameLabel = new Dtx.Windows.Forms.Label();
			this.fullNameLabel = new Dtx.Windows.Forms.Label();
			this.usernameTextBox = new Dtx.Windows.Forms.TextBox();
			this.fullNameTextBox = new Dtx.Windows.Forms.TextBox();
			this.searchButton = new Dtx.Windows.Forms.Button();
			this.myDataGridView = new Dtx.Windows.Forms.DataGridView();
			this.resetButton = new Dtx.Windows.Forms.Button();
			this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// usernameLabel
			// 
			this.usernameLabel.AutoSize = true;
			this.usernameLabel.Location = new System.Drawing.Point(12, 15);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(72, 13);
			this.usernameLabel.TabIndex = 0;
			this.usernameLabel.Text = "شناسه‌کاربری";
			// 
			// fullNameLabel
			// 
			this.fullNameLabel.AutoSize = true;
			this.fullNameLabel.Location = new System.Drawing.Point(12, 42);
			this.fullNameLabel.Name = "fullNameLabel";
			this.fullNameLabel.Size = new System.Drawing.Size(89, 13);
			this.fullNameLabel.TabIndex = 2;
			this.fullNameLabel.Text = "نام و نام خانوادگی";
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.usernameTextBox.Location = new System.Drawing.Point(107, 12);
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(315, 21);
			this.usernameTextBox.TabIndex = 1;
			// 
			// fullNameTextBox
			// 
			this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fullNameTextBox.Location = new System.Drawing.Point(107, 39);
			this.fullNameTextBox.Name = "fullNameTextBox";
			this.fullNameTextBox.Size = new System.Drawing.Size(315, 21);
			this.fullNameTextBox.TabIndex = 3;
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(107, 66);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(75, 23);
			this.searchButton.TabIndex = 4;
			this.searchButton.Text = "جستجو";
			this.searchButton.UseVisualStyleBackColor = false;
			this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// myDataGridView
			// 
			this.myDataGridView.AllowUserToOrderColumns = true;
			this.myDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.myDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.myDataGridView.Location = new System.Drawing.Point(12, 95);
			this.myDataGridView.Name = "myDataGridView";
			this.myDataGridView.Size = new System.Drawing.Size(410, 304);
			this.myDataGridView.TabIndex = 5;
			// 
			// resetButton
			// 
			this.resetButton.Location = new System.Drawing.Point(188, 66);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(75, 23);
			this.resetButton.TabIndex = 6;
			this.resetButton.Text = "حالت اولیه";
			this.resetButton.UseVisualStyleBackColor = false;
			this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// userBindingSource
			// 
			this.userBindingSource.DataSource = typeof(Models.User);
			// 
			// UsersListForm
			// 
			this.AcceptButton = this.searchButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 411);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.myDataGridView);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.fullNameTextBox);
			this.Controls.Add(this.usernameTextBox);
			this.Controls.Add(this.fullNameLabel);
			this.Controls.Add(this.usernameLabel);
			this.MaximumSize = new System.Drawing.Size(800, 600);
			this.MinimumSize = new System.Drawing.Size(450, 450);
			this.Name = "UsersListForm";
			this.Text = "مدیریت کاربران";
			this.Load += new System.EventHandler(this.UsersListForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Dtx.Windows.Forms.Label usernameLabel;
		private Dtx.Windows.Forms.Label fullNameLabel;
		private Dtx.Windows.Forms.TextBox usernameTextBox;
		private Dtx.Windows.Forms.TextBox fullNameTextBox;
		private Dtx.Windows.Forms.Button searchButton;
		private Dtx.Windows.Forms.DataGridView myDataGridView;
		private Dtx.Windows.Forms.Button resetButton;
		private System.Windows.Forms.BindingSource userBindingSource;
	}
}