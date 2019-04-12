namespace Dtx.Windows.Forms
{
	public static class MessageBox
	{
		static MessageBox()
		{
		}

		public static void Show(string text)
		{
			System.Windows.Forms.MessageBox.Show
				(text: text,
				caption: "خطا",
				buttons: System.Windows.Forms.MessageBoxButtons.OK,
				icon: System.Windows.Forms.MessageBoxIcon.Error,
				defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
				options: System.Windows.Forms.MessageBoxOptions.RightAlign |
				System.Windows.Forms.MessageBoxOptions.RtlReading);
		}

		public static void ShowError(string text)
		{
			System.Windows.Forms.MessageBox.Show
				(text: text,
				caption: "خطا",
				buttons: System.Windows.Forms.MessageBoxButtons.OK,
				icon: System.Windows.Forms.MessageBoxIcon.Error,
				defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
				options: System.Windows.Forms.MessageBoxOptions.RightAlign |
				System.Windows.Forms.MessageBoxOptions.RtlReading);
		}

		public static void ShowInformation(string text)
		{
			System.Windows.Forms.MessageBox.Show
				(text: text,
				caption: "توضیح",
				buttons: System.Windows.Forms.MessageBoxButtons.OK,
				icon: System.Windows.Forms.MessageBoxIcon.Information,
				defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
				options: System.Windows.Forms.MessageBoxOptions.RightAlign |
				System.Windows.Forms.MessageBoxOptions.RtlReading);
		}
	}
}
