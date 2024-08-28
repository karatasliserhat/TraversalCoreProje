using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Concreate;
using TraversolCoreProje.DataAccessLayer.EfCore.Intercaces;
using TraversolCoreProje.DataAccessLayer.Repository;

namespace TraversolCoreProje.DataAccessLayer.EfCore.Repositories
{
    public class NewsLetterReadRepository : GenericReadRepository<NewsLetter>, INewsLetterReadRepository
    {
        public NewsLetterReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
