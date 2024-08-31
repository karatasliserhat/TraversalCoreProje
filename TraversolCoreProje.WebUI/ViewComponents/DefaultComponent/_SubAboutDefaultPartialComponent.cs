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
            var values = await _subAboutReadApiServices.GetAllAsync("");
            if (values.Data is { Count: < 1 })
                return View(values.Error);
            ViewBag.Error = values.Error;
            return View(values.Data);
        }
    }
}
