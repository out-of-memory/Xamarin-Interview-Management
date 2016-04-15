using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace InterviewManagement
{
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}
	
		public void OnLogin(object o, EventArgs e)
		{
			App.IsLogedIn = true;
			Navigation.PushModalAsync (new Dashboard ());
		}
	}




}

