namespace MY_WINDOWS_FORMS_APPLICATION
{
	public partial class ChangePasswordForm : Infrastructure.BaseForm
	{
		public ChangePasswordForm()
		{
			InitializeComponent();
		}

		#region ChangePasswordForm_Load
		private void ChangePasswordForm_Load(object sender, System.EventArgs e)
		{
			Initialize();
		}
		#endregion

		#region Initialize
		public void Initialize()
		{
			//oldpasswordTextBox.Text = string.Empty;
			//newpasswordTextBox.Text = string.Empty;
			//confirampasswordTextBox.Text = string.Empty;
		}
		#endregion /Initialize

		#region ShowoldpawwordPictureBox_Click
		private void ShowoldpawwordPictureBox_Click(object sender, System.EventArgs e)
		{
			if (oldpasswordTextBox.UseSystemPasswordChar == true)
			{
				oldpasswordTextBox.UseSystemPasswordChar = false;
				showoldpawwordPictureBox.Image = Properties.Resources.icons8_hide_100;
			}
			else if(oldpasswordTextBox.UseSystemPasswordChar == false)
			{
				oldpasswordTextBox.UseSystemPasswordChar = true;
				showoldpawwordPictureBox.Image = Properties.Resources.icons8_eye_100;
			}
		}
		#endregion /ShowoldpawwordPictureBox_Click

		#region ShownewpasswordPictureBox_Click
		private void ShownewpasswordPictureBox_Click(object sender, System.EventArgs e)
		{
			if (newpasswordTextBox.UseSystemPasswordChar == true)
			{
				newpasswordTextBox.UseSystemPasswordChar = false;
				shownewpasswordPictureBox.Image = Properties.Resources.icons8_hide_100;
			}
			else if (newpasswordTextBox.UseSystemPasswordChar == false)
			{
				newpasswordTextBox.UseSystemPasswordChar = true;
				shownewpasswordPictureBox.Image = Properties.Resources.icons8_eye_100;
			}
		}
		#endregion /ShownewpasswordPictureBox_Click

		#region ShowconfirmpasswordPictureBox_Click
		private void ShowconfirmpasswordPictureBox_Click(object sender, System.EventArgs e)
		{
			if (confirampasswordTextBox.UseSystemPasswordChar == true)
			{
				confirampasswordTextBox.UseSystemPasswordChar = false;
				showconfirmpasswordPictureBox.Image = Properties.Resources.icons8_hide_100;
			}
			else if (confirampasswordTextBox.UseSystemPasswordChar == false)
			{
				confirampasswordTextBox.UseSystemPasswordChar = true;
				showconfirmpasswordPictureBox.Image = Properties.Resources.icons8_eye_100;
			}
		}
		#endregion /ShowconfirmpasswordPictureBox_Click

		#region MyRegion

		#endregion


	}
}
