using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Shared.Interfaces;

namespace TraversolCoreProje.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[Controller]/[Action]")]
    public class AdminReportController : Controller
    {
        private readonly IExcelReportApiService _excelReportApiService;

        public AdminReportController(IExcelReportApiService excelReportApiService)
        {
            _excelReportApiService = excelReportApiService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetDestinationExcelReport()
        {
            await _excelReportApiService.GetListDestinationExcelReport();
            return RedirectToAction(nameof(Index));
        }
    }
}
