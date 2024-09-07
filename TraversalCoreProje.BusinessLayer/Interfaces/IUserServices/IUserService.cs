using TraversolCoreProje.Dto.Dtos.BaseDto;
using TraversolCoreProje.Dto.Dtos.UserDto;

namespace TraversalCoreProje.BusinessLayer.Interfaces.IUserServices
{
    public interface IUserService
    {
        Task<ResponseDto<CreateUserDto>> CreateUserAsync(CreateUserDto createUserDto);
    }
}
