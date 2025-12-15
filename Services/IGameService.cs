using VideogameStatsApi.Dtos;
using VideogameStatsApi.Models;

namespace VideogameStatsApi.Services
{
    public interface IGameService
    {
        //Reference: Created IGameService interface - https://youtu.be/RwQVRXEs370?si=XXQ2R4h35wMRBZRf&t=1854 

        Task<List<GameResponse>> GetAllGamesAsync();
        Task<GameResponse?> GetGameByIdAsync(int id);
        Task<GameResponse> GetGameByNameAsync();
        Task<GameResponse> AddGameAsync(CreateGameRequest game);
        Task<bool> UpdateGameAsync(int id, UpdateGameRequest game);
        Task<bool> DeleteGameAsync(int id);

    }
}