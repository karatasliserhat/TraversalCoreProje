using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.Dto.Dtos;
using TraversolCoreProje.Dto.Dtos.BaseDto;

namespace TraversalCoreProje.BusinessLayer.Interfaces
{
    public interface ICommentReadService:IGenericReadService<ResultCommentDto,Comment>
    {
        Task<ResponseDto<List<ResultCommentDto>>> GetListByDestinationIdAsync(int id);
        Task<ResponseDto<List<ResultCommentDto>>> GetListWithDestinationCityAsync();
        Task<ResponseDto<List<ResultCommentDto>>> CommentAllWithAsppUserIncludeByIdAsync(int destinationId);
    }
}
