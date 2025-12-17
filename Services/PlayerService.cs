using Microsoft.EntityFrameworkCore;
using VideogameStatsApi.Data;
using VideogameStatsApi.Dtos;
using VideogameStatsApi.Models;

namespace VideogameStatsApi.Services
{
    public class PlayerService(AppDbContext context) : IPlayerService
    {
        // Reference: Created PlayerService - https://youtu.be/RwQVRXEs370?si=N1sEu7UzYicQTNFa&t=1885

        /**
         * Creates a Player
         * */
        public async Task<PlayerResponse> AddPlayerAsync(CreatePlayerRequest player)
        {
            // Create the Player
            var newPlayer = new Player
            {
                Id = player.PlayerId,
                InGameName = player.InGameName
            };

            // Add to the Database
            context.Players.Add(newPlayer);
            await context.SaveChangesAsync();

            // Save to the PlayerResponse Dto
            return new PlayerResponse
            {
                Id = newPlayer.Id,
                InGameName = newPlayer.InGameName
            };
        }

        /**
         * Deletes a Player using the Id
         * */
        public async Task<bool> DeletePlayerAsync(int id)
        {
            // Check if the Player exists
            var playerToDelete = await context.Players.FindAsync(id);
            if (playerToDelete is null)
                return false;

            // Remove from the Database
            context.Players.Remove(playerToDelete);
            await context.SaveChangesAsync();
            return true;
        }

        /**
         * Gets all Players
         * */
        public async Task<List<PlayerResponse>> GetAllPlayersAsync()
        => await context.Players.Select(p => new PlayerResponse
        {
            Id = p.Id,
            InGameName = p.InGameName,
        }).ToListAsync();

        /**
         * Gets a Player using the Id
         * */
        public async Task<PlayerResponse?> GetPlayerByIdAsync(int id)
        {
            var result = await context.Players
                .Where(p => p.Id == id)
                .Select(p => new PlayerResponse
                {
                    Id = p.Id,
                    InGameName = p.InGameName,
                })
                .FirstOrDefaultAsync();
            return result;
        }

        /**
         * Gets a Player using the InGameName
         * */
        public async Task<PlayerResponse?> GetPlayerByInGameNameAsync(string inGameName)
        {
            var result = await context.Players
                .Where(p => p.InGameName == inGameName)
                .Select(p => new PlayerResponse
                {
                    Id = p.Id,
                    InGameName = p.InGameName,
                })
                .FirstOrDefaultAsync();
            return result;
        }

        /**
        * Updates an existing Player using the Id
        * */
        public async Task<bool> UpdatePlayerAsync(int id, UpdatePlayerRequest player)
        {
            // Check if the Player exists
            var existingPlayer = await context.Players.FindAsync(id);
            if (existingPlayer is null)
                return false;

            // Update the Player
            existingPlayer.Id = player.PlayerId;
            existingPlayer.InGameName = player.InGameName;

            // Save the changes
            await context.SaveChangesAsync();
            return true;
        }
    }
}