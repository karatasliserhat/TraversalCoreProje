using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Shared.Interfaces;

namespace TraversolCoreProje.WebUI.ViewComponents.AdminDashboardComponent
{
    public class _AdminDashboardCards1StatisticPartialComponent : ViewComponent
    {
        private readonly IDestinationReadApiService _destinationReadApiService;
        private readonly IReservationReadApiService _reservationReadApiService;
        private readonly IUserService _userService;
        public _AdminDashboardCards1StatisticPartialComponent(IDestinationReadApiService destinationReadApiService, IUserService userService, IReservationReadApiService reservationReadApiService)
        {
            _destinationReadApiService = destinationReadApiService;
            _reservationReadApiService = reservationReadApiService;
            _userService = userService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var destinationCount = await _destinationReadApiService.GetAllAsync(_userService.AccessToken);
            ViewBag.DestinationCount = destinationCount.Data.Count;
            var reservationCount = await _reservationReadApiService.GetAllAsync("GetAllReservation", _userService.AccessToken);
            ViewBag.ReservationCount = reservationCount.Data.Count;
            return View();
        }
    }
}
