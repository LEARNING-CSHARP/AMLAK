//using System.Linq;

namespace MY_WINDOWS_FORMS_APPLICATION
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		#region MainForm_Load
		private void MainForm_Load(object sender, System.EventArgs e)
		{
		}
		#endregion /MainForm_Load

		#region Initialize
		public void Initialize()
		{
			Models.User authenticatedUser = Program.AuthenticatedUser;

			if (authenticatedUser != null)
			{
				string name = authenticatedUser.FullName;

				if (string.IsNullOrWhiteSpace(name))
				{
					name = authenticatedUser.Username;
				}

				welcomeToolStripStatusLabel.Text = $"{ name } خوش آمدید.";
			}
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
		private void UpdateProfileToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Hide();
			Program.ShowUpdateProfileForm();
		}
		#endregion /UpdateProfileToolStripMenuItem_Click

		#region ChangePasswordToolStripMenuItem_Click
		private void ChangePasswordToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Hide();
			Program.ShowChangePasswordForm();
		}
		#endregion /ChangePasswordToolStripMenuItem_Click
	}
}
