using Microsoft.AspNetCore.Mvc;

namespace TraversolCoreProje.WebUI.Controllers
{
    public class ErrorPage : Controller
    {
        public IActionResult Error404(int code)
        {

            return View();
        }
    }
}
