namespace VideogameStatsApi.Models
{
    // Represents the Stats of a Player in a Match
    public class PlayerMatchStat
    {
        // Primary Key for the PlayerMatchStat Table
        public int Id { get; set; }
        // Foreign Key for the Player Table
        public int PlayerId { get; set; }
        // Foreign Key for the Match Table
        public int MatchId { get; set; }
        // The number of the team that the Player was on
        public int TeamNumber { get; set; }
        // The number of Kills the Player got in this Match
        public int Kills { get; set; }
        // The number of Deaths the Player had in this Match
        public int Deaths { get; set; }
        // The number of Assists the Player had in this Match
        public int Assists { get; set; }
        // Each Player can have many PlayerStats
        public Player Player { get; set; } = null!;
        // Each Match can have many PlayerStats
        public Match Match { get; set; } = null!;
    }
}