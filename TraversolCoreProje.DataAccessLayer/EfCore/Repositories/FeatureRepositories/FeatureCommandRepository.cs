using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Concreate;
using TraversolCoreProje.DataAccessLayer.EfCore.Intercaces;
using TraversolCoreProje.DataAccessLayer.Repository;
using TraversolCoreProje.DataAccessLayer.UnitOfWorks;

namespace TraversolCoreProje.DataAccessLayer.EfCore.Repositories
{
    public class FeatureCommandRepository : GenericCommandRepository<Feature>, IFeatureCommandRepository
    {
        public FeatureCommandRepository(AppDbContext appDbContext, IUnitOfWork unitOfWork) : base(appDbContext, unitOfWork)
        {
        }
    }
}
