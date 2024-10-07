using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TraversolCoreProje.WebUI.Models;

namespace TraversolCoreProje.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Home Index Çağrıldı");
            _logger.LogError("Home Index Hata");
            return View();
        }

        public IActionResult Privacy()
        {
            var date = DateTime.Now.ToLongDateString();
            _logger.LogInformation(date + "Home Privacy Çağrıldı");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
