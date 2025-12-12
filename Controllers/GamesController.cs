using Microsoft.AspNetCore.Mvc;
using VideogameStatsApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VideogameStatsApi.Controllers;

    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        // Reference: Updated Controller - https://youtu.be/RwQVRXEs370?si=XSSpE8rut7tKsh1i&t=1245 

        static List<Game> games = new List<Game>{
            new Game { Id = 1, Name = "Valorant" },
            new Game { Id = 2, Name = "Rainbow Six Siege" },
            new Game { Id = 3, Name = "CS:GO" }
        };

        [HttpGet]

        public async Task<ActionResult<List<Game>>> GetGames()
            => await Task.FromResult(Ok(games));
    }