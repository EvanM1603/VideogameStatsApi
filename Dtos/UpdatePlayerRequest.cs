namespace VideogameStatsApi.Dtos
{
    // DTO used to update an existing Player
    public class UpdatePlayerRequest
    {
        // The ID of the Player
        public int PlayerId { get; set; }
        // The InGameName of the Player
        public string InGameName { get; set; } = string.Empty;
    }
}