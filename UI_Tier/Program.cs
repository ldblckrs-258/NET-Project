using Bus_Tier;
using Models;

namespace UI_Tier
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		/// 

		public static DisplayUser CurrentUser { get; set; }

		private static void GetCurrentUserData()
		{
			int userId = BSStore.LoadUser();
			if (userId != 0)
			{
				BSUser bsu = new();
				DisplayUser user = bsu.GetUser(userId);
				if (user == null)
				{
					MessageBox.Show("User not found. Please login again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					CurrentUser = user;
				}
			}
		}

		[STAThread]
		static void Main()
		{
			GetCurrentUserData();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			ApplicationConfiguration.Initialize();
			if (CurrentUser != null)
			{
				Application.Run(new MainForm());
			}
			else
			{
				Application.Run(new LoginForm());
			}
		}
	}
}