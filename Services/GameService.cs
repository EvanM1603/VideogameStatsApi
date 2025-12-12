using VideogameStatsApi.Models;

// Last working on this

namespace VideogameStatsApi.Services
{
    public class GameService : IGameService
    {
        // Reference: Created GameService - https://youtu.be/RwQVRXEs370?si=N1sEu7UzYicQTNFa&t=1885

        public Task<Game> AddGameAsync(Game game)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteGameAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Game>> GetAllGamesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Game> GetGameByIdAsync(int id)
        {
            throw new NotImplementedException();
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