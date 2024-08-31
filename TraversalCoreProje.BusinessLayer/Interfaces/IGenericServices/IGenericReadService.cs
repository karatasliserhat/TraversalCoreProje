using TraversalCoreProje.CoreLayer.BaseConcrete;
using TraversolCoreProje.Dto.Dtos;
using TraversolCoreProje.Dto.Dtos.BaseDto;

namespace TraversalCoreProje.BusinessLayer.Interfaces
{
    public interface IGenericReadService<ResultDto, Entity> where ResultDto : ResultBaseDto where Entity : BaseEntity
    {
        Task<ResponseDto<List<ResultDto>>> GetListAsync();
        Task<ResponseDto<ResultDto>> GetByIdAsync(int id);
    }
}
