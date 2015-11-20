using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia.GameObjects
{
	public enum QUESTION_CATEGORY {POP, SCIENCE, SPORTS, ROCK};
	class Question
	{
		private QUESTION_CATEGORY category;

		public Question(QUESTION_CATEGORY category)
		{
			this.category = category;
		}
	}
}
