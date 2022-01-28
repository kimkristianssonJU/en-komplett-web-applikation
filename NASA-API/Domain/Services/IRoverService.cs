using NASA_API.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NASA_API.Domain.Services
{
    public interface IRoverService
    {
        Task<IEnumerable<Rover>> ListAsync();
        Task<Rover> GetByNameAsync(string name);
    }
}
