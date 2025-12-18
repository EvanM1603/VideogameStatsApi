namespace VideogameStatsApi.Dtos
{
    //Reference: Used to Create Dtos - https://youtu.be/RwQVRXEs370?si=J5DyOYwsu2vnNrvn&t=3538
    // DTO used to update an existing Player
    public class UpdatePlayerRequest
    {
        // The InGameName of the Player
        public string InGameName { get; set; } = string.Empty;
    }
}