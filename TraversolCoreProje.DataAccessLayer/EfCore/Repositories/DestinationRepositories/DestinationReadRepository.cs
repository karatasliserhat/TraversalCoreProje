using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Concreate;
using TraversolCoreProje.DataAccessLayer.EfCore.Intercaces;
using TraversolCoreProje.DataAccessLayer.Repository;

namespace TraversolCoreProje.DataAccessLayer.EfCore.Repositories
{
    public class DestinationReadRepository : GenericReadRepository<Destination>, IDestinationReadRepository
    {
        public DestinationReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
