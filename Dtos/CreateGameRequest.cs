namespace VideogameStatsApi.Dtos
{
    public class CreateGameRequest
    {
        public int GameId { get; set; } 
        public string GameName { get; set; }= string.Empty;
    }
}