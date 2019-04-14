namespace MY_WINDOWS_FORMS_APPLICATION
{
	internal static class Program
	{
		static Program()
		{
		}
		// **************************************************
		public static RegisterForm startupForm;
		// **************************************************
		[System.STAThread]
		static void Main()
		{
			// **************************************************
			System.Windows.Forms.Application.EnableVisualStyles();
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
			// **************************************************
			startupForm = new RegisterForm();
			// **************************************************

			System.Windows.Forms.Application.Run(startupForm);

			if (startupForm != null)
			{
				if (startupForm.IsDisposed == false)
				{
					startupForm.Dispose();
				}

				startupForm = null;
			}
			// **************************************************
		}
	}
}
