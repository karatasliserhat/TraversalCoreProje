using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Shared.Interfaces;

namespace TraversolCoreProje.WebUI.ViewComponents.MemberDashboardComponent
{
    public class _ProfileInformationPartialComponent : ViewComponent
    {
        private readonly IUserApiService _userApiService;
        private readonly IUserService _userService;

        public _ProfileInformationPartialComponent(IUserApiService userApiService, IUserService userService)
        {
            _userApiService = userApiService;
            _userService = userService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userApiService.GetUserAsync(_userService.AccessToken);
            return View(user.Data);
        }
    }
}
