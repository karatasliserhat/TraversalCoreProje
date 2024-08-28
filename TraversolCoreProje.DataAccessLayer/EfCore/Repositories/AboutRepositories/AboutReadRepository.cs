using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Concreate;
using TraversolCoreProje.DataAccessLayer.EfCore.Intercaces;
using TraversolCoreProje.DataAccessLayer.Repository;

namespace TraversolCoreProje.DataAccessLayer.EfCore.Repositories
{
    public class AboutReadRepository : GenericReadRepository<About>, IAboutReadRepository
    {
        public AboutReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
