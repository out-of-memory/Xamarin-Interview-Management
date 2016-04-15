using System;

using Xamarin.Forms;

namespace InterviewManagement
{
	public class App : Application
	{
		public static bool IsLogedIn{ get; set;}
		public App ()
		{
			if(!IsLogedIn)
				MainPage = new Login();
			else
				MainPage = new Dashboard();
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

