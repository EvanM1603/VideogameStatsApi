using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using VideogameStatsApi.Data;
using VideogameStatsApi.Dtos;
using VideogameStatsApi.Models;

namespace VideogameStatsApi.Services
{
    public class MatchService(AppDbContext context) : IMatchService
    {
        // Reference: Created MatchService interface after Dtos - https://youtu.be/RwQVRXEs370?si=akx0K496feaAOHWc&t=3701

        /**
         * Creates a Match
         * */
        public async Task<MatchResponse> AddMatchAsync(CreateMatchRequest match)
        {
            // Create the Match
            var newMatch = new Models.Match
            {
                Id = match.MatchId,
                GameId = match.GameId,
                Map = match.Map,
                Result = match.Result
            };

            // Add to the Database
            context.Matches.Add(newMatch);
            await context.SaveChangesAsync();

            // Save to the MatchResponse Dto
            return new MatchResponse
            {
                Id = match.MatchId,
                GameId = match.GameId,
                Map = match.Map,
                Result = match.Result
            };
        }

        /**
         * Deletes a Match using the Id
         * */
        public async Task<bool> DeleteMatchAsync(int id)
        {
            // Check if the Player exists
            var matchToDelete = await context.Matches.FindAsync(id);
            if (matchToDelete is null)
                return false;

            // Remove from the Database
            context.Matches.Remove(matchToDelete);
            await context.SaveChangesAsync();
            return true;
        }

        /**
         * Gets all Matches
         * */
        public async Task<List<MatchResponse>> GetAllMatchesAsync()
        => await context.Matches.Select(m => new MatchResponse
        {
            Id = m.Id,
            GameId = m.GameId,
            Map = m.Map,
            Result = m.Result
        }).ToListAsync();

        /**
         * Gets a Match using the Id
         * */
        public async Task<MatchResponse?> GetMatchByIdAsync(int id)
        {
            var result = await context.Matches
                .Where(m => m.Id == id)
                .Select(m => new MatchResponse
                {
                    Id = m.Id,
                    GameId = m.GameId,
                    Map = m.Map,
                    Result = m.Result
                })
                .FirstOrDefaultAsync();
            return result;
        }

        /**
        * Updates an existing Match using the Id
        * */
        public async Task<bool> UpdateMatchAsync(int id, UpdateMatchRequest match)
        {
            // Check if the Match exists
            var existingMatch = await context.Matches.FindAsync(id);
            if (existingMatch is null)
                return false;

            // Update the Match
            existingMatch.Id = match. MatchId;
            existingMatch.Map = match.Map;
            existingMatch.Result = match.Result;

            // Save the changes
            await context.SaveChangesAsync();
            return true;
        }
    }
}