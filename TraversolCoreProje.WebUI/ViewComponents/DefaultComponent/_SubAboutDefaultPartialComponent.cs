using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Shared.Interfaces;

namespace TraversolCoreProje.WebUI.ViewComponents.DefaultComponent
{
    public class _SubAboutDefaultPartialComponent : ViewComponent
    {
        private readonly IUserService _userService;
        private readonly ISubAboutReadApiServices _subAboutReadApiServices;

        public _SubAboutDefaultPartialComponent(IUserService userService, ISubAboutReadApiServices subAboutReadApiServices)
        {
            _userService = userService;
            _subAboutReadApiServices = subAboutReadApiServices;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _subAboutReadApiServices.GetAllAsync(_userService.AccessToken);
            if (values.Data is { Count: < 1 })
            {
                ViewBag.Error = values.Errors.FirstOrDefault();
                return View(values.Errors.FirstOrDefault());

            }

            return View(values.Data);
        }
    }
}
