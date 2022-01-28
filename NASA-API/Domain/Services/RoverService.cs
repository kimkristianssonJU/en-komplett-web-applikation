using NASA_API.Domain.Models;
using NASA_API.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NASA_API.Domain.Services
{
    public class RoverService : IRoverService
    {
        private readonly IRoverRepository _roverRepository;
        public RoverService(IRoverRepository roverRepository)
        {
            _roverRepository = roverRepository;   
        }

        public async Task<IEnumerable<Rover>> ListAsync()
        {
            return await _roverRepository.ListAsync();
        }
        public async Task<Rover> GetByNameAsync(string name)
        {
            return await _roverRepository.GetByNameAsync(name);
        }
    }
}
