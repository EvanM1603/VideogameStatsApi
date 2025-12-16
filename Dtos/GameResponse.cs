namespace VideogameStatsApi.Dtos
{
    // The DTO returned when reading Game Data
    public class GameResponse
    {
        // The ID of the Game
        public int Id { get; set; }
        // The Name of the Game
        public string Name { get; set; } = string.Empty;
    }
}