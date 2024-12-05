using Microsoft.AspNetCore.Mvc;

namespace TraversolCoreProje.WebUI.ViewComponents.MemberDashboardComponent
{
    public class _MemberLayoutNavbarUlPartialComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
