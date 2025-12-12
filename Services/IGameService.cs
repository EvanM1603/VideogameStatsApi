using VideogameStatsApi.Models;

namespace VideogameStatsApi.Services
{
    public interface IGameService
    {
        //Reference: Created IGameService interface - https://youtu.be/RwQVRXEs370?si=XXQ2R4h35wMRBZRf&t=1854 

        Task<List<Game>> GetAllGamesAsync();
        Task<Game> GetGameByIdAsync(int id);
        Task<Game> GetGameByNameAsync();
        Task<Game> AddGameAsync(Game game);
        Task<bool> UpdateGameAsync(int id, Game game);
        Task<bool> DeleteGameAsync(int id);

    }
}