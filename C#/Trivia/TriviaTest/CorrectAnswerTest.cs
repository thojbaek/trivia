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
		public void OnePlayer()
		{
			Game game = new GameConfiguration().StartGame(delegate { }, "player");

			var actual = game.wasCorrectlyAnswered();

			Assert.AreEqual(true, actual);
		}

		[TestMethod]
		public void ThreePlayers()
		{
			Game game = new GameConfiguration().StartGame(delegate { }, "p1", "p2", "p3");

			var actual = game.wasCorrectlyAnswered();

			Assert.AreEqual(true, actual);
		}
	}
}
