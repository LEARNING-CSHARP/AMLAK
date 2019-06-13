using System.Linq;

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
		}
		#endregion /ChangePasswordForm_Load

		#region Initialize
		public void Initialize()
		{
			oldpasswordLabel.Text = string.Empty;
			newPasswordTextBox.Text = string.Empty;
			confiramPasswordTextBox.Text = string.Empty;
		}
		#endregion /Initialize

		#region ShowoldpawwordPictureBox_Click
		private void ShowoldpawwordPictureBox_Click(object sender, System.EventArgs e)
		{
			if (oldPasswordTextBox.UseSystemPasswordChar == true)
			{
				oldPasswordTextBox.UseSystemPasswordChar = false;
				showOldPasswordPictureBox.Image = Properties.Resources.icons8_hide_100;
			}
			else if (oldPasswordTextBox.UseSystemPasswordChar == false)
			{
				oldPasswordTextBox.UseSystemPasswordChar = true;
				showOldPasswordPictureBox.Image = Properties.Resources.icons8_eye_100;
			}
		}
		#endregion /ShowoldpawwordPictureBox_Click

		#region ShownewpasswordPictureBox_Click
		private void ShownewpasswordPictureBox_Click(object sender, System.EventArgs e)
		{
			if (newPasswordTextBox.UseSystemPasswordChar == true)
			{
				newPasswordTextBox.UseSystemPasswordChar = false;
				showNewPasswordPictureBox.Image = Properties.Resources.icons8_hide_100;
			}
			else if (newPasswordTextBox.UseSystemPasswordChar == false)
			{
				newPasswordTextBox.UseSystemPasswordChar = true;
				showNewPasswordPictureBox.Image = Properties.Resources.icons8_eye_100;
			}
		}
		#endregion /ShownewpasswordPictureBox_Click

		#region ShowconfirmpasswordPictureBox_Click
		private void ShowconfirmpasswordPictureBox_Click(object sender, System.EventArgs e)
		{
			if (confiramPasswordTextBox.UseSystemPasswordChar == true)
			{
				confiramPasswordTextBox.UseSystemPasswordChar = false;
				showConfirmPasswordPictureBox.Image = Properties.Resources.icons8_hide_100;
			}
			else if (confiramPasswordTextBox.UseSystemPasswordChar == false)
			{
				confiramPasswordTextBox.UseSystemPasswordChar = true;
				showConfirmPasswordPictureBox.Image = Properties.Resources.icons8_eye_100;
			}
		}
		#endregion /ShowconfirmpasswordPictureBox_Click

		#region ChangepasswordButton_Click
		private void ChangepasswordButton_Click(object sender, System.EventArgs e)
		{
			string message = string.Empty;

			if (string.IsNullOrWhiteSpace(oldPasswordTextBox.Text))
			{
				message =
					"لطفا گذرواژه قدیمی را وارد نمایید.";

				Dtx.Windows.Forms.MessageBox.ShowError(message);
				oldPasswordTextBox.Focus();

				return;
			}

			if (string.IsNullOrWhiteSpace(newPasswordTextBox.Text))
			{
				message =
					"لطفا گذرواژه جدید را وارد نمایید.";

				Dtx.Windows.Forms.MessageBox.ShowError(message);
				newPasswordTextBox.Focus();

				return;
			}

			if (string.IsNullOrWhiteSpace(confiramPasswordTextBox.Text))
			{
				message =
					"لطفا تایید گذرواژه را وارد نمایید.";

				Dtx.Windows.Forms.MessageBox.ShowError(message);
				confiramPasswordTextBox.Focus();

				return;
			}

			if (newPasswordTextBox.Text != confiramPasswordTextBox.Text)
			{
				message =
					"دو گذرواژه با یکدیگر تطبیق ندارند. لطفا مجددا اقدام نمایید.";

				Dtx.Windows.Forms.MessageBox.ShowError(message);
				newPasswordTextBox.SelectAll();
				newPasswordTextBox.Focus();

				return;
			}

			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				Models.User user =
					databaseContext.Users
					.Where(current => string.Compare(current.Username, Program.LoginForm.usernameTextBox.Text, false) == 0)
					.FirstOrDefault();

				if (user == null)
				{
					System.Windows.Forms.Application.Exit();
				}

				if (string.Compare(user.Password, oldPasswordTextBox.Text, false) != 0)
				{
					message =
						"گذرواژه صحیح نمی باشد. لطفا مجددا اقدام نمایید.";

					Dtx.Windows.Forms.MessageBox.ShowError(message);
					oldPasswordTextBox.SelectAll();
					oldPasswordTextBox.Focus();

					return;
				}

				user.Password = newPasswordTextBox.Text;

				databaseContext.SaveChanges();

				message =
					"گذرواژه با موفقیت تغییر یافت.";

				Dtx.Windows.Forms.MessageBox.ShowInformation(message);

				Initialize();
			}
			catch (System.Exception ex)
			{
				Dtx.Windows.Forms.MessageBox.ShowError(ex.Message);
			}
		}
		#endregion /ChangepasswordButton_Click
	}
}
