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
    public class TeamsController : ControllerBase
    {
        private readonly ITeamsRepository _repository;
        private readonly ILogger<TeamsController> _logger;
        public TeamsController(ITeamsRepository repository, ILogger<TeamsController> logger)
        {
            _repository = repository;
            _logger = logger;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetTeams()
        {
            var teams = await _repository.GetTeams();
            return Ok(teams);
        }
        [HttpGet("{id:int}", Name = "GetTeam")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetTeam(int id)
        {
            var team = await _repository.GetTeam(id);
            return Ok(team);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> CreateTeam([FromBody]Team team)
        {
            await _repository.AddTeam(team);
            await _repository.Save();
            return CreatedAtRoute("GetTeam", new { id = team.Id }, team);
        }
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateTeam([FromBody] Team teamObj, int id)
        {
            var team = await _repository.GetTeam(id);
            if (team == null)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateTeam)}");
                return BadRequest("Submited wrong data");
            }
            _repository.UpdateTeam(team);
            await _repository.Save();
            return NoContent();
        }
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteTeam(int id)
        {
            var team = await _repository.GetTeam(id);
            if (team == null)
            {
                _logger.LogError($"Invalid DELETE attempt in {nameof(DeleteTeam)}");
            }
            await _repository.DeleteTeam(id);
            await _repository.Save();
            return NoContent();
        }
    }
}
