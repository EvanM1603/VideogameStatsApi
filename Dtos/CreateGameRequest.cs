namespace VideogameStatsApi.Dtos
{
    // DTO used to create a new Game
    public class CreateGameRequest
    {
        // The ID of the Game
        public int GameId { get; set; } 
        // The Name of the Game
        public string GameName { get; set; }= string.Empty;
    }
}