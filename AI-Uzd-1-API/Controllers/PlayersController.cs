using AI_Uzd_1_API.IRepository;
using AI_Uzd_1_API.Models;
using AI_Uzd_1_API.ModelsDTO;
using AutoMapper;
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
        public readonly IMapper _mapper;

        public PlayersController(IPlayersRepository repository, ILogger<PlayersController> logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetPlayers()
        {
            var players = await _repository.GetPlayers();
            var results = _mapper.Map<IList<PlayerDTO>>(players);
            return Ok(results);
        }
        [HttpGet("{id:int}", Name = "GetPlayer")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetPlayer(int id)
        {
            var player = await _repository.GetPlayer(id);
            var results = _mapper.Map<PlayerDTO>(player);
            return Ok(results);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> CreatePlayer([FromBody] CreatePlayerDTO player)
        {
            var players = await _repository.GetPlayers();
            var convertedPlayers = _mapper.Map<IList<PlayerDTO>>(players);
            foreach(PlayerDTO playeris in convertedPlayers)
            {
                playeris.Distance = Math.Sqrt(Math.Pow(player.Height - playeris.Height, 2) + Math.Pow(player.Weight - playeris.Weight, 2));
            }
            //surikiuojam nuo maziausios distancijos iki didziausios
            var playersAscending= convertedPlayers.OrderBy(p => p.Distance);
            //pasiemam pirmus k elementus is saraso
            var kPlayersArray = playersAscending.Take(player.Knum);
            //skaiciuojam ko daugiau variantu krepsiniu ar futbolui
            var countedBasketballPlayers = kPlayersArray.Count(p => p.Team.Sport.Title == "Krepšinis");
            var countedFootbalPlayers = kPlayersArray.Count(p => p.Team.Sport.Title == "Futbolas");
            
            //jeigu krepsinio yra daugiau tada priskiriam krepsini
            if(countedBasketballPlayers > countedFootbalPlayers)
            {
                //priskiriam prie zalgirio
                player.TeamId = 1;
                //get only krepsinis list
                var basketballList = playersAscending.Where(p => p.Team.Sport.Title == "Krepšinis").OrderBy(p => p.Distance);
                //take k number of elements with smallest distances
                var bCutList = basketballList.Take(player.Knum);
                //counting which is more gynejas or puolejas in that bCutList
                var defendersCount = bCutList.Count(p => p.Position == "Gynejas");
                var puolejasCount = bCutList.Count(p => p.Position == "Puolejas");
                if (defendersCount > puolejasCount)
                    player.Position = "Gynejas";
                else if (defendersCount < puolejasCount)
                    player.Position = "Puolejas";
                else
                {
                    player.Position = "Gynejas, Puolejas";
                }
            }
            else
            {
                //jeigu futbolo rado daugiau tada priskiriam futbola
                player.TeamId = 2;
                //get only futbolas list
                var footballList = playersAscending.Where(p => p.Team.Sport.Title == "Futbolas").OrderBy(p => p.Distance);
                //take k number of elements with smallest distances
                var fCutList = footballList.Take(player.Knum);
                //counting which is more gynejas or puolejas in that fCutList 
                var defendersCount = fCutList.Count(p => p.Position == "Gynejas");
                var puolejasCount = fCutList.Count(p => p.Position == "Puolejas");
                if (defendersCount > puolejasCount)
                    player.Position = "Gynejas";
                else if (defendersCount < puolejasCount)
                    player.Position = "Puolejas";
                else
                    player.Position = "Gynejas, Puolejas";
            }

            var playerForInsert = _mapper.Map<Player>(player);
            await _repository.AddPlayer(playerForInsert);
            await _repository.Save();
            var result = await _repository.GetPlayer(playerForInsert.Id);
            return Ok(result);

            /*await _repository.AddPlayer(player);
            await _repository.Save();
            var result = await _repository.GetPlayer(player.Id);
            return Ok(result);*/
        }
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePlayer([FromBody] UpdatePlayerDTO playerObj, int id)
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
