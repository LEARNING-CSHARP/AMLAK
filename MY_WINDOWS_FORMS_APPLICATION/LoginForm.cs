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
		}
		#endregion /LoginForm_Load

		#region LoginButton_Click
		private void LoginButton_Click(object sender, System.EventArgs e)
		{
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

			Models.User user =
				MyDatabaseContext.Users
				.Where(current => (string.Compare(current.Username, usernameTextBox.Text, true) == 0))
				.FirstOrDefault();

			if (user == null)
			{
				string errorMessage =
					"همچین کاربری وجود ندارد!";

				Dtx.Windows.Forms.MessageBox.ShowError(errorMessage);

				usernameTextBox.Focus();

				return;
			}

			// Sulotion for chech password: ابتدا باید رکورد مربوط به نام کاربری مشخص گردد و بعد از آن 
			// عمل مقایسه گذرواژه وارد شده با گذرواژه رکورد مربوطه صورت پذیرد.
			// .که در صورت عدم مغاییرت امکان ورود مهیا باشد

			string message =
				$" خوش اومدی { usernameTextBox.Text }.";

			Dtx.Windows.Forms.MessageBox.ShowInformation(message);
		}

		#endregion /LoginButton_Click

		#region ResetButton_Click
		private void ResetButton_Click(object sender, System.EventArgs e)
		{
			usernameTextBox.Text = string.Empty;
			passwordTextBox.Text = string.Empty;

			usernameTextBox.Focus();
		}
		#endregion /ResetButton_Click

		#region RegisterButton_Click
		private void RegisterButton_Click(object sender, System.EventArgs e)
		{
			Hide();

			Program.RegisterForm.Show();
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
