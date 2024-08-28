using Microsoft.EntityFrameworkCore;
using TraversalCoreProje.CoreLayer.BaseConcrete;
using TraversolCoreProje.DataAccessLayer.Concreate;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.DataAccessLayer.UnitOfWorks;

namespace TraversolCoreProje.DataAccessLayer.Repository
{
    public class GenericCommandRepository<T> : IGenericCommandRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _appDbContext;
        private readonly IUnitOfWork _unitOfWork;
        public GenericCommandRepository(AppDbContext appDbContext, IUnitOfWork unitOfWork)
        {
            _appDbContext = appDbContext;
            _unitOfWork = unitOfWork;
        }

        public async Task CreateAsync(T entity)
        {
            await _appDbContext.Set<T>().AddAsync(entity);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var data = await _appDbContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
            _appDbContext.Set<T>().Remove(data);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _appDbContext.Set<T>().Update(entity);
            await _unitOfWork.SaveChangeAsync();
        }
    }
}
