using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Shared.Interfaces;

namespace TraversolCoreProje.WebUI.ViewComponents.DefaultComponent
{
    public class _TestimonialDefaultPartialComponent : ViewComponent
    {
        private readonly IUserService _userService;
        private readonly ITestimonialReadApiServices _testimonialReadApiServices;

        public _TestimonialDefaultPartialComponent(IUserService userService, ITestimonialReadApiServices estimonialReadApiServices)
        {
            _userService = userService;
            _testimonialReadApiServices = estimonialReadApiServices;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _testimonialReadApiServices.GetAllAsync(_userService.AccessToken);
            if (values.Data is { Count: < 1 })
            {
                ViewBag.Error = values.Errors.FirstOrDefault();
                return View(values.Errors.FirstOrDefault());
            }
            return View(values.Data);
        }
    }
}
