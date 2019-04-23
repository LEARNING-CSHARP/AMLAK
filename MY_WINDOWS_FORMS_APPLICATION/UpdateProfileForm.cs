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
			Models.User authenticatedUser = Program.AuthenticatedUser;

			if (authenticatedUser!=null)
			{
				usernameTextBox.Text = authenticatedUser.Username;
				IDTextBox.Text = authenticatedUser.Id.ToString();
				passwordTextBox.Text = authenticatedUser.Password;
				fullNameTextBox.Text = authenticatedUser.FullName;
				descriptionTextBox.Text = authenticatedUser.Description;
			}
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
			#region Solution 3
			Models.DatabaseContext databaseContext = new Models.DatabaseContext();

			Models.User upadteuser = Program.AuthenticatedUser;
			if (upadteuser != null)
			{
				upadteuser.FullName = fullNameTextBox.Text;
				upadteuser.Description = descriptionTextBox.Text;

				databaseContext.Users.Add(upadteuser);
				databaseContext.SaveChanges();
			}


			string message =
				"اطلاعات با موفقیت به روزسانی گردید.";
			Dtx.Windows.Forms.MessageBox.ShowInformation(message);
			#endregion

			#region Solution 1
			//Models.DatabaseContext databaseContext = null;

			//databaseContext = new Models.DatabaseContext();

			//Models.User updateuser =
			//	new Models.User();

			//if (string.Compare(updateuser.Username, usernameTextBox.Text, ignoreCase: false) == 0)
			//{
			//	updateuser.FullName = fullNameTextBox.Text;
			//	updateuser.Description = descriptionTextBox.Text;
			//}
			//databaseContext.Users.Add(updateuser);
			//databaseContext.SaveChanges();
			//string message =
			//	"اطلاعات به روز برسانی گردید.";
			//Dtx.Windows.Forms.MessageBox.ShowInformation(message);
			#endregion /Solution 1

			#region Solution 2
			//Models.DatabaseContext databaseContext = null;
			//try
			//{
			//	databaseContext =
			//		new Models.DatabaseContext();

			//	Models.User userload =
			//	databaseContext.Users
			//	.Where(Cursor => string.Compare(Cursor.Username, usernameTextBox.Text, true) == 0)
			//	.FirstOrDefault();

			//	if (userload!=null)
			//	{
			//		userload =
			//			new Models.User
			//			{
			//				FullName = fullNameTextBox.Text,
			//				Description=descriptionTextBox.Text,
			//			};
			//	}

			//}
			//catch (System.Exception ex)
			//{

			//	Dtx.Windows.Forms.MessageBox.ShowError(ex.Message);
			//}
			#endregion /Solution 2
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

		#region ChangePasswordLinkLabel_LinkClicked
		private void ChangePasswordLinkLabel_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			Hide();
			Program.ShowChangePasswordForm();
		}
		#endregion /ChangePasswordLinkLabel_LinkClicked
	}
}
