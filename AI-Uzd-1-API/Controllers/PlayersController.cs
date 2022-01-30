using AI_Uzd_1_API.IRepository;
using AI_Uzd_1_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AI_Uzd_1_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayersRepository _repository;
        private readonly ILogger<PlayersController> _logger;
        public PlayersController(IPlayersRepository repository, ILogger<PlayersController> logger)
        {
            _repository = repository;
            _logger = logger;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetPlayers()
        {
            var players = await _repository.GetPlayers();
            return Ok(players);
        }
        [HttpGet("{id:int}", Name = "GetPlayer")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetPlayer(int id)
        {
            var player = await _repository.GetPlayer(id);
            return Ok(player);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> CreatePlayer([FromBody] Player player)
        {
            await _repository.AddPlayer(player);
            await _repository.Save();
            var result = await _repository.GetPlayer(player.Id);
            return Ok(result);
        }
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePlayer([FromBody] Player playerObj, int id)
        {
            var player = await _repository.GetPlayer(id);
            if (player == null)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdatePlayer)}");
                return BadRequest("Submited wrong data");
            }
            _repository.UpdatePlayer(player);
            await _repository.Save();
            return NoContent();
        }
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeletePlayer(int id)
        {
            var player = await _repository.GetPlayer(id);
            if(player == null)
            {
                _logger.LogError($"Invalid DELETE attempt in {nameof(DeletePlayer)}");
            }
            await _repository.DeletePlayer(id);
            await _repository.Save();
            return NoContent();
        }
    }
}
