using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UglyTrivia;

namespace Trivia
{
	public class GameConfiguration
	{
		public Game StartSilentGameWithOnePlayer()
		{
			Game game = new SilentGame();
			game.add("Playa'");
			return game;
		}

		class SilentGame : Game
		{
			public SilentGame()
				: base()
			{
			}

			protected override void PrintMessage(string message)
			{
			}
		}
	}
}
