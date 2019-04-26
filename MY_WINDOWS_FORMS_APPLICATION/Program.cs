using System.Linq;

namespace MY_WINDOWS_FORMS_APPLICATION
{
	internal static class Program
	{
		static Program()
		{
		}

		// **************************************************
		public static Models.User AuthenticatedUser { get; set; }
		// **************************************************

		// **************************************************
		#region MainForm
		private static MainForm mainForm;

		public static MainForm MainForm
		{
			get
			{
				if (mainForm == null)
				{
					mainForm =
						new MainForm();
				}

				return mainForm;
			}
		}

		public static void ShowMainForm()
		{
			MainForm.Initialize();

			MainForm.Show();
		}
		#endregion /MainForm
		// **************************************************

		// **************************************************
		#region LoginForm
		private static LoginForm loginForm;

		public static LoginForm LoginForm
		{
			get
			{
				if (loginForm == null)
				{
					loginForm =
						new LoginForm();
				}

				return loginForm;
			}
		}

		public static void ShowLoginForm()
		{
			AuthenticatedUser = null;

			LoginForm.Initialize();

			LoginForm.Show();
		}
		#endregion /LoginForm
		// **************************************************

		// **************************************************
		#region RegisterForm
		private static RegisterForm registerForm;

		public static RegisterForm RegisterForm
		{
			get
			{
				if (registerForm == null)
				{
					registerForm =
						new RegisterForm();
				}

				return registerForm;
			}
		}

		public static void ShowRegisterForm()
		{
			RegisterForm.Initialize();

			RegisterForm.Show();
		}
		#endregion /RegisterForm
		// **************************************************

		// **************************************************
		#region Main
		[System.STAThread]
		static void Main()
		{
			// **************************************************
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				string username = "Administrator";

				//Models.User adminUser =
				//	databaseContext.Users
				//	.Where(current => current.Username == username)
				//	.FirstOrDefault();

				Models.User adminUser =
					databaseContext.Users
					.Where(current => string.Compare(current.Username, username, true) == 0)
					.FirstOrDefault();

				if (adminUser == null)
				{
					//adminUser = new Models.User();

					//adminUser.IsActive = true;
					//adminUser.IsAdministrator = true;

					//adminUser.Username = username;
					//adminUser.Password = "1234512345";

					adminUser = new Models.User
					{
						IsActive = true,
						IsAdministrator = true,

						Username = username,
						Password = "1234512345",
					};

					databaseContext.Users.Add(adminUser);
				}
				else
				{
					if (adminUser.IsActive == false)
					{
						adminUser.IsActive = true;
					}

					if (adminUser.IsAdministrator == false)
					{
						adminUser.IsAdministrator = true;
					}
				}

				databaseContext.SaveChanges();
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
			// **************************************************

			// **************************************************
			System.Windows.Forms.Application.EnableVisualStyles();
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
			// **************************************************

			// **************************************************
			//LoginForm startupForm = new LoginForm();

			//System.Windows.Forms.Application.Run(startupForm);

			//if (startupForm != null)
			//{
			//	if (startupForm.IsDisposed == false)
			//	{
			//		startupForm.Dispose();
			//	}

			//	startupForm = null;
			//}
			// **************************************************

			// **************************************************
			System.Windows.Forms.Application.Run(LoginForm);
			// **************************************************
		}
		#endregion /Main
	}
}
