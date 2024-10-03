using Microsoft.AspNetCore.Mvc;

namespace TraversolCoreProje.WebUI.ViewComponents.AdminDashboardComponent
{
    public class _AdminDashboardBannerPartialComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
