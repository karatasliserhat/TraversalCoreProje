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

            var response = await _destinationReadApiService.GetAllAsync(_userService.AccessToken);
            if (response.Data is { Count: < 1 })
            {
                ViewBag.Error = response.Errors.FirstOrDefault();
                return View(response.Errors.FirstOrDefault());
                
            }
            return View(response.Data);
        }
    }
}
