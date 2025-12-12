namespace VideogameStatsApi.Dtos
{
    public class GameDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        // public ICollection<Match> Matches { get; set; } = new List<Match>();
    }
}
