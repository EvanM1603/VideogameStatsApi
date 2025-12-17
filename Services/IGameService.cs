using VideogameStatsApi.Dtos;

namespace VideogameStatsApi.Services
{
    public interface IGameService
    {
        //Reference: Created IGameService interface - https://youtu.be/RwQVRXEs370?si=XXQ2R4h35wMRBZRf&t=1854 

        /**
         * Gets all Games
         * */
        Task<List<GameResponse>> GetAllGamesAsync();

        /**
         * Gets a Game using the Id
         * */
        Task<GameResponse?> GetGameByIdAsync(int id);

        /**
         * Gets a Game using the Name
         * */
        Task<GameResponse?> GetGameByNameAsync(string name);

        /**
        * Creates a Game
        * */
        Task<GameResponse> AddGameAsync(CreateGameRequest game);

        /**
        * Updates an existing Game using the Id
        * */
        Task<bool> UpdateGameAsync(int id, UpdateGameRequest game);

        /**
        * Deletes a Game using the Id
        * */
        Task<bool> DeleteGameAsync(int id);

    }
}