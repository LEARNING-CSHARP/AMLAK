using System.Linq;

namespace MY_WINDOWS_FORMS_APPLICATION.Administrator
{
	public partial class UpdateUserForm : Infrastructure.BaseForm
	{
		public UpdateUserForm()
		{
			InitializeComponent();
		}

		public string Username { get; set; }

		public UsersListForm MyUserListForm { get; set; }

		#region UpdateUserForm_Load
		private void UpdateUserForm_Load(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				Models.User user =
					databaseContext.Users
					.Where(current => string.Compare(current.Username, Username, true) == 0)
					.FirstOrDefault();

				if (user == null)
				{
					Dtx.Windows.Forms.MessageBox.ShowError("اطلاعات این کاربر حذف شده است!");
					Close();
				}

				fullNameTextBox.Text = user.FullName;
				descriptionTextBox.Text = user.Description;

				isActiveCheckBox.Checked = user.IsActive;
				isAdministratorCheckBox.Checked = user.IsAdministrator;
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
		#endregion /UpdateUserForm_Load

		#region SaveButton_Click
		private void SaveButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				Models.User user =
					databaseContext.Users
					.Where(current => string.Compare(current.Username, Username, true) == 0)
					.FirstOrDefault();

				if (user == null)
				{
					Dtx.Windows.Forms.MessageBox.ShowError("اطلاعات این کاربر حذف شده است!");
					Close();
				}

				user.FullName = fullNameTextBox.Text;
				user.Description = descriptionTextBox.Text;

				user.IsActive = isActiveCheckBox.Checked;
				user.IsAdministrator = isAdministratorCheckBox.Checked;

				databaseContext.SaveChanges();

				Dtx.Windows.Forms.MessageBox.ShowInformation("اطلاعات شما با موفقیت ذخیره گردید.");

				// **************************************************
				MyUserListForm.Search();
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
		#endregion /SaveButton_Click
	}
}
