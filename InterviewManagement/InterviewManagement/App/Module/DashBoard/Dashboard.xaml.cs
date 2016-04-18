using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace InterviewManagement
{
	public partial class Dashboard : ContentPage
	{
		public ObservableCollection<Question> Questions {
			get;
			set;
		}

		public Dashboard ()
		{
			Questions = new ObservableCollection<Question> ();
			InitializeComponent ();
			PopulatePickers (Technology, new string[]{ "Asp.net", "C#", "Javascript", "Angular" });
			PopulatePickers (Level, new string[]{ "Expert", "Intermediate", "Fresher", "Dirt bag" });
			BindingContext = this;

		}

		public void OnLogout (object o, EventArgs e)
		{
			App.IsLogedIn = false;
			Navigation.PushModalAsync (new Login ());
		}

		private void PopulatePickers (Picker p, string[] d)
		{
			foreach (var i in d) {
				p.Items.Add (i);
			}
		}

		public void OnTechnologyChange (object o, EventArgs e)
		{
			var techology = o as Picker;
			Level.IsEnabled = techology.SelectedIndex > -1;
		}

		public void OnLevelChange (object o, EventArgs e)
		{
			var level = o as Picker;
			if (level.SelectedIndex > -1) {
				//var format = "Yo have selected {0} technology at {1} level";
				//DisplayAlert(string.Format(format),Technology.GetValue() );
				Questions = Stub.LoadQuestions (10);
				QuestionList.IsVisible = true;
				QuestionList.ItemsSource = Questions;
			}
		}

		public void OnQuestionTapped (object o, ItemTappedEventArgs e)
		{
			var question = o as Question;
			Navigation.PushModalAsync (new QuestionDetail (question));
		}


	}
}

