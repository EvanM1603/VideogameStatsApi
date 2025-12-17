using VideogameStatsApi.Dtos;

namespace VideogameStatsApi.Services
{
    public interface IPlayerService
    {
        //Reference: Updated IPlayerService interface after Dtos - https://youtu.be/RwQVRXEs370?si=0Ca3ZfxYzS5fOH5J&t=3687

        /**
         * Gets all Players
         * */
        Task<List<PlayerResponse>> GetAllPlayersAsync();

        /**
         * Gets a Player using the Id
         * */
        Task<PlayerResponse?> GetPlayerByIdAsync(int id);

        /**
         * Gets a Player using the InGameName
         * */
        Task<PlayerResponse?> GetPlayerByInGameNameAsync(string inGameName);

        /**
        * Creates a Player
        * */
        Task<PlayerResponse> AddPlayerAsync(CreatePlayerRequest player);

        /**
        * Updates an existing Player using the Id
        * */
        Task<bool> UpdatePlayerAsync(int id, UpdatePlayerRequest player);

        /**
        * Deletes a Player using the Id
        * */
        Task<bool> DeletePlayerAsync(int id);
    }
}