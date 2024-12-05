using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Shared.Interfaces;

namespace TraversolCoreProje.WebUI.Controllers
{
    [AllowAnonymous]
    public class GuideController : Controller
    {
        private readonly IGuideReadApiService _guideReadApiService;
        private readonly IUserService _userService;
        public GuideController(IGuideReadApiService guideReadApiService, IUserService userService)
        {
            _guideReadApiService = guideReadApiService;
            _userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _guideReadApiService.GetAllAsync(_userService.AccessToken);
            return View(data.Data);
        }
    }
}
