using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversolCoreProje.WebUI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly IAccountApiService _accountApiService;
        private readonly IUserApiService _userApiService;

        public LoginController(IAccountApiService accountApiService, IUserApiService userApiService)
        {
            _accountApiService = accountApiService;
            _userApiService = userApiService;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View(new CreateUserViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(CreateUserViewModel createUserViewModel)
        {
            if (!ModelState.IsValid)
                return View(createUserViewModel);
            var result = await _userApiService.CreateUserAsync(createUserViewModel);
            if (result.StatusCode == StatusCodes.Status201Created)
                return RedirectToAction(nameof(SignIn));

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item);
            }
            return View(createUserViewModel);
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View(new SignInViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(SignInViewModel signInViewModel, string returnUrl)
        {
            if (!ModelState.IsValid)
                return View(signInViewModel);
            var values = await _accountApiService.SignInAsync(signInViewModel);
            if (values.StatusCode == StatusCodes.Status200OK)
            {
                JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
                var token = handler.ReadJwtToken(values.Data.Token);

                var claims = token.Claims.ToList();
                claims.Add(new Claim("accessToken", values.Data.Token));

                var claimsIdentity = new ClaimsIdentity(claims, JwtBearerDefaults.AuthenticationScheme);
                var authProperty = new AuthenticationProperties
                {
                    ExpiresUtc = values.Data.ExpireDate,
                    IsPersistent = signInViewModel.RememberMe
                };

                await HttpContext.SignInAsync(JwtBearerDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperty);
                if (!Url.IsLocalUrl(returnUrl) || returnUrl == "/" || returnUrl == null)
                    return RedirectToAction("Index", "Default");
                return Redirect(returnUrl);
            }
            foreach (var item in values.Errors) ModelState.AddModelError("", item);

            return View(signInViewModel);
        }
    }
}
