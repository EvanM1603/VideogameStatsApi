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

        public async Task<GameResponse> AddGameAsync(CreateGameRequest game)
        {
            var newGame = new Game
            {
                Id = game.GameId,
                Name = game.GameName
            };

            context.Games.Add(newGame);
            await context.SaveChangesAsync();

            return new GameResponse
            {
                Id = newGame.Id,
                Name = game.GameName
            };
        }

        public async Task<bool> DeleteGameAsync(int id)
        {
            var gameToDelete = await context.Games.FindAsync(id);
            if (gameToDelete is null)
                return false;

            context.Games.Remove(gameToDelete);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<List<GameResponse>> GetAllGamesAsync()
        => await context.Games.Select(x => new GameResponse
            {
                Id = x.Id,
                Name = x.Name,
            }).ToListAsync();

        public async Task<GameResponse> GetGameByIdAsync(int id)
        {
            var result = await context.Games
                .Where(x => x.Id == id)
                .Select(x => new GameResponse
                {
                    Id = x.Id,
                    Name = x.Name,
                })
                .FirstOrDefaultAsync();
            return result;
        }

        public Task<GameResponse> GetGameByNameAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateGameAsync(int id, UpdateGameRequest game)
        {
            var existingGame = await context.Games.FindAsync(id);
            if(existingGame is null) 
                return false;

            existingGame.Id = game.GameId;
            existingGame.Name = game.GameName;

            await context.SaveChangesAsync();
            return true;
        }
    }
}