using Microsoft.AspNetCore.Mvc;

namespace TraversolCoreProje.WebUI.ViewComponents.AdminDashboardComponent
{
    public class _AdminDashboardGuideListPartialComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
