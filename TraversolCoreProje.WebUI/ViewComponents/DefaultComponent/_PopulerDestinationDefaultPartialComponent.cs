using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Shared.Interfaces;

namespace TraversolCoreProje.WebUI.ViewComponents.DefaultComponent
{
    public class _PopulerDestinationDefaultPartialComponent : ViewComponent
    {
        private readonly IDestinationReadApiService _destinationReadApiService;
        private readonly IUserService _userService;
        public _PopulerDestinationDefaultPartialComponent(IDestinationReadApiService destinationReadApiService, IUserService userService)
        {
            _destinationReadApiService = destinationReadApiService;
            _userService = userService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var response = await _destinationReadApiService.GetAllAsync("");
            if (response.Data is { Count: < 1 })
                return View(response.Error);
            ViewBag.Error = response.Error;
            return View(response.Data);
        }
    }
}
