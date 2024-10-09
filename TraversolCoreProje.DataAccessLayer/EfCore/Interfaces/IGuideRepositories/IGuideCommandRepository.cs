using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;

namespace TraversolCoreProje.DataAccessLayer.EfCore.Interfaces
{
    public interface IGuideCommandRepository:IGenericCommandRepository<Guide>
    {
        Task GuideStatusTrue(int id);
        Task GuideStatusFalse(int id);
    }
}
