using Microsoft.AspNetCore.Http.HttpResults;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.Dto.Dtos;
using TraversolCoreProje.Dto.Dtos.BaseDto;

namespace TraversalCoreProje.BusinessLayer.Interfaces
{
    public interface IGuideCommandService:IGenericCommandService<UpdateGuideDto,CreateGuideDto,Guide>
    {
        Task<ResponseDto<NoContent>> GuideStatusFalseAsync(int id);
        Task<ResponseDto<NoContent>> GuideStatusTrueAsync(int id);
    }
}
