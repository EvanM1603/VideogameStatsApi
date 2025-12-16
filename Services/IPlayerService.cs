using VideogameStatsApi.Dtos;

namespace VideogameStatsApi.Services
{
    public interface IPlayerService
    {
        //Reference: Created IPlayerService interface - https://youtu.be/RwQVRXEs370?si=XXQ2R4h35wMRBZRf&t=1854 
        // Used the IGameService to help create this

        Task<List<PlayerResponse>> GetAllPlayersAsync();
        Task<PlayerResponse?> GetPlayerByIdAsync(int id);
        Task<PlayerResponse?> GetPlayerByInGameNameAsync(string inGameName);
        Task<PlayerResponse> AddPlayerAsync(CreatePlayerRequest player);
        Task<bool> UpdatePlayerAsync(int id, UpdatePlayerRequest player);
        Task<bool> DeletePlayerAsync(int id);
    }
}