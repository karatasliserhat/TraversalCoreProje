using Microsoft.AspNetCore.Http.HttpResults;
using TraversalCoreProje.CoreLayer.BaseConcrete;
using TraversolCoreProje.Dto.Dtos;
using TraversolCoreProje.Dto.Dtos.BaseDto;

namespace TraversalCoreProje.BusinessLayer.Interfaces
{
    public interface IGenericCommandService<UpdateDto,CreateDto,Entity> where UpdateDto : UpdateBaseDto where CreateDto : CreateBaseDto where Entity : BaseEntity
    {
        Task<ResponseDto<NoContent>> CreateAsync(CreateDto entity);
        Task<ResponseDto<NoContent>> UpdateAsync(UpdateDto entity);
        Task<ResponseDto<NoContent>> DeleteAsync(int id);
    }
}
