using VideogameStatsApi.Dtos;

namespace VideogameStatsApi.Services
{
    public interface IMatchService
    {
        //Reference: Created IMatchService interface after Dtos - https://youtu.be/RwQVRXEs370?si=0Ca3ZfxYzS5fOH5J&t=3687

        /**
         * Gets all Matches
         * */
        Task<List<MatchResponse>> GetAllMatchesAsync();

        /**
         * Gets a Match using the Id
         * */
        Task<MatchResponse?> GetMatchByIdAsync(int id);

        /**
        * Creates a Match
        * */
        Task<MatchResponse> AddMatchAsync(CreateMatchRequest match);

        /**
        * Updates an existing Match using the Id
        * */
        Task<bool> UpdateMatchAsync(int id, UpdateMatchRequest match);

        /**
        * Deletes a Match using the Id
        * */
        Task<bool> DeleteMatchAsync(int id);
    }
}