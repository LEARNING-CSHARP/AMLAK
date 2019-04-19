using System.Linq;

namespace MY_WINDOWS_FORMS_APPLICATION
{
	public partial class RegisterForm : Infrastructure.BaseForm
	{
		public RegisterForm()
		{
			InitializeComponent();
		}

		#region RegisterForm_Load
		private void RegisterForm_Load(object sender, System.EventArgs e)
		{
			Initialize();
		}
		#endregion /RegisterForm_Load

		#region Initialize
		public void Initialize()
		{
			usernameTextBox.Text = string.Empty;
			passwordTextBox.Text = string.Empty;
			fullNameTextBox.Text = string.Empty;

			usernameTextBox.Focus();
		}
		#endregion /Initialize

		#region RegisterButton_Click
		private void RegisterButton_Click(object sender, System.EventArgs e)
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
						"تکمیل فیلد شناسه‌کاربری اجباری است!";

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
						"تکمیل فیلد گذرواژه اجباری است!";

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

				// **************************************************
				//Models.User user =
				//	MyDatabaseContext.Users
				//	.Where(current => current.Username == usernameTextBox.Text)
				//	.FirstOrDefault();

				Models.User user =
					databaseContext.Users
					.Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0)
					.FirstOrDefault();

				if (user != null)
				{
					errorMessages =
						"شناسه‌کاربر تکراری است! لطفا از شناسه کابری دیگری استفاده نمایید.";

					Dtx.Windows.Forms.MessageBox.ShowError(errorMessages);

					usernameTextBox.Focus();

					return;
				}

				user = new Models.User
				{
					IsActive = true, // بستگی به سناریوی مشتری دارد

					FullName = fullNameTextBox.Text,
					Password = passwordTextBox.Text,
					Username = usernameTextBox.Text,
				};

				databaseContext.Users.Add(user);

				databaseContext.SaveChanges();
				// **************************************************

				// **************************************************
				string message =
					"اطلاعات شما با موفقیت ثبت گردید.";

				Dtx.Windows.Forms.MessageBox.ShowInformation(message);
				// **************************************************
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
		#endregion /RegisterButton_Click

		#region ResetButton_Click
		private void ResetButton_Click(object sender, System.EventArgs e)
		{
			Initialize();
		}
		#endregion /ResetButton_Click

		#region LoginButton_Click
		private void LoginButton_Click(object sender, System.EventArgs e)
		{
			Hide();

			Program.ShowLoginForm();
		}
		#endregion /LoginButton_Click

		#region ExitButton_Click
		private void ExitButton_Click(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.Exit();
		}
		#endregion /ExitButton_Click
	}
}
