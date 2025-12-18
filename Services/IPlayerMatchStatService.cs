using VideogameStatsApi.Dtos;

namespace VideogameStatsApi.Services
{
    //Reference: Created IPlayerMatchStatService interface after Dtos - https://youtu.be/RwQVRXEs370?si=0Ca3ZfxYzS5fOH5J&t=3687
    public interface IPlayerMatchStatService
    {
        /**
         * Gets all PlayerMatchStats
         * */
        Task<List<PlayerMatchStatResponse>> GetAllPlayerMatchStatsAsync();

        /**
         * Gets a PlayerMatchStat using the Id
         * */
        Task<PlayerMatchStatResponse?> GetPlayerMatchStatByIdAsync(int id);

        /**
        * Creates a PlayerMatchStat
        * */
        Task<PlayerMatchStatResponse> AddPlayerMatchStatAsync(CreatePlayerMatchStatRequest stat);

        /**
        * Updates an existing PlayerMatchStat using the Id
        * */
        Task<bool> UpdatePlayerMatchStatAsync(int id, UpdatePlayerMatchStatRequest stat);

        /**
        * Deletes a PlayerMatchStat using the Id
        * */
        Task<bool> DeletePlayerMatchStatAsync(int id);
    }
}