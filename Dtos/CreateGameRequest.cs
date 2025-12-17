namespace VideogameStatsApi.Dtos
{
    //Reference: Used to Create Dtos - https://youtu.be/RwQVRXEs370?si=J5DyOYwsu2vnNrvn&t=3538
    // DTO used to create a new Game
    public class CreateGameRequest
    {
        // The ID of the Game
        public int GameId { get; set; } 
        // The Name of the Game
        public string GameName { get; set; }= string.Empty;
    }
}