using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Concreate;
using TraversolCoreProje.DataAccessLayer.EfCore.Intercaces;
using TraversolCoreProje.DataAccessLayer.Repository;

namespace TraversolCoreProje.DataAccessLayer.EfCore.Repositories
{
    public class About2ReadRepository : GenericReadRepository<About2>, IAbout2ReadRepository
    {
        public About2ReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
