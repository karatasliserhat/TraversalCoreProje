using TraversolCoreProje.Dto.Dtos.BaseDto;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Interfaces
{
    public interface IStatisticsService
    {
        Task<ResponseDto<int>> DestinationCount();
        Task<ResponseDto<int>> GuideCount();
        Task<ResponseDto<int>> TestimonialCount();
    }
}
