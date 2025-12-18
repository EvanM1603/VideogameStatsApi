using Microsoft.EntityFrameworkCore;
using System;
using VideogameStatsApi.Data;
using VideogameStatsApi.Dtos;
using VideogameStatsApi.Models;

namespace VideogameStatsApi.Services
{
    public class PlayerMatchStatService(AppDbContext context) : IPlayerMatchStatService
    {
        // Reference: Created PlayerMatchStatService interface after Dtos - https://youtu.be/RwQVRXEs370?si=akx0K496feaAOHWc&t=3701

        /**
         * Creates a PlayerMatchStat
         * */
        public async Task<PlayerMatchStatResponse> AddPlayerMatchStatAsync(CreatePlayerMatchStatRequest stat)
        {
            // Create the PlayerMatchStat
            var newStat= new PlayerMatchStat
            {
                Id = stat.PlayerMatchStatId,
                PlayerId = stat.PlayerId,
                MatchId = stat.MatchId,
                TeamNumber = stat.TeamNumber,
                Kills = stat.Kills,
                Deaths = stat.Deaths,
                Assists = stat.Assists
            };

            // Add to the Database
            context.PlayerMatchStats.Add(newStat);
            await context.SaveChangesAsync();

            // Save to the PlayerMatchStatResponse Dto
            return new PlayerMatchStatResponse
            {
                PlayerId = newStat.PlayerId,
                MatchId = newStat.MatchId,
                TeamNumber = newStat.TeamNumber,
                Kills = newStat.Kills,
                Deaths = newStat.Deaths,
                Assists = newStat.Assists
            };
        }

        /**
         * Deletes a PlayerMatchStat using the Id
         * */
        public async Task<bool> DeletePlayerMatchStatAsync(int id)
        {
            // Check if the PlayerMatchStat exists
            var statToDelete = await context.PlayerMatchStats.FindAsync(id);
            if (statToDelete is null)
                return false;

            // Remove from the Database
            context.PlayerMatchStats.Remove(statToDelete);
            await context.SaveChangesAsync();
            return true;
        }

        /**
         * Gets all PlayerMatchStats
         * */
        public async Task<List<PlayerMatchStatResponse>> GetAllPlayerMatchStatsAsync()
        => await context.PlayerMatchStats.Select(s => new PlayerMatchStatResponse
        {
            Id = s.Id,
            PlayerId = s.PlayerId,
            MatchId = s.MatchId,
            TeamNumber = s.TeamNumber,
            Kills = s.Kills,
            Deaths = s.Deaths,
            Assists = s.Assists,
        }).ToListAsync();

        /**
         * Gets a PlayerMatchStat using the Id
         * */
        public async Task<PlayerMatchStatResponse?> GetPlayerMatchStatByIdAsync(int id)
        {
            var result = await context.PlayerMatchStats
                .Where(s => s.Id == id)
                .Select(s => new PlayerMatchStatResponse
                {
                    Id = s.Id,
                    PlayerId = s.PlayerId,
                    MatchId = s.MatchId,
                    TeamNumber = s.TeamNumber,
                    Kills = s.Kills,
                    Deaths = s.Deaths,
                    Assists = s.Assists,
                })
                .FirstOrDefaultAsync();
            return result;
        }

        /**
        * Updates an existing PlayerMatchStat using the Id
        * */
        public async Task<bool> UpdatePlayerMatchStatAsync(int id, UpdatePlayerMatchStatRequest stat)
        {
            // Check if the PlayerMatchStat exists
            var existingStat = await context.PlayerMatchStats.FindAsync(id);
            if (existingStat is null)
                return false;

            // Update the PlayerMatchStat
            existingStat.TeamNumber = stat.TeamNumber;
            existingStat.Kills = stat.Kills;
            existingStat.Deaths = stat.Deaths;
            existingStat.Assists = stat.Assists;

            // Save the changes
            await context.SaveChangesAsync();
            return true;
        }
    }
}