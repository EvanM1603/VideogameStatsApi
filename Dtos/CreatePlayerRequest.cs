namespace VideogameStatsApi.Dtos
{
    public class CreatePlayerRequest
    {
        public int PlayerId { get; set; }
        public string InGameName { get; set; } = string.Empty;
    }
}