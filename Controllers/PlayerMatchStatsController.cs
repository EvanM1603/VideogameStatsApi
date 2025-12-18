using Microsoft.AspNetCore.Mvc;
using VideogameStatsApi.Authentication;
using VideogameStatsApi.Dtos;
using VideogameStatsApi.Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VideogameStatsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiKey]
    public class PlayerMatchStatsController(IPlayerMatchStatService service) : ControllerBase
    {
        // Reference: Updated Controller after Dtos - https://youtu.be/RwQVRXEs370?si=edblfYxP61HN3ZPn&t=3617

        // Get all PlayerMatchStats
        [HttpGet]
        public async Task<ActionResult<List<PlayerResponse>>> GetPlayerMatchStats()
            => Ok(await service.GetAllPlayerMatchStatsAsync());

        // Get PlayerMatchStat by Id
        [HttpGet("{id}")]
        public async Task<ActionResult<PlayerResponse>> GetPlayerMatchStatById(int id)
        {
            var player = await service.GetPlayerMatchStatByIdAsync(id);
            return player is null ? NotFound("No Stat found with this id. ") : Ok(player);
        }

        // Add PlayerMatchStat
        [HttpPost]
        public async Task<ActionResult<PlayerResponse>> AddPlayerMatchStat(CreatePlayerMatchStatRequest stat)
        {
            var createdStat = await service.AddPlayerMatchStatAsync(stat);
            return CreatedAtAction(nameof(GetPlayerMatchStatById), new { id = createdStat.Id }, createdStat);
        }

        // Update existing PlayerMatchStat
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdatePlayerMatchStat(int id, UpdatePlayerMatchStatRequest stat)
        {
            var updated = await service.UpdatePlayerMatchStatAsync(id, stat);
            return updated ? NoContent() : NotFound("Stat with the given Id was not found. ");
        }

        // Delete existing PlayerMatchStat
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePlayerMatchStat(int id)
        {
            var deleted = await service.DeletePlayerMatchStatAsync(id);
            return deleted ? NoContent() : NotFound("Stat with the given Id was not found.");
        }
    }
}
