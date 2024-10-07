using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TraversalCoreProje.BusinessLayer.Interfaces.IUserServices;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.Dto.Dtos;
using TraversolCoreProje.Dto.Dtos.BaseDto;
using TraversolCoreProje.Dto.Dtos.UserDto;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;
        private readonly SignInManager<AppUser> _signInManager;
        public UserService(UserManager<AppUser> userManager, IMapper mapper, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _mapper = mapper;
            _signInManager = signInManager;
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

        public async Task<ResponseDto<NoContent>> DeleteUserAsync(int userId)
        {
            var dataUser = await _userManager.FindByIdAsync(userId.ToString());
            if (dataUser is not null)
            {
                var result = await _userManager.DeleteAsync(dataUser);
                if (result.Succeeded)
                    return ResponseDto<NoContent>.Success(StatusCodes.Status204NoContent);
                return ResponseDto<NoContent>.Fail("Bir Hata Meydana Geldi", StatusCodes.Status500InternalServerError);
            }
            return ResponseDto<NoContent>.Fail("User Bulunamadı", StatusCodes.Status400BadRequest);
        }

        public async Task<ResponseDto<List<ResultUserDto>>> GetListUserAsync()
        {
            var user = await _userManager.Users.ToListAsync();
            if (user is null)
                return ResponseDto<List<ResultUserDto>>.Fail("Kullanıcı Bulunamadı", StatusCodes.Status404NotFound);

            return ResponseDto<List<ResultUserDto>>.Success(_mapper.Map<List<ResultUserDto>>(user), StatusCodes.Status200OK);
        }

        public async Task<ResponseDto<ResultUserDto>> GetUserAsync(int userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user is null)
                return ResponseDto<ResultUserDto>.Fail("Kullanıcı Bulunamadı", StatusCodes.Status404NotFound);

            return ResponseDto<ResultUserDto>.Success(_mapper.Map<ResultUserDto>(user), StatusCodes.Status200OK);
        }

        public async Task<ResponseDto<NoContent>> UserEditAsync(UserEditDto userEditDto)
        {
            AppUser user = await _userManager.FindByIdAsync(userEditDto.Id.ToString());
            if (user is null)
                return ResponseDto<NoContent>.Fail("Kullanıcı Bulunamadı", StatusCodes.Status404NotFound);
            if (userEditDto.Password is not null)
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEditDto.Password);

            if (userEditDto.ImageUrl is not null)
                user.ImageUrl = userEditDto.ImageUrl;

            if (userEditDto.Gender is not null)
                user.Gender = userEditDto.Gender;
            user.Name = userEditDto.Name;
            user.Email = userEditDto.Email;
            user.Surname = userEditDto.Surname;
            var response = await _userManager.UpdateAsync(user);
            if (response.Succeeded)
            {
                await _userManager.UpdateSecurityStampAsync(user);
                await _signInManager.SignOutAsync();
                await _signInManager.SignInAsync(user, true);
                return ResponseDto<NoContent>.Success(StatusCodes.Status200OK);
            }
            var errors = new List<string>();
            foreach (var error in response.Errors)
            {
                errors.Add(error.Description);
            }
            return ResponseDto<NoContent>.Fail(errors, StatusCodes.Status400BadRequest);
        }
    }
}
