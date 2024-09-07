using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using TraversalCoreProje.BusinessLayer.Interfaces.IUserServices;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.Dto.Dtos.BaseDto;
using TraversolCoreProje.Dto.Dtos.UserDto;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public UserService(UserManager<AppUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<ResponseDto<CreateUserDto>> CreateUserAsync(CreateUserDto createUserDto)
        {
            var appUserMap = _mapper.Map<AppUser>(createUserDto);
            var result = await _userManager.CreateAsync(appUserMap, createUserDto.Password);
            if (result.Succeeded)
            {
                return ResponseDto<CreateUserDto>.Success(createUserDto, StatusCodes.Status201Created);
            }
            List<string> errors = new List<string> { };
            foreach (var item in result.Errors)
            {
                errors.Add(item.Description);
            }
            return ResponseDto<CreateUserDto>.Fail(errors, StatusCodes.Status400BadRequest);

        }
    }
}
