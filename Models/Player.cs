namespace VideogameStatsApi.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string InGameName { get; set; } = string.Empty;

        public ICollection<PlayerMatchStat> PlayerMatchStats { get; set; } = new List<PlayerMatchStat>();
    }
}