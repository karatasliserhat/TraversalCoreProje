using TraversolCoreProje.DataAccessLayer.Concreate;

namespace TraversolCoreProje.DataAccessLayer.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;

        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void SaveChange()
        {
            _appDbContext.SaveChanges();
        }

        public async Task SaveChangeAsync()
        {
           await _appDbContext.SaveChangesAsync();
        }
    }
}
