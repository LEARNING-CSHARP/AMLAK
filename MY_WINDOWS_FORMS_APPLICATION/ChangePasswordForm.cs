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
			Initialize();
		}
		#endregion

		#region Initialize
		public void Initialize()
		{
			oldpasswordTextBox.Text = string.Empty;
			newpasswordTextBox.Text = string.Empty;
			confirampasswordTextBox.Text = string.Empty;
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
			else if (oldpasswordTextBox.UseSystemPasswordChar == false)
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

		#region ChangepasswordButton_Click
		private void ChangepasswordButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;
			try
			{
				databaseContext =
					new Models.DatabaseContext();

				if (string.IsNullOrWhiteSpace(oldpasswordTextBox.Text))
				{
					string message =
						"لطفا گذرواژه قدیمی را وارد نمایید.";
					Dtx.Windows.Forms.MessageBox.ShowError(message);
					oldpasswordTextBox.Focus();
					return;
				}

				if (string.IsNullOrWhiteSpace(newpasswordTextBox.Text))
				{
					string message =
						"لطفا گذرواژه جدید را وارد نمایید.";
					Dtx.Windows.Forms.MessageBox.ShowError(message);
					newpasswordTextBox.Focus();
					return;
				}

				if (string.IsNullOrWhiteSpace(confirampasswordTextBox.Text))
				{
					string message =
						"لطفا تایید گذرواژه را وارد نمایید.";
					Dtx.Windows.Forms.MessageBox.ShowError(message);
					confirampasswordTextBox.Focus();
					return;
				}

				Models.User passworduser =
					databaseContext.Users
					.Where(current => string.Compare(current.Username, Program.LoginForm.usernameTextBox.Text, false) == 0)
					.FirstOrDefault();
				if (passworduser != null)
				{
					if (string.Compare(passworduser.Password, oldpasswordTextBox.Text, false)!=0)
					{
						string message =
							"گذرواژه صحیح نمی باشد. لطفا مجددا اقدام نمایید.";
						Dtx.Windows.Forms.MessageBox.ShowError(message);
						oldpasswordTextBox.SelectAll();
						oldpasswordTextBox.Focus();
						return;
					}
					else if (newpasswordTextBox.Text != confirampasswordTextBox.Text)
					{
						string message =
						"دو گذرواژه با یکدیگر تطبیق ندارند. لطفا مجددا اقدام بفرمایید.";
						Dtx.Windows.Forms.MessageBox.ShowError(message);
						newpasswordTextBox.SelectAll();
						newpasswordTextBox.Focus();
						return;
					}
				}
			}
			catch (System.Exception)
			{
				throw;
			}
		}
		#endregion /ChangepasswordButton_Click

		#region ResetButton_Click
		private void ResetButton_Click(object sender, System.EventArgs e)
		{
			Initialize();
		}

		#endregion /ResetButton_Click

		#region MainformButton_Click
		private void MainformButton_Click(object sender, System.EventArgs e)
		{
			Hide();
			Program.ShowMainForm();
		}
		#endregion /MainformButton_Click

		#region ExitButton_Click
		private void ExitButton_Click(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.Exit();
		}
		#endregion /ExitButton_Click

	}
}
