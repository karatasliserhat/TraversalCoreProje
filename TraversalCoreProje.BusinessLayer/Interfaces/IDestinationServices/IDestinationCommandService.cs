using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Interfaces
{
    public interface IDestinationCommandService:IGenericCommandService<UpdateDestinationDto,CreateDestinationDto,Destination>
    {
    }
}
