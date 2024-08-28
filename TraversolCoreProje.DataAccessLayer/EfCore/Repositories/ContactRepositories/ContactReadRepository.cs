using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Concreate;
using TraversolCoreProje.DataAccessLayer.EfCore.Intercaces;
using TraversolCoreProje.DataAccessLayer.Repository;

namespace TraversolCoreProje.DataAccessLayer.EfCore.Repositories
{
    public class ContactReadRepository : GenericReadRepository<Contact>, IContactReadRepository
    {
        public ContactReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
