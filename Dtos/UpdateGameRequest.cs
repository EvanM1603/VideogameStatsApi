namespace VideogameStatsApi.Dtos
{
    //Reference: Used to Create Dtos - https://youtu.be/RwQVRXEs370?si=J5DyOYwsu2vnNrvn&t=3538
    // DTO used to update an existing Game
    public class UpdateGameRequest
    {
        // The Name of the Game
        public string GameName { get; set; } = string.Empty;
    }
}