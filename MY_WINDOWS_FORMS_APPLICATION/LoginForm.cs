using System.Linq;

namespace MY_WINDOWS_FORMS_APPLICATION
{
	public partial class LoginForm : Infrastructure.BaseForm
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		#region LoginForm_Load
		private void LoginForm_Load(object sender, System.EventArgs e)
		{
			Initialize();
		}
		#endregion /LoginForm_Load

		public void Initialize()
		{
			usernameTextBox.Text = string.Empty;
			passwordTextBox.Text = string.Empty;

			usernameTextBox.Focus();
		}

		#region LoginButton_Click
		private void LoginButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				// **************************************************
				// Validation
				// **************************************************
				string errorMessages = string.Empty;

				if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
				{
					errorMessages =
						"لطفا شناسه کاربری را وارد نمایید!";

					usernameTextBox.Text = string.Empty;
				}

				if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
				{
					if (errorMessages != string.Empty)
					{
						errorMessages +=
							System.Environment.NewLine;
					}

					errorMessages +=
						"لطفا گذرواژه را وارد نمایید!";

					passwordTextBox.Text = string.Empty;
				}

				if (errorMessages != string.Empty)
				{
					if (usernameTextBox.Text == string.Empty)
					{
						usernameTextBox.Focus();
					}
					else
					{
						passwordTextBox.Focus();
					}

					Dtx.Windows.Forms.MessageBox.ShowError(errorMessages);

					return;
				}
				// **************************************************
				// /Validation
				// **************************************************

				Models.User foundedUser =
					databaseContext.Users
					.Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0)
					.FirstOrDefault();

				if (foundedUser == null)
				{
					string errorMessage =
						"شناسه‌کاربری و/یا گذرواژه صحیح نمی‌باشد!";

					Dtx.Windows.Forms.MessageBox.ShowError(errorMessage);

					usernameTextBox.Focus();

					return;
				}

				if (string.Compare(foundedUser.Password, passwordTextBox.Text, ignoreCase: false) != 0)
				{
					string errorMessage =
						"شناسه‌کاربری و/یا گذرواژه صحیح نمی‌باشد!";

					Dtx.Windows.Forms.MessageBox.ShowError(errorMessage);

					usernameTextBox.Focus();

					return;
				}

				if (foundedUser.IsActive == false)
				{
					string errorMessage =
						"کاربر گرامی، دسترسی شما به سامانه تا اطلاع ثانوی مسدود می‌باشد!";

					Dtx.Windows.Forms.MessageBox.ShowError(errorMessage);

					usernameTextBox.Focus();

					return;
				}

				Program.UpdateProfileForm.IDTextBox.Text = foundedUser.Id.ToString();
				Program.UpdateProfileForm.usernameTextBox.Text = foundedUser.Username;
				Program.UpdateProfileForm.passwordTextBox.Text = foundedUser.Password;
				Program.UpdateProfileForm.fullNameTextBox.Text = foundedUser.FullName;
				Program.UpdateProfileForm.descriptionTextBox.Text = foundedUser.Description;

				Hide();

				Program.AuthenticatedUser = foundedUser;

				Program.ShowMainForm();
			}
			catch (System.Exception ex)
			{
				Dtx.Windows.Forms.MessageBox.ShowError(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
		}

		#endregion /LoginButton_Click

		#region ResetButton_Click
		private void ResetButton_Click(object sender, System.EventArgs e)
		{
			Initialize();
		}
		#endregion /ResetButton_Click

		#region RegisterButton_Click
		private void RegisterButton_Click(object sender, System.EventArgs e)
		{
			Hide();

			Program.ShowRegisterForm();
		}
		#endregion /RegisterButton_Click

		#region ExitButton_Click
		private void ExitButton_Click(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.Exit();
		}

		#endregion /ExitButton_Click
	}
}
