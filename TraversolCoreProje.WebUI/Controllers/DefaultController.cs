using Microsoft.AspNetCore.Mvc;

namespace TraversolCoreProje.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
