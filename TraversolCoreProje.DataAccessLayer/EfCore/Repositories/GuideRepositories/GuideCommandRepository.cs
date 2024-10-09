using Microsoft.EntityFrameworkCore;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Concreate;
using TraversolCoreProje.DataAccessLayer.EfCore.Interfaces;
using TraversolCoreProje.DataAccessLayer.Repository;
using TraversolCoreProje.DataAccessLayer.UnitOfWorks;

namespace TraversolCoreProje.DataAccessLayer.EfCore.Repositories
{
    public class GuideCommandRepository : GenericCommandRepository<Guide>, IGuideCommandRepository
    {
        private readonly AppDbContext _appDbContext;
        public GuideCommandRepository(AppDbContext appDbContext, IUnitOfWork unitOfWork) : base(appDbContext, unitOfWork)
        {
            _appDbContext = appDbContext;
        }

        public async Task GuideStatusFalse(int id)
        {
            await _appDbContext.Guides.Where(x => x.Id == id).ExecuteUpdateAsync(x => x.SetProperty(x => x.Status, false));
        }

        public async Task GuideStatusTrue(int id)
        {
            await _appDbContext.Guides.Where(x => x.Id == id).ExecuteUpdateAsync(x => x.SetProperty(x => x.Status, true));

        }
    }
}
