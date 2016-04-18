using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace InterviewManagement
{
	public partial class QuestionDetail : ContentPage
	{
		public Question CurrentQuestion {
			get;
			set;
		}

		public QuestionDetail (Question question)
		{
			this.CurrentQuestion = question;
			InitializeComponent ();
		}
	}
}

