namespace VideogameStatsApi.Dtos
{
    // DTO used to create a new Player
    public class CreatePlayerRequest
    {
        // The ID of the Player
        public int PlayerId { get; set; }
        // The InGameName of the Player
        public string InGameName { get; set; } = string.Empty;
    }
}