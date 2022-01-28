using Microsoft.AspNetCore.Mvc;
using NASA_API.Domain.Models;
using NASA_API.Domain.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace NASA_API.Controllers
{
    [Route("/api/{controller}")]
    public class RoversController : Controller
    {
        private readonly IRoverService _roverService;

        public RoversController(IRoverService roverService)
        {
            _roverService = roverService;
        }

        [HttpGet]
        public async  Task<IEnumerable<Rover>> GetAllAsync()
        {
            var rovers = await _roverService.ListAsync();
            return rovers;
        }
        [HttpGet("{name}")]
        public async Task<Rover> GetRoverByName(string name)
        {
            var rover = await _roverService.GetByNameAsync(name.ToLower());
            return rover;
        }
    }
}
