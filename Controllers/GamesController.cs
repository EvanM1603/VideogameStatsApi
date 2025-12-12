using Microsoft.AspNetCore.Mvc;
using VideogameStatsApi.Models;
using VideogameStatsApi.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VideogameStatsApi.Controllers;

    [Route("api/[controller]")]
    [ApiController]
    public class GamesController(IGameService service) : ControllerBase
    {
        // Reference: Updated Controller - https://youtu.be/RwQVRXEs370?si=XSSpE8rut7tKsh1i&t=1245 

        [HttpGet]

        public async Task<ActionResult<List<Game>>> GetGames()
            => Ok(await service.GetAllGamesAsync());
    }