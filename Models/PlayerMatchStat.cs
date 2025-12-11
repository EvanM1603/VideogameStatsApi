namespace VideogameStatsApi.Models
{
    public class PlayerMatchStat
    {
        public int Id { get; set; }

        public int PlayerId { get; set; }
        public int MatchId { get; set; }

        public int TeamNumber { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }

        public Player Player { get; set; } = null!;
        public Match Match { get; set; } = null!;
    }
}