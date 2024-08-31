using Microsoft.EntityFrameworkCore;
using TraversolCoreProje.DataAccessLayer.Concreate;
using TraversolCoreProje.DataAccessLayer.EfCore.Intercaces;

namespace TraversolCoreProje.DataAccessLayer.EfCore.Repositories
{
    public class StatisticsRepository : IStatisticsRepository
    {
        private readonly AppDbContext _appDbContext;

        public StatisticsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<int> DestinationCount()
        {
            return await _appDbContext.Destinations.CountAsync();
        }

        public async Task<int> GuideCount()
        {
            return await _appDbContext.Guides.CountAsync();
        }

        public async Task<int> TestimonialCount()
        {
            return await _appDbContext.Testimonials.CountAsync();
        }
    }
}
