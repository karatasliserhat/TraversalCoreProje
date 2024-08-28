using TraversalCoreProje.CoreLayer.BaseConcrete;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Interfaces
{
    public interface IGenericCommandService<UpdateDto,CreateDto,Entity> where UpdateDto : UpdateBaseDto where CreateDto : CreateBaseDto where Entity : BaseEntity
    {
        Task CreateAsync(CreateDto entity);
        Task UpdateAsync(UpdateDto entity);
        Task DeleteAsync(int id);
    }
}
