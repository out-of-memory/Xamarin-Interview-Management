using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace InterviewManagement
{
	public partial class Login : ContentPage
	{
        public Login()
		{
			InitializeComponent ();
		}
	
		public void OnLogin(object o, EventArgs e)
		{
            var items = new User
            {
                UserName = UserName.Text,
                Password = Password.Text,
                AuthToken = Guid.NewGuid().ToString()
            };
            bool userLogin = App.Database.Login(items);
            if (userLogin)
            {
                Navigation.PushModalAsync(new Dashboard());
            }
            else
            {
                DisplayAlert("Error", "Kindly re-enter UserName and Password", "OK");
            }
            UserName.Text = "";
            Password.Text = "";
		}
	}
}

