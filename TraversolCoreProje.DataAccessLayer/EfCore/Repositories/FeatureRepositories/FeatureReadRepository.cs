using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Concreate;
using TraversolCoreProje.DataAccessLayer.EfCore.Intercaces;
using TraversolCoreProje.DataAccessLayer.Repository;

namespace TraversolCoreProje.DataAccessLayer.EfCore.Repositories
{
    public class FeatureReadRepository : GenericReadRepository<Feature>, IFeatureReadRepository
    {
        public FeatureReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
