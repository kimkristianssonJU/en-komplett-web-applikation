using NASA_API.Domain.Persistence.Contexts;

namespace NASA_API.Domain.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly AppDbContext _appDbContext;
        public BaseRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
