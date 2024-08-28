using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Concreate;
using TraversolCoreProje.DataAccessLayer.EfCore.Intercaces;
using TraversolCoreProje.DataAccessLayer.Repository;

namespace TraversolCoreProje.DataAccessLayer.EfCore.Repositories
{
    public class Feature2ReadRepository : GenericReadRepository<Feature2>, IFeature2ReadRepository
    {
        public Feature2ReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
