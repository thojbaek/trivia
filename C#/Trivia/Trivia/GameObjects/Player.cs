using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia.GameObjects
{
	class Player
	{
		private string name;
		private int purse;
		private bool isGettingOutOfPenaltyBox = true;

		private Random rand = new Random();

		public Player(string name)
		{
			this.name = name;
		}

		/**
		 Returns true if the player answers correctly, otherwise false
		 */
		public bool AnswerQuestion(Question q)
		{
			return rand.Next(9) != 7;
		}
	}
}
