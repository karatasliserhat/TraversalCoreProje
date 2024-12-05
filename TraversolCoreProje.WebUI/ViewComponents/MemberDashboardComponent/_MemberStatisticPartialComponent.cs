using Microsoft.AspNetCore.Mvc;

namespace TraversolCoreProje.WebUI.ViewComponents.MemberDashboardComponent
{
    public class _MemberStatisticPartialComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        } 
    }
}
