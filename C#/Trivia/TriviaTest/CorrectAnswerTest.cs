using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trivia;
using UglyTrivia;

namespace TriviaTest
{
	[TestClass]
	public class CorrectAnswerTest
	{
		[TestMethod]
		public void CorrectAnswer()
		{
			Game game = new GameConfiguration().StartSilentGameWithOnePlayer();
			game.wasCorrectlyAnswered();
		}
	}
}
