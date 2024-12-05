using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.Dto.Dtos;
using TraversolCoreProje.Dto.Dtos.BaseDto;

namespace TraversalCoreProje.BusinessLayer.Interfaces
{
    public interface IDestinationReadService:IGenericReadService<ResultDestinationDto,Destination>
    {
        Task<ResponseDto<ResultDestinationDto>> DestinationwithGuidebyDestinationId(int id);
        Task<ResponseDto<List<ResultDestinationDto>>> GetLastFourDestinationIdAsync();
    }
}
