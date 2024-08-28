using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Concreate;
using TraversolCoreProje.DataAccessLayer.EfCore.Intercaces;
using TraversolCoreProje.DataAccessLayer.Repository;

namespace TraversolCoreProje.DataAccessLayer.EfCore.Repositories
{
    public class GuideReadRepository : GenericReadRepository<Guide>, IGuideReadRepository
    {
        public GuideReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
