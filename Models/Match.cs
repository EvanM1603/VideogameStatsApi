namespace VideogameStatsApi.Models
{
    public class Match
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public string Map { get; set; } = string.Empty;
        public string Result { get; set; } = string.Empty;

        public Game Game { get; set; } = null!;
        public ICollection<PlayerMatchStat> PlayerStats { get; set; } = new List<PlayerMatchStat>();
    }
}