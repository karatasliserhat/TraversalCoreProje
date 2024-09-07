using TraversalCoreProje.BusinessLayer.Tools;
using TraversolCoreProje.Dto.Dtos;
using TraversolCoreProje.Dto.Dtos.BaseDto;

namespace TraversalCoreProje.BusinessLayer.Interfaces
{
    public interface IAccountService
    {
        Task<ResponseDto<TokenResponseModel>> SignInAsync(SignInDto signInDto);
    }
}
