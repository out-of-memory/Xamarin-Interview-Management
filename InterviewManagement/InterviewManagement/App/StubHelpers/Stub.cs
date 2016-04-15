using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace InterviewManagement
{
	public static class Stub
	{
		public static ObservableCollection<Question> LoadQuestions (int count)
		{


			ObservableCollection<Question> questions = new ObservableCollection<Question> ();

			for (var i = 0; i < count; i++) {
				questions.Add (new Question {
					ID = i + 1000,
					Description = "This is a really nice question and you should not be able to answer! How about that?",
					Answers = new string[]{ "abc", "def", "pqr", "xyz" },
					Correct = (new Random ()).Next (0, 3),
					AddedToFav = false
				});
			}

			return questions;
		}
	}
}

