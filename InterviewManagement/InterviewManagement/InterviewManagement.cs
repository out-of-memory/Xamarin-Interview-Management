using System;

using Xamarin.Forms;

namespace InterviewManagement
{
	public class App : Application
	{
		public static bool IsLogedIn{ get; set;}
        static SQLiteDatabase database;

		public App ()
		{
            IsLogedIn = createUserLoginSession();

            if (!IsLogedIn)
                MainPage = new Login();
			else
				MainPage = new Dashboard();
		}

        public static SQLiteDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new SQLiteDatabase();
                }
                return database;
            }
        }

        public static bool createUserLoginSession()
        {
            return App.Database.IsDeviceAuthenticated();
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

