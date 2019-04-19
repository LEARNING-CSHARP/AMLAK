namespace Infrastructure
{
	public static class Utility
	{
		static Utility()
		{
		}

		public static void Exit()
		{
			System.Windows.Forms.DialogResult result;

			result = System.Windows.Forms.MessageBox.Show(text: "", caption: "",
				buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
				icon: System.Windows.Forms.MessageBoxIcon.Question,
				defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
				options: System.Windows.Forms.MessageBoxOptions.RightAlign | System.Windows.Forms.MessageBoxOptions.RtlReading);

			if (result == System.Windows.Forms.DialogResult.Yes)
			{
				System.Windows.Forms.Application.Exit();
			}
		}
	}
}
