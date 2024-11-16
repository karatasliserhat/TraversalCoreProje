using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Shared.Interface;

namespace TraversolCoreProje.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[Controller]/[Action]")]
    public class AdminBookingHotelSearchController : Controller
    {
        private readonly IBookingHotelSearchReadApiService _bookingHotelSearchReadApiService;

        public AdminBookingHotelSearchController(IBookingHotelSearchReadApiService bookingHotelSearchReadApiService)
        {
            _bookingHotelSearchReadApiService = bookingHotelSearchReadApiService;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _bookingHotelSearchReadApiService.GetAllBookingHotelList();
            return View(response);
        }
    }
}
