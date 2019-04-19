namespace Infrastructure
{
	public partial class BaseForm : Dtx.Windows.Forms.BaseForm
	{
		public BaseForm()
		{
			InitializeComponent();

			// Solution (3)
			//MyDatabaseContext =
			//	new Models.DatabaseContext();
		}

		// **************************************************
		/// <summary>
		/// Note: Wrong Usage!
		/// </summary>
		//private Models.DatabaseContext myDatabaseContext;
		// **************************************************

		// **************************************************
		/// <summary>
		/// Note: Not Recommended!
		/// </summary>
		//public Models.DatabaseContext MyDatabaseContext;
		// **************************************************

		// **************************************************
		/// <summary>
		/// Solution (1)
		/// </summary>
		//protected Models.DatabaseContext MyDatabaseContext;
		// **************************************************

		// **************************************************
		/// <summary>
		/// Solution (2)
		/// </summary>
		//protected Models.DatabaseContext MyDatabaseContext = new Models.DatabaseContext();
		// **************************************************

		// **************************************************
		/// <summary>
		/// Solution (3)
		/// </summary>
		//protected Models.DatabaseContext MyDatabaseContext;
		// **************************************************

		//// **************************************************
		///// <summary>
		///// Solution (4)
		///// </summary>
		//private Models.DatabaseContext myDatabaseContext;

		///// <summary>
		///// Lazy Loading = Lazy Initialization
		///// </summary>
		//protected Models.DatabaseContext MyDatabaseContext
		//{
		//	get
		//	{
		//		if (myDatabaseContext == null)
		//		{
		//			myDatabaseContext =
		//				new Models.DatabaseContext();
		//		}

		//		return myDatabaseContext;
		//	}
		//}
		//// **************************************************
	}
}
