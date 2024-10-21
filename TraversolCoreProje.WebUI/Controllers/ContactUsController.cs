using Microsoft.AspNetCore.Mvc;

namespace TraversolCoreProje.WebUI.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
