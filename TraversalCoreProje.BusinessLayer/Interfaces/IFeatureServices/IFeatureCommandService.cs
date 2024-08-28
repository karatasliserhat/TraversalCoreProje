using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Interfaces
{
    public interface IFeatureCommandService:IGenericCommandService<UpdateFeatureDto,CreateFeatureDto,Feature>
    {
    }
}
