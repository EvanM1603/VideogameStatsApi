using Microsoft.AspNetCore.Mvc;
using VideogameStatsApi.Dtos;
using VideogameStatsApi.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VideogameStatsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchesController(IMatchService service) : ControllerBase
    {
        // Reference: Updated Controller after Dtos - https://youtu.be/RwQVRXEs370?si=edblfYxP61HN3ZPn&t=3617

        [HttpGet]
        public async Task<ActionResult<List<MatchResponse>>> GetMatches()
            => Ok(await service.GetAllMatchesAsync());

        [HttpGet("{id}")]
        public async Task<ActionResult<MatchResponse>> GetMatchById(int id)
        {
            var match = await service.GetMatchByIdAsync(id);
            return match is null ? NotFound("No match found with this id. ") : Ok(match);
        }

        [HttpPost]
        public async Task<ActionResult<MatchResponse>> AddMatch(CreateMatchRequest match)
        {
            var createdMatch = await service.AddMatchAsync(match);
            return CreatedAtAction(nameof(GetMatchById), new { id = createdMatch.Id }, createdMatch);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateMatch(int id, UpdateMatchRequest match)
        {
            var updated = await service.UpdateMatchAsync(id, match);
            return updated ? NoContent() : NotFound("Match with the given Id was not found. ");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteMatch(int id)
        {
            var deleted = await service.DeleteMatchAsync(id);
            return deleted ? NoContent() : NotFound("Match with the given Id was not found.");
        }
    }
}