using Microsoft.AspNetCore.Http.HttpResults;
using TraversolCoreProje.Dto.Dtos;
using TraversolCoreProje.Dto.Dtos.BaseDto;
using TraversolCoreProje.Dto.Dtos.UserDto;

namespace TraversalCoreProje.BusinessLayer.Interfaces.IUserServices
{
    public interface IUserService
    {
        Task<ResponseDto<CreateUserDto>> CreateUserAsync(CreateUserDto createUserDto);
        Task<ResponseDto<NoContent>> UserEditAsync(UserEditDto userEditDto);
        Task<ResponseDto<ResultUserDto>> GetUserAsync(int userId);
        Task<ResponseDto<List<ResultUserDto>>> GetListUserAsync();
        Task<ResponseDto<NoContent>> DeleteUserAsync(int userId);
    }
}
