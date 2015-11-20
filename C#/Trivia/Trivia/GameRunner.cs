using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using UglyTrivia;

namespace Trivia
{
    public class GameRunner
    {

        private static bool notAWinner;
		static FileStream ostrm;
		static StreamWriter writer;

	    public static void Main(String[] args)
	    {
		    int seed = 5678;

		    for (int i = 0; i < 10000; i++)
		    {
				int mySeed = seed + i * 313;
				CreateFile(i, mySeed);

			    Game aGame = new Game();

			    aGame.add("Chet");
			    aGame.add("Pat");
			    aGame.add("Sue");
			    try
			    {
				    Random rand = new Random(mySeed);

				    do
				    {
					    aGame.roll(rand.Next(5) + 1);

					    if (rand.Next(9) == 7)
					    {
						    notAWinner = aGame.wrongAnswer();
					    }
					    else
					    {
						    notAWinner = aGame.wasCorrectlyAnswered();
					    }
				    } while (notAWinner);
			    }
			    catch (Exception ex)
			    {
				    Console.WriteLine(ex);
			    }
				CloseStream();
		    }
	    }


	    static void CloseStream()
	    {
			writer.Close();
			ostrm.Close();
	    }

	    static void CreateFile(int index, int seed)
	    {
			try
			{
				ostrm = new FileStream(string.Format("../../GoldenMaster/Game{0}_{1}.txt", index, seed), FileMode.OpenOrCreate, FileAccess.Write);
				writer = new StreamWriter(ostrm);
				Console.SetOut(writer);

			}
			catch (Exception e)
			{
				Console.WriteLine("Cannot open Redirect.txt for writing");
				Console.WriteLine(e.Message);
			}
	    }
    }

}

