using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Shared.Interfaces;

namespace TraversolCoreProje.WebUI.ViewComponents.DefaultComponent
{
    public class _FeatureDefaultPartialComponent : ViewComponent
    {
        private readonly IFeatureReadApiService _featureReadApiService;
        private readonly IUserService _userService;
        public _FeatureDefaultPartialComponent(IFeatureReadApiService featureReadApiService, IUserService userService)
        {
            _featureReadApiService = featureReadApiService;
            _userService = userService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _featureReadApiService.GetAllAsync(_userService.AccessToken);
            values.Data.FirstOrDefault();
            ViewBag.Images=values.Data.FirstOrDefault().Image;
            ViewBag.Title = values.Data.FirstOrDefault().Title;
            ViewBag.Description = values.Data.FirstOrDefault().Description;
            if (values.Data is { Count: < 1 })
            {
                ViewBag.Error = values.Errors.FirstOrDefault();
                return View(values.Errors.FirstOrDefault());
            }
            return View(values.Data);
        }
    }
}
