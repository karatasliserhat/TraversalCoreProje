using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Interfaces
{
    public interface IGuideCommandService:IGenericCommandService<UpdateGuideDto,CreateGuideDto,Guide>
    {
    }
}
