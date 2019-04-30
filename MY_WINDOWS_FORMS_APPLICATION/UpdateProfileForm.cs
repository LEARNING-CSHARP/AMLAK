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
			Initialize();
		}
		#endregion /UpdateProfileForm_Load

		#region Initialize
		public void Initialize()
		{
			try
			{
				Models.User authenticateuser = Program.AuthenticatedUser;

				if (authenticateuser != null)
				{
					string name = authenticateuser.FullName;

					if (string.IsNullOrWhiteSpace(name))
					{
						name = authenticateuser.Username;
					}
					string wellcomuser =
							$"{ name } خوش آمدید.";
					welcomToolStripStatusLabel.Text = wellcomuser;

					fullNameTextBox.Text = authenticateuser.FullName;
					descriptionTextBox.Text = authenticateuser.Description;
				}
			}
			catch (System.Exception ex)
			{
				Dtx.Windows.Forms.MessageBox.ShowError(ex.Message);
			}
		}

		#endregion /Initialize

		#region UpdateButton_Click
		private void UpdateButton_Click(object sender, System.EventArgs e)
		{
			
			try
			{
				Models.DatabaseContext databaseContext = null;

				databaseContext =
					new Models.DatabaseContext();

				Models.User authenticateuser = Program.AuthenticatedUser;

				if (authenticateuser != null)
				{
					authenticateuser.FullName = fullNameTextBox.Text;
					authenticateuser.Description= descriptionTextBox.Text;
				}

				databaseContext.Users.Add(authenticateuser);
				databaseContext.SaveChanges();

				string message =
					"اطلاعات به روز شد.";
				Dtx.Windows.Forms.MessageBox.ShowInformation(message);

			}
			catch (System.Exception es)
			{
				Dtx.Windows.Forms.MessageBox.ShowError(es.Message);
			}
		}
		#endregion /UpdateButton_Click
	}
}