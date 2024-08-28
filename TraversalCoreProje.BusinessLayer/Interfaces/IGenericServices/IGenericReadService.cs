using TraversalCoreProje.CoreLayer.BaseConcrete;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Interfaces
{
    public interface IGenericReadService<ResultDto, Entity> where ResultDto : ResultBaseDto where Entity : BaseEntity
    {
        Task<List<ResultDto>> GetListAsync();
        Task<ResultDto> GetByIdAsync(int id);
    }
}
