using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TraversalCoreProje.CoreLayer.BaseConcrete;
using TraversolCoreProje.DataAccessLayer.Concreate;
using TraversolCoreProje.DataAccessLayer.Interfaces;

namespace TraversolCoreProje.DataAccessLayer.Repository
{
    public class GenericReadRepository<T> : IGenericReadRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _appDbContext;
        public GenericReadRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _appDbContext.Set<T>().AsNoTracking().Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<T>> GetListAsync()
        {
            return await _appDbContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<List<T>> GetListByFilter(Expression<Func<T, bool>> filter)
        {
            return await _appDbContext.Set<T>().AsNoTracking().Where(filter).ToListAsync();
        }
    }
}
