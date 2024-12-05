using Microsoft.EntityFrameworkCore;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Concreate;
using TraversolCoreProje.DataAccessLayer.EfCore.Interfaces;
using TraversolCoreProje.DataAccessLayer.Repository;

namespace TraversolCoreProje.DataAccessLayer.EfCore.Repositories
{
    public class DestinationReadRepository : GenericReadRepository<Destination>, IDestinationReadRepository
    {
        private readonly AppDbContext _appDbContext;
        public DestinationReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Destination> DestinationwithGuidebyDestinationId(int id)
        {
            return await _appDbContext.Destinations.Include(x => x.Guide).AsNoTracking().Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Destination>> GetLastFourDestinations()
        {
            return await _appDbContext.Destinations.Include(x => x.Guide).AsNoTracking().Take(4).OrderByDescending(x => x.Id).ToListAsync();
        }
    }
}
