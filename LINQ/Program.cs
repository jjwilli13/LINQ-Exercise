using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<string> myGames = new List<string>() { "NFL Blitz 2000", "Spiderman", "MLB The Show", "Tomb Raider", "Donkey Kong" };

            IEnumerable<string> games = myGames.OrderBy(myGames => myGames.Length);



            foreach (var game in games)
            {
                Console.WriteLine(game);
            }
            



        }
    }
}