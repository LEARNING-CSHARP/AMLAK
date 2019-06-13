//using System.Linq;

namespace MY_WINDOWS_FORMS_APPLICATION
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		#region MainForm_FormClosed
		private void MainForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
		#endregion /MainForm_FormClosed

		#region MainForm_Load
		private void MainForm_Load(object sender, System.EventArgs e)
		{
			persianCalendarToolStripStatusLabel.Text = Infrastructure.Utility.ShowWithNameMonthPersianCalenda(System.DateTime.Now);
		}
		#endregion /MainForm_Load

		#region Initialize
		public void Initialize()
		{
			Models.User authenticatedUser = Program.AuthenticatedUser;

			if (authenticatedUser == null)
			{
				System.Windows.Forms.Application.Exit();
			}

			string name =
				authenticatedUser.FullName;

			if (string.IsNullOrWhiteSpace(name))
			{
				name =
					authenticatedUser.Username;
			}

			welcomeToolStripStatusLabel.Text = $"{ name } خوش آمدید.";

			
			// **************************************************
			//if (authenticatedUser.IsAdministrator)
			//{
			//	administratorToolStripMenuItem.Visible = true;
			//}
			//else
			//{
			//	administratorToolStripMenuItem.Visible = false;
			//}
			// **************************************************

			// **************************************************
			administratorToolStripMenuItem.Visible = authenticatedUser.IsAdministrator;
			// **************************************************
		}
		#endregion /Initialize

		#region LogoutToolStripMenuItem_Click
		private void LogoutToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Hide();

			Program.ShowLoginForm();
		}
		#endregion /LogoutToolStripMenuItem_Click

		#region ExitToolStripMenuItem_Click
		private void ExitToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.Exit();
		}
		#endregion /ExitToolStripMenuItem_Click

		#region UpdateProfileToolStripMenuItem_Click

		private UpdateProfileForm updateProfileForm;
		private void UpdateProfileToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if (updateProfileForm == null || updateProfileForm.IsDisposed == true)
			{
				updateProfileForm = new UpdateProfileForm
				{
					MdiParent = this,
				};
				updateProfileForm.Show();
			}
		}
		#endregion /UpdateProfileToolStripMenuItem_Click

		#region ChangePasswordToolStripMenuItem_Click

		private ChangePasswordForm changePasswordForm;
		private void ChangePasswordToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if (changePasswordForm == null || changePasswordForm.IsDisposed == true)
			{
				changePasswordForm = new ChangePasswordForm()
				{
					MdiParent = this,
				};
				changePasswordForm.Show();
			}
		}
		#endregion /ChangePasswordToolStripMenuItem_Click

		#region DisplayUsersListFormToolStripMenuItem_Click
		private Administrator.UsersListForm usersListForm;

		private void DisplayUsersListFormToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if ((usersListForm == null) || usersListForm.IsDisposed)
			{
				usersListForm = new Administrator.UsersListForm
				{
					MdiParent = this,
				};
			}

			usersListForm.Show();
		}
		#endregion /DisplayUsersListFormToolStripMenuItem_Click
	}
}
