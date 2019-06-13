using System.Linq;

namespace MY_WINDOWS_FORMS_APPLICATION.Administrator
{
	public partial class UsersListForm : Infrastructure.BaseForm
	{
		public UsersListForm()
		{
			InitializeComponent();
		}

		#region UsersListForm_Load
		private void UsersListForm_Load(object sender, System.EventArgs e)
		{
			myDataGridView.ReadOnly = true;

			myDataGridView.CellDoubleClick += MyDataGridView_CellDoubleClick;
		}
		#endregion /UsersListForm_Load

		#region MyDataGridView_CellDoubleClick
		private void MyDataGridView_CellDoubleClick
			(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1)
			{
				return;
			}

			if (e.ColumnIndex == -1)
			{
				return;
			}

			//System.Windows.Forms.DataGridViewCell cell = myDataGridView.CurrentCell;

			//foreach (System.Windows.Forms.DataGridViewCell cell in myDataGridView.CurrentRow.Cells)
			//{
			//	object value = cell.Value;

			//	if (value == null)
			//	{
			//		System.Windows.Forms.MessageBox.Show("[NULL]");
			//	}
			//	else
			//	{
			//		System.Windows.Forms.MessageBox.Show(value.ToString());
			//	}
			//}

			string selectedUsername =
				myDataGridView.CurrentRow.Cells[2].Value.ToString();

			//System.Windows.Forms.MessageBox.Show(selectedUsername);

			UpdateUserForm updateUserForm = new UpdateUserForm
			{
				MyUserListForm = this,
				Username = selectedUsername,
			};

			updateUserForm.ShowDialog();
		}
		#endregion /MyDataGridView_CellDoubleClick

		#region SearchButton_Click
		private void SearchButton_Click(object sender, System.EventArgs e)
		{
			Search();
		}
		#endregion

		#region Search
		public void Search()
		{
			usernameTextBox.Text = Dtx.Text.Utility.FixText(usernameTextBox.Text);
			fullNameTextBox.Text = Dtx.Text.Utility.FixText(fullNameTextBox.Text);

			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				// **************************************************
				//if (usernameTextBox.Text == string.Empty)
				//{
				//	var users =
				//		databaseContext.Users
				//		.OrderBy(current => current.Username)
				//		.ToList()
				//		;
				//}
				//else
				//{
				//	//var users =
				//	//	databaseContext.Users
				//	//	.Where(current => current.Username == usernameTextBox.Text)
				//	//	.OrderBy(current => current.Username)
				//	//	.ToList()
				//	//	;

				//	//var users =
				//	//	databaseContext.Users
				//	//	.Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0)
				//	//	.OrderBy(current => current.Username)
				//	//	.ToList()
				//	//	;

				//	//var users =
				//	//	databaseContext.Users
				//	//	.Where(current => current.Username.StartsWith(usernameTextBox.Text))
				//	//	.OrderBy(current => current.Username)
				//	//	.ToList()
				//	//	;

				//	//var users =
				//	//	databaseContext.Users
				//	//	.Where(current => current.Username.EndsWith(usernameTextBox.Text))
				//	//	.OrderBy(current => current.Username)
				//	//	.ToList()
				//	//	;

				//	var users =
				//		databaseContext.Users
				//		.Where(current => current.Username.Contains(usernameTextBox.Text))
				//		.OrderBy(current => current.Username)
				//		.ToList()
				//		;
				//}
				// **************************************************

				// **************************************************
				//var users; // Compile Error!
				//var users = null; // Compile Error!

				//if (usernameTextBox.Text == string.Empty)
				//{
				//	users =
				//		databaseContext.Users
				//		.OrderBy(current => current.Username)
				//		.ToList()
				//		;
				//}
				//else
				//{
				//	users =
				//		databaseContext.Users
				//		.Where(current => current.Username.Contains(usernameTextBox.Text))
				//		.OrderBy(current => current.Username)
				//		.ToList()
				//		;
				//}
				// **************************************************

				// **************************************************
				System.Collections.Generic.List<Models.User> users = null;

				if (usernameTextBox.Text == string.Empty)
				{
					users =
						databaseContext.Users
						.OrderBy(current => current.Username)
						.ToList()
						;
				}
				else
				{
					users =
						databaseContext.Users
						.Where(current => current.Username.Contains(usernameTextBox.Text))
						.OrderBy(current => current.Username)
						.ToList()
						;
				}
				// **************************************************

				myDataGridView.DataSource = users;

				myDataGridView.AutoResizeColumns
					(autoSizeColumnsMode: System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells);
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
		#endregion /Search
	}
}
