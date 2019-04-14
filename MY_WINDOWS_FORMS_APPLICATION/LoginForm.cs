using System.Linq;
namespace MY_WINDOWS_FORMS_APPLICATION
{
	public partial class LoginForm : Infrastructure.BaseForm
	{
		public LoginForm()
		{
			InitializeComponent();
			
		}
		
		#region Register Button
		private void RegisterButton_Click(object sender, System.EventArgs e)
		{
			if (Program.startupForm!=null || Program.startupForm.IsDisposed!=true)
			{
				Program.startupForm.Show();
				this.Close();
			}
		}
		#endregion /Register Button

		#region Login Button
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

			Models.User userName =
				MyDatabaseContext.Users
				.Where(current => (string.Compare(current.Username, usernameTextBox.Text, true) == 0))
				.FirstOrDefault();

			if (userName == null)
			{
				string message =
				"همچین کاربری وجود ندارد.";

				Dtx.Windows.Forms.MessageBox.ShowInformation(message);

				usernameTextBox.Focus();
			}
			// Sulotion for chech password: ابتدا باید رکورد مربوط به نام کاربری مشخص گردد و بعد از آن 
			// عمل مقایسه گذرواژه وارد شده با گذرواژه رکورد مربوطه صورت پذیرد.
			// .که در صورت عدم مغاییرت امکان ورود مهیا باشد
			else
			{
				string message =
				$" خوش اومدی { usernameTextBox.Text }.";

				Dtx.Windows.Forms.MessageBox.ShowInformation(message);
			}
		}

		#endregion /Login Button

		#region Exit Button
		private void ExitButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.DialogResult result;

			result = System.Windows.Forms.MessageBox.Show(text: "", caption: "",
				buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
				icon: System.Windows.Forms.MessageBoxIcon.Question,
				defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
				options: System.Windows.Forms.MessageBoxOptions.RightAlign | System.Windows.Forms.MessageBoxOptions.RtlReading);

			if (result == System.Windows.Forms.DialogResult.Yes)
			{
				System.Windows.Forms.Application.Exit();
			}
		}

		#endregion /Exit Button
	}
}
