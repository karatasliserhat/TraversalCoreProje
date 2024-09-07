using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.BusinessLayer.Tools;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.Dto.Dtos;
using TraversolCoreProje.Dto.Dtos.BaseDto;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        public AccountService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IJwtTokenGenerator jwtTokenGenerator)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public async Task<ResponseDto<TokenResponseModel>> SignInAsync(SignInDto signInDto)
        {
            var user = await _userManager.FindByEmailAsync(signInDto.Email);
            if (user is null)
                return ResponseDto<TokenResponseModel>.Fail("Kulanıcı Adı ve ya Şifreniz Hatalı", StatusCodes.Status400BadRequest);
            var userRole = await _userManager.GetRolesAsync(user);
            var role = userRole.FirstOrDefault();
            var getCheckUserModel = new GetCheckUserModel()
            {
                Email = user.Email,
                Name = user.Name,
                Surname = user.Surname,
                UserId = user.Id,
                UserName = user.UserName,
                RoleName = role,

            };
            var signInREsult = await _signInManager.PasswordSignInAsync(user, signInDto.Password, signInDto.RememberMe, false);
            if (!signInREsult.Succeeded)
                return ResponseDto<TokenResponseModel>.Fail("Kulanıcı Adı ve ya Şifreniz Hatalı", StatusCodes.Status400BadRequest);
            var data = _jwtTokenGenerator.GenerateToken(getCheckUserModel);

            return ResponseDto<TokenResponseModel>.Success(data, StatusCodes.Status200OK);


        }
    }
}
