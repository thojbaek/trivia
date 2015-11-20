using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UglyTrivia;

namespace Trivia
{
	public class GameConfiguration
	{
		public Game StartGame(Action<string> eventDelegate, params string[] players)
		{
			Game game = new Game(eventDelegate);
			foreach (var player in players)
			{
				game.add(player);
			}
			return game;
		}
	}
}
