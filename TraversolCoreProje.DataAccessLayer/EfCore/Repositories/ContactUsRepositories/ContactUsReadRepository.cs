using Microsoft.EntityFrameworkCore;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Concreate;
using TraversolCoreProje.DataAccessLayer.EfCore.Interfaces.IContactUsRepositories;
using TraversolCoreProje.DataAccessLayer.Repository;

namespace TraversolCoreProje.DataAccessLayer.EfCore.Repositories
{
    public class ContactUsReadRepository : GenericReadRepository<ContactUs>, IContactUsReadRepositories
    {
        private readonly AppDbContext _appDbContext;
        public ContactUsReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<ContactUs>> GetlistContactUsByStatusFalse()
        {
            return await _appDbContext.ContactUses.AsNoTracking().Where(x => x.Status == false).ToListAsync();
        }

        public async Task<List<ContactUs>> GetlistContactUsByStatusTrue()
        {
            return await _appDbContext.ContactUses.AsNoTracking().Where(x => x.Status == true).ToListAsync();
        }

        public async Task GetlistContactUsChangeFalse(int id)
        {
            await _appDbContext.ContactUses.Where(x => x.Id == id).ExecuteUpdateAsync(x => x.SetProperty(y => y.Status, false));
        }
    }
}
