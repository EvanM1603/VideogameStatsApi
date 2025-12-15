namespace VideogameStatsApi.Dtos
{
    public class UpdatePlayerRequest
    {
        public int PlayerId { get; set; }
        public string InGameName { get; set; } = string.Empty;
    }
}