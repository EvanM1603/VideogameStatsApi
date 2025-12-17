using VideogameStatsApi.Models;
using VideogameStatsApi.Data;
using Microsoft.EntityFrameworkCore;
using VideogameStatsApi.Dtos;

namespace VideogameStatsApi.Services
{
    public class GameService(AppDbContext context) : IGameService
    {
        // Reference: Updated GameService interface after Dtos - https://youtu.be/RwQVRXEs370?si=akx0K496feaAOHWc&t=3701

        /**
         * Creates a Game
         * */
        public async Task<GameResponse> AddGameAsync(CreateGameRequest game)
        {
            // Create the Game
            var newGame = new Game
            {
                Id = game.GameId,
                Name = game.GameName
            };

            // Add to the Database
            context.Games.Add(newGame);
            await context.SaveChangesAsync();

            // Save to the GameResponse Dto
            return new GameResponse
            {
                Id = newGame.Id,
                Name = game.GameName
            };
        }

        /**
         * Deletes a Game using the Id
         * */
        public async Task<bool> DeleteGameAsync(int id)
        {
            // Check if the Game exists
            var gameToDelete = await context.Games.FindAsync(id);
            if (gameToDelete is null)
                return false;

            // Remove from the Database
            context.Games.Remove(gameToDelete);
            await context.SaveChangesAsync();
            return true;
        }

        /**
         * Gets all Games
         * */
        public async Task<List<GameResponse>> GetAllGamesAsync()
        => await context.Games.Select(g => new GameResponse
            {
                Id = g.Id,
                Name = g.Name,
            }).ToListAsync();

        /**
         * Gets a Game using the Id
         * */
        public async Task<GameResponse?> GetGameByIdAsync(int id)
        {
            var result = await context.Games
                .Where(g => g.Id == id)
                .Select(g => new GameResponse
                {
                    Id = g.Id,
                    Name = g.Name,
                })
                .FirstOrDefaultAsync();
            return result;
        }

        /**
         * Gets a Game using the Name
         * */
        public async Task<GameResponse?> GetGameByNameAsync(string name)
        {
            var result = await context.Games
                .Where(g => g.Name == name)
                .Select(g => new GameResponse
                {
                    Id = g.Id,
                    Name = g.Name,
                })
                .FirstOrDefaultAsync();
            return result;
        }

        /**
        * Updates an existing Game using the Id
        * */
        public async Task<bool> UpdateGameAsync(int id, UpdateGameRequest game)
        {
            // Check if the Game exists
            var existingGame = await context.Games.FindAsync(id);
            if(existingGame is null) 
                return false;

            // Update the Game
            existingGame.Id = game.GameId;
            existingGame.Name = game.GameName;

            // Save the changes
            await context.SaveChangesAsync();
            return true;
        }
    }
}