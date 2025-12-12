using VideogameStatsApi.Models;
using VideogameStatsApi.Data;
using Microsoft.EntityFrameworkCore;

// Last working on this

namespace VideogameStatsApi.Services
{
    public class GameService(AppDbContext context) : IGameService
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

        public async Task<List<Game>> GetAllGamesAsync()
        => await context.Games.ToListAsync();

        public async Task<Game?> GetGameByIdAsync(int id)
        {
            var result = await context.Games.FindAsync(id);
            return result;
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