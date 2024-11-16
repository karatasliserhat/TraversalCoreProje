using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Shared.Interfaces;

namespace TraversolCoreProje.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[Controller]/[Action]")]
    public class AdminBookingExchangeController : Controller
    {
        private readonly IBookingExchangeReadApiServices _bookingExchangeReadApiServices;

        public AdminBookingExchangeController(IBookingExchangeReadApiServices bookingExchangeReadApiServices)
        {
            _bookingExchangeReadApiServices = bookingExchangeReadApiServices;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _bookingExchangeReadApiServices.BookingExchangeList();
            return View(response.data);
        }
    }
}
