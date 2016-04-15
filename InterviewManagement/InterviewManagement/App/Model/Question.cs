using System;

namespace InterviewManagement
{
	public class Question
	{
		public int ID {	get; set; }

		public string Description {	get; set; }

		public string[] Answers {	get; set; }

		public int Correct { get; set; }

		public bool AddedToFav{	get; set; }

	}
}

