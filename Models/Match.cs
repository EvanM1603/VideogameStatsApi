namespace VideogameStatsApi.Models
{
    // Represents a Match
    public class Match
    {
        // Primary Key for the Match Table
        public int Id { get; set; }
        // Foreign Key for the Player Table linking the Match to a Game
        public int GameId { get; set; }
        // The map the Match was played on
        public string Map { get; set; } = string.Empty;
        // The result of the Match
        public string Result { get; set; } = string.Empty;
        // Each Game can have many Matches
        public Game Game { get; set; } = null!;
        // Each Match can have many PlayerStats
        public ICollection<PlayerMatchStat> PlayerStats { get; set; } = new List<PlayerMatchStat>();
    }
}