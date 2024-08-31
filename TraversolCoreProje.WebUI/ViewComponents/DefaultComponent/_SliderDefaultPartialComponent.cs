using Microsoft.AspNetCore.Mvc;

namespace TraversolCoreProje.WebUI.ViewComponents.DefaultComponent
{
    public class _SliderDefaultPartialComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
