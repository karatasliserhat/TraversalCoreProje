using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Interfaces
{
    public interface ISubAboutCommandService:IGenericCommandService<UpdateSubAboutDto,CreateSubAboutDto,SubAbout>
    {
    }
}
