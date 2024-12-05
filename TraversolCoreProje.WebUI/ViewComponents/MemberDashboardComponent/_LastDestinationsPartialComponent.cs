using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Shared.Interfaces;

namespace TraversolCoreProje.WebUI.ViewComponents.MemberDashboardComponent
{
    public class _LastDestinationsPartialComponent : ViewComponent
    {
        private readonly IDestinationReadApiService _destinationReadApiService;
        private readonly IUserService _userService;

        public _LastDestinationsPartialComponent(IDestinationReadApiService destinationReadApiService, IUserService userService)
        {
            _destinationReadApiService = destinationReadApiService;
            _userService = userService;

        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = await _destinationReadApiService.GetAllAsync("GetLastFourDestination", _userService.AccessToken);
            return View(result.Data);
        }
    }
}
