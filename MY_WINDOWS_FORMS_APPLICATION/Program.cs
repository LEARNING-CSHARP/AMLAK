namespace MY_WINDOWS_FORMS_APPLICATION
{
	internal static class Program
	{
		static Program()
		{
		}

		// **************************************************
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
		// **************************************************

		// **************************************************
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
