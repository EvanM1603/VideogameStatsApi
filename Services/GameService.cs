using VideogameStatsApi.Models;

// Last working on this

namespace VideogameStatsApi.Services
{
    public class GameService : IGameService
    {
        // Reference: Created GameService - https://youtu.be/RwQVRXEs370?si=N1sEu7UzYicQTNFa&t=1885

        //Reference: Moved test data to Service -  https://youtu.be/RwQVRXEs370?si=DwAX1WHKcdHjEZcH&t=1906

        static List<Game> games = new List<Game>{
            new Game { Id = 1, Name = "Valorant" },
            new Game { Id = 2, Name = "Rainbow Six Siege" },
            new Game { Id = 3, Name = "CS:GO" }
        };


        public Task<Game> AddGameAsync(Game game)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteGameAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Game>> GetAllGamesAsync()
        => await Task.FromResult(games);

        public async Task<Game?> GetGameByIdAsync(int id)
        {
            var result = games.FirstOrDefault(x => x.Id == id);
            return await Task.FromResult(result);
        }

        public Task<Game> GetGameByNameAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateGameAsync(int id, Game game)
        {
            throw new NotImplementedException();
        }
    }
}