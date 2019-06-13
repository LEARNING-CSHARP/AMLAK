namespace Infrastructure
{
	public static class Utility
	{
		static Utility()
		{
		}

		#region Exit
		public static void Exit()
		{
			System.Windows.Forms.DialogResult result;

			result = System.Windows.Forms.MessageBox.Show(text: "آیا قصد خروج از برنامه را دارید؟", caption: "خروج",
				buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
				icon: System.Windows.Forms.MessageBoxIcon.Question,
				defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
				options: System.Windows.Forms.MessageBoxOptions.RightAlign | System.Windows.Forms.MessageBoxOptions.RtlReading);

			if (result == System.Windows.Forms.DialogResult.Yes)
			{
				System.Windows.Forms.Application.Exit();
			}
		}
		#endregion /Exit

		#region ShowWithNameMonthPersianCalenda
		/// <summary>
		/// 
		/// </summary>
		/// <param name="dateTime">Parametr of Date</param>
		/// <returns></returns>
		public static string ShowWithNameMonthPersianCalenda(System.DateTime dateTime)
		{
			string persianMonth = string.Empty;

			System.Globalization.PersianCalendar persianCalendar =
				new System.Globalization.PersianCalendar();

			int year = persianCalendar.GetYear(dateTime);
			int month = persianCalendar.GetMonth(dateTime);
			int day = persianCalendar.GetDayOfMonth(dateTime);

			switch (month)
			{
				case 1:
					persianMonth = "فروردین";
					break;

				case 2:
					persianMonth = "اردیبهشت";
					break;

				case 3:
					persianMonth = "خرداد";
					break;

				case 4:
					persianMonth = "تیر";
					break;

				case 5:
					persianMonth = "مرداد";
					break;

				case 6:
					persianMonth = "شهریور";
					break;

				case 7:
					persianMonth = "مهر";
					break;

				case 8:
					persianMonth = "آبان";
					break;

				case 9:
					persianMonth = "آذر";
					break;

				case 10:
					persianMonth = "دی";
					break;

				case 11:
					persianMonth = "بهمن";
					break;

				case 12:
					persianMonth = "اسفند";
					break;

				default:
					break;
			}

			string showCalendar =
				day.ToString().PadLeft(2, '0') + " / " +
				persianMonth + " / " +
				year.ToString();
			return showCalendar;

		}
		#endregion /ShowWithNameMonthPersianCalenda

		#region ShowWithoutNameMonthPersianCalenda

		public static string ShowWithOutNameMonthPersianCalenda(System.DateTime dateTime)
		{
			System.Globalization.PersianCalendar persianCalendar =
				new System.Globalization.PersianCalendar();

			int year = persianCalendar.GetYear(dateTime);
			int month = persianCalendar.GetMonth(dateTime);
			int day = persianCalendar.GetDayOfMonth(dateTime);

			string showCalendar =
				year.ToString() + "/" +
				month.ToString().PadLeft(2, '0') + "/" +
				day.ToString().PadLeft(2, '0');

			return showCalendar;

		}
		#endregion / ShowWithoutNameMonthPersianCalenda
	}
}
