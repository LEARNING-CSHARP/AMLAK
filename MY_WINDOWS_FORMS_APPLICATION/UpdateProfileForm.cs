using System.Linq;
namespace MY_WINDOWS_FORMS_APPLICATION
{
	public partial class UpdateProfileForm : Infrastructure.BaseForm
	{
		public UpdateProfileForm()
		{
			InitializeComponent();
		}

		#region UpdateProfileForm_Load
		private void UpdateProfileForm_Load(object sender, System.EventArgs e)
		{
		}
		#endregion /UpdateProfileForm_Load

		#region Initialize
		public void Initialize()
		{
			showPasswordCheckBox.Checked = false;
			showPasswordCheckBox.Text = "نمایش گذر واژه";
			showPasswordCheckBox.Location = new System.Drawing.Point(161, 101);
		}
		#endregion /Initialize

		#region PictureChangeLinkLabel_LinkClicked
		private void PictureChangeLinkLabel_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			openFileDialog1.Filter =
				"Image Files(*.Gif;*.Jpg;*.Bmp;*.Jpeg)|*.Gif;*.Jpg;*.Bmp;*.Jpeg";

			openFileDialog1.Title =
				"بارگذاری تصویر";

			userImagePictureBox.SizeMode =
				System.Windows.Forms.PictureBoxSizeMode.StretchImage;

			if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				userImagePictureBox.Image =
					System.Drawing.Image.FromFile(openFileDialog1.FileName);
			}
		}
		#endregion /PictureChangeLinkLabel_LinkClicked

		#region UpdateButton_Click
		private void UpdateButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;
			try
			{
				databaseContext =
					new Models.DatabaseContext();

				Models.User userload =
				databaseContext.Users
				.Where(Cursor => string.Compare(Cursor.Username, usernameTextBox.Text, true) == 0)
				.FirstOrDefault();

			}
			catch (System.Exception ex)
			{

				Dtx.Windows.Forms.MessageBox.ShowError(ex.Message);
			}
		}
		#endregion /UpdateButton_Click

		#region ResetButton_Click
		private void ResetButton_Click(object sender, System.EventArgs e)
		{
			Initialize();
		}
		#endregion /ResetButton_Click

		#region  MainFormButton_Click
		private void MainFormButton_Click(object sender, System.EventArgs e)
		{
			Hide();
			Program.ShowMainForm();
		}
		#endregion / MainFormButton_Click

		#region ExitButton_Click
		private void ExitButton_Click(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.Exit();
		}
		#endregion /ExitButton_Click

		#region ShowPasswordCheckBox_CheckedChanged
		private void ShowPasswordCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (showPasswordCheckBox.Checked == false)
			{
				passwordTextBox.UseSystemPasswordChar = true;
				showPasswordCheckBox.Text = "نمایش گذر واژه";
				showPasswordCheckBox.Location = new System.Drawing.Point(161, 101);
				this.Text = $"X={showPasswordCheckBox.Location.X}, Y={showPasswordCheckBox.Location.Y}";
			}
			else
			{
				passwordTextBox.UseSystemPasswordChar = false;
				showPasswordCheckBox.Text = "عدم نمایش گذر واژه";
				showPasswordCheckBox.Location = new System.Drawing.Point(138, 101);
				this.Text = $"X={showPasswordCheckBox.Location.X}, Y={showPasswordCheckBox.Location.Y}";
			}
		}
		#endregion /ShowPasswordCheckBox_CheckedChanged



	}
}
