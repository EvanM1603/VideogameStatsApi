namespace VideogameStatsApi.Dtos
{
    // DTO used to update an existing Game
    public class UpdateGameRequest
    {
        // The ID of the Game
        public int GameId { get; set; }
        // The Name of the Game
        public string GameName { get; set; } = string.Empty;
    }
}