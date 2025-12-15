namespace VideogameStatsApi.Dtos
{
    public class UpdateGameRequest
    {
        public int GameId { get; set; } 
        public string GameName { get; set; } = string.Empty;
    }
}