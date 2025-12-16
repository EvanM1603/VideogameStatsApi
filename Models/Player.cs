namespace VideogameStatsApi.Models
{
    // Represents a Player
    public class Player
    {
        // Primary Key for the Player Table
        public int Id { get; set; }
        // The InGameName of the Player
        public string InGameName { get; set; } = string.Empty;
        // Each Player can have stats in many Matches
        public ICollection<PlayerMatchStat> PlayerMatchStats { get; set; } = new List<PlayerMatchStat>();
    }
}