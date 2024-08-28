using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Concreate;
using TraversolCoreProje.DataAccessLayer.EfCore.Intercaces;
using TraversolCoreProje.DataAccessLayer.Repository;

namespace TraversolCoreProje.DataAccessLayer.EfCore.Repositories
{
    public class SubAboutReadRepository : GenericReadRepository<SubAbout>, ISubAboutReadRepository
    {
        public SubAboutReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
