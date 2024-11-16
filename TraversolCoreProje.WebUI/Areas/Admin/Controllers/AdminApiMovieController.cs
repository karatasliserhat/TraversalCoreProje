using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Shared.Interfaces;

namespace TraversolCoreProje.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[Controller]/[Action]")]
    public class AdminApiMovieController : Controller
    {

        private readonly IMovieApiReadService _movieApiReadService;

        public AdminApiMovieController(IMovieApiReadService movieApiReadService)
        {
            _movieApiReadService = movieApiReadService;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _movieApiReadService.GetTop100Movie();
            return View(response);
        }
    }
}
