namespace VideogameStatsApi.Dtos
{
    // The DTO returned when reading Player Data
    public class PlayerResponse
    {
        // The ID of the Player
        public int Id { get; set; }
        // The InGameName of the Player
        public string InGameName { get; set; } = string.Empty;
    }
}