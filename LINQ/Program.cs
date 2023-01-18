using System.Linq;

namespace LINQ
{
    //class VideoGame
    //{
    //    public string Name { get; set; }
    //}

    class Program
    {
        static void Main(string[] args)
        {

            var games = new List<string>() 
            { "Super Mario Bros.",
                "The Legend of Zelda",
                "Minecraft",
                "Super Smash Bros. Melee",
                "Hades"
            };
           
            var gamesListOrdered = games.OrderBy(x => x.Length);
            foreach(var game in gamesListOrdered)
            {
                Console.WriteLine(game);  
            }


            //    List<VideoGame> games = new List<VideoGame>
            //{
            //    new VideoGame { Name = "Super Mario Bros." },
            //    new VideoGame { Name = "The Legend of Zelda" },
            //    new VideoGame { Name = "Tetris" },
            //    new VideoGame { Name = "Minecraft" },
            //    new VideoGame { Name = "Final Fantasy VII" },
            //};

            //    var orderedGames = OrderGamesByNameLength(games);

            //    foreach (var game in orderedGames)
            //    {
            //        Console.WriteLine(game.Name);
            //    }
            //}

            //static List<VideoGame> OrderGamesByNameLength(List<VideoGame> games)
            //{
            //    return games.OrderBy(g => g.Name.Length).ToList();
            //}
        }
    }
}




