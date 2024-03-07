using GameStore.Models;

namespace GameStore.DataAccess
{
    public class GameClient
    {
        private static readonly List<Game> games = new()
        {
            new Game()
            {
                Id = 1,
                Name = "Street Fighter",
                Genre = "Fighting",
                Price = 19.99M,
                ReleasedDate = new DateTime(1991,1,1)
            },
            new Game()
            {
                Id = 2,
                Name = "Final Fantasy",
                Genre = "Roleplaying",
                Price = 29.99M,
                ReleasedDate = new DateTime(2002,5,1)
            },
            new Game()
            {
                Id = 3,
                Name = "Fifa 2024",
                Genre = "Roleplaying",
                Price = 29.99M,
                ReleasedDate = new DateTime(2024,2,24)
            } 
        };

        public static Game[] GetGames()
        {
            return games.ToArray();
        }
        public static void AddGame(Game game)
        {
            game.Id = games.Count + 1;
            games.Add(game);
        }
        public static Game GetGame(int id)
        {
            return games.Find(x => x.Id == id) ?? throw new Exception("Could not find the game!");
        }
        public static void UpdateGame(Game updatedGame)
        {
            Game existingGame = GetGame(updatedGame.Id);
            existingGame.Name = updatedGame.Name;
            existingGame.Genre = updatedGame.Genre;
            existingGame.Price = updatedGame.Price;
            existingGame.ReleasedDate = updatedGame.ReleasedDate;
        }
        public static void DeleteGame(int Id)
        {
            Game deletegame = GetGame(Id);
            games.Remove(deletegame);
        }

    }

    
}