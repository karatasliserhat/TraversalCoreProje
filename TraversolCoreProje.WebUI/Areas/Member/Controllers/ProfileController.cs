using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversolCoreProje.WebUI.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[Controller]/[Action]")]
    public class ProfileController : Controller
    {
        private readonly IUserService _userService;
        private readonly IUserApiService _userApiService;

        public ProfileController(IUserApiService userApiService, IUserService userService)
        {
            _userApiService = userApiService;
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> UserProfile()
        {
            ViewBag.T1 = "Profilim";
            var result = await _userApiService.GetUserUpdateAsync(_userService.AccessToken);

            return View(result.Data);
        }
        [HttpPost]
        public async Task<IActionResult> UserProfile(UserEditViewModel userEditViewModel)
        {
            if (!ModelState.IsValid)
                return View(userEditViewModel);
            var result = await _userApiService.UserEditAsync(userEditViewModel, _userService.AccessToken);
            if (result.StatusCode == StatusCodes.Status200OK)
                return RedirectToAction(nameof(UserProfile));
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item);
            }
            return View(userEditViewModel);
        }

    }
}
