using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trivia;
using UglyTrivia;

namespace TriviaTest
{
	[TestClass]
	public class RollDiceTest
	{
		[TestMethod]
		public void Four()
		{
			Game undertest = new GameConfiguration().StartGame(delegate { }, "ad");
			undertest.roll(4);
		}
	}
}
