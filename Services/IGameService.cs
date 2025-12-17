using VideogameStatsApi.Dtos;

namespace VideogameStatsApi.Services
{
    public interface IGameService
    {
        //Reference: Updated IGameService interface after Dtos - https://youtu.be/RwQVRXEs370?si=0Ca3ZfxYzS5fOH5J&t=3687

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