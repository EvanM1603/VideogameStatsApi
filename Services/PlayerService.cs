using Microsoft.EntityFrameworkCore;
using VideogameStatsApi.Data;
using VideogameStatsApi.Dtos;
using VideogameStatsApi.Models;

namespace VideogameStatsApi.Services
{
    public class PlayerService(AppDbContext context) : IPlayerService
    {
        // Reference: Created PlayerService - https://youtu.be/RwQVRXEs370?si=N1sEu7UzYicQTNFa&t=1885

        // Add
        public async Task<PlayerResponse> AddPlayerAsync(CreatePlayerRequest player)
        {
            var newPlayer = new Player
            {
                Id = player.PlayerId,
                InGameName = player.InGameName
            };

            context.Players.Add(newPlayer);
            await context.SaveChangesAsync();

            return new PlayerResponse
            {
                Id = newPlayer.Id,
                InGameName = newPlayer.InGameName
            };
        }

        // Delete
        public async Task<bool> DeletePlayerAsync(int id)
        {
            var playerToDelete = await context.Players.FindAsync(id);
            if (playerToDelete is null)
                return false;

            context.Players.Remove(playerToDelete);
            await context.SaveChangesAsync();
            return true;
        }

        // Get all
        public async Task<List<PlayerResponse>> GetAllPlayersAsync()
        => await context.Players.Select(p => new PlayerResponse
        {
            Id = p.Id,
            InGameName = p.InGameName,
        }).ToListAsync();

        // Get by Id
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

        // Get by InGameName
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

        // Update
        public async Task<bool> UpdatePlayerAsync(int id, UpdatePlayerRequest player)
        {
            var existingPlayer = await context.Players.FindAsync(id);
            if (existingPlayer is null)
                return false;

            existingPlayer.Id = player.PlayerId;
            existingPlayer.InGameName = player.InGameName;

            await context.SaveChangesAsync();
            return true;
        }
    }
}