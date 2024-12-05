using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Shared.Interfaces;

namespace TraversolCoreProje.WebUI.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[Controller]/[Action]")]
    public class DashboardController : Controller
    {
        private readonly IUserApiService _userApiService;
        private readonly IUserService _userService;
        public DashboardController(IUserApiService userApiService, IUserService userService)
        {
            _userApiService = userApiService;
            _userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _userApiService.GetUserAsync(_userService.AccessToken);
            return View(data.Data);
        }

        public async  Task<IActionResult> Index2()
        {
            ViewBag.T1 = "Dashboard";
            var data = await _userApiService.GetUserAsync(_userService.AccessToken);
            return View(data.Data);
        }
    }
}
