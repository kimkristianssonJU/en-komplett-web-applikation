using Microsoft.EntityFrameworkCore;
using NASA_API.Domain.Models;
using NASA_API.Domain.Persistence.Contexts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NASA_API.Domain.Repositories
{
    public class RoverRepository : BaseRepository, IRoverRepository
    {
        public RoverRepository(AppDbContext appDbContext) : base(appDbContext) { }
        public async Task<IEnumerable<Rover>> ListAsync()
        {
            return await _appDbContext.Rovers.ToListAsync();
        }
        public async Task<Rover> GetByNameAsync(string name)
        {
            return await _appDbContext.Rovers.FirstOrDefaultAsync(r => r.Name.ToLower() == name); 
        }
    }
}
