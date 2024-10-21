using Microsoft.AspNetCore.Http.HttpResults;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.Dto.Dtos;
using TraversolCoreProje.Dto.Dtos.BaseDto;

namespace TraversalCoreProje.BusinessLayer.Interfaces
{
    public interface IContactUsReadServices:IGenericReadService<ResultContactUsDto,ContactUs>
    {
        Task<ResponseDto<List<ResultContactUsDto>>> GetListContactUsByStatusFalseAsync();
        Task<ResponseDto<List<ResultContactUsDto>>> GetListContactUsByStatusTrueAsync();
        Task<ResponseDto<NoContent>> GetContactUsChangeStatusFalse(int id);
    }
}
