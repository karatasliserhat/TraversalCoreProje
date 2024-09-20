using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Shared.Interfaces;

namespace TraversolCoreProje.WebUI.ViewComponents.MemberDashboardComponent
{
    public class _GuideListPartialComponent:ViewComponent
    {
        private readonly IGuideReadApiService _guideReadApiService;
        private readonly IUserService _userService;
        public _GuideListPartialComponent(IGuideReadApiService guideReadApiService, IUserService userService)
        {
            _guideReadApiService = guideReadApiService;
            _userService = userService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var guide = await _guideReadApiService.GetAllAsync(_userService.AccessToken);
            return View(guide.Data);
        }
    }
}
