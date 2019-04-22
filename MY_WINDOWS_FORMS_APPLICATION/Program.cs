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
		#region UpdateProfileForm
		private static UpdateProfileForm updateProfileForm;
		public static UpdateProfileForm UpdateProfileForm
		{
			get
			{
				if (updateProfileForm==null)
				{
					updateProfileForm =
						new UpdateProfileForm();
				}
				return updateProfileForm;
			}
		}

		public static void ShowUpdateProfileForm()
		{
			UpdateProfileForm.Initialize();
			UpdateProfileForm.Show();
		}
		#endregion /UpdateProfileForm
		// **************************************************

		[System.STAThread]
		static void Main()
		{
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
	}
}
