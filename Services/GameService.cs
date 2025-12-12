using VideogameStatsApi.Models;
using VideogameStatsApi.Data;
using Microsoft.EntityFrameworkCore;
using VideogameStatsApi.Dtos;

// Last working on this

namespace VideogameStatsApi.Services
{
    public class GameService(AppDbContext context) : IGameService
    {
        // Reference: Created GameService - https://youtu.be/RwQVRXEs370?si=N1sEu7UzYicQTNFa&t=1885

        public Task<GameDto> AddGameAsync(Game game)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteGameAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GameDto>> GetAllGamesAsync()
        => await context.Games.Select(x => new GameDto
            {
                Id = x.Id,
                Name = x.Name,
            }).ToListAsync();

        public async Task<GameDto> GetGameByIdAsync(int id)
        {
            var result = await context.Games
                .Where(x => x.Id == id)
                .Select(x => new GameDto
                {
                    Id = x.Id,
                    Name = x.Name,
                })
                .FirstOrDefaultAsync();
            return result;
        }

        public Task<GameDto> GetGameByNameAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateGameAsync(int id, Game game)
        {
            throw new NotImplementedException();
        }
    }
}