﻿using System.Linq;

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
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				Models.User authenticatedUser = Program.AuthenticatedUser;

				Models.User user =
					databaseContext.Users
					.Where(current => current.Id == authenticatedUser.Id)
					.FirstOrDefault();

				if (user == null)
				{
					System.Windows.Forms.Application.Exit();
				}

				fullNameTextBox.Text = user.FullName;
				descriptionTextBox.Text = user.Description;
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
		#endregion /UpdateProfileForm_Load

		#region SaveButton_Click
		private void SaveButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				Models.User authenticatedUser = Program.AuthenticatedUser;

				Models.User user =
					databaseContext.Users
					.Where(current => current.Id == authenticatedUser.Id)
					.FirstOrDefault();

				if (user == null)
				{
					System.Windows.Forms.Application.Exit();
				}

				user.FullName = fullNameTextBox.Text;
				user.Description = descriptionTextBox.Text;

				databaseContext.SaveChanges();

				Dtx.Windows.Forms.MessageBox.ShowInformation("اطلاعات شما با موفقیت ذخیره گردید.");

				// **************************************************
				Program.AuthenticatedUser = user;
				Program.MainForm.Initialize();
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