using System.Linq;

namespace MY_WINDOWS_FORMS_APPLICATION
{
	public partial class RegisterForm : Infrastructure.BaseForm
	{
		public RegisterForm()
		{
			InitializeComponent();
		}

		private void RegisterForm_Load(object sender, System.EventArgs e)
		{
		}

		private void RegisterButton_Click(object sender, System.EventArgs e)
		{
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
				MyDatabaseContext.Users
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

			MyDatabaseContext.Users.Add(user);

			MyDatabaseContext.SaveChanges();
			// **************************************************

			// **************************************************
			string message =
				"اطلاعات شما با موفقیت ثبت گردید.";

			Dtx.Windows.Forms.MessageBox.ShowInformation(message);
			// **************************************************
		}
	}
}
