using NASA_API.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NASA_API.Domain.Repositories
{
    public interface IRoverRepository
    {
        Task<IEnumerable<Rover>> ListAsync();
        Task<Rover> GetByNameAsync(string name);
    }
}
