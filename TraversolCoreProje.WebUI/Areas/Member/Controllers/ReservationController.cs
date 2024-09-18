using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversolCoreProje.WebUI.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[Controller]/[Action]")]
    public class ReservationController : Controller
    {
        private readonly IDataProtector _dataProtector;
        private readonly IReservationReadApiService _reservationReadApiService;
        private readonly IReservationCommandApiService _reservationCommandApiService;
        private readonly IDestinationReadApiService _destinationReadApiService;
        private readonly IUserService _userService;
        public ReservationController(IReservationReadApiService reservationReadApiService, IReservationCommandApiService reservationCommandApiService, IDestinationReadApiService destinationReadApiService, IDataProtectionProvider protectProvider, IUserService userService)
        {
            _dataProtector = protectProvider.CreateProtector(nameof(ReservationController));
            _reservationReadApiService = reservationReadApiService;
            _reservationCommandApiService = reservationCommandApiService;
            _destinationReadApiService = destinationReadApiService;
            _userService = userService;
        }

        private async Task GetDestination()
        {
            var data = await _destinationReadApiService.GetAllAsync(_userService.AccessToken);

            var selectList = new SelectList(data.Data, "Id", "City");
            ViewBag.DestinationCity = selectList;

            //var selectListItem = from x in data.Data
            //                     select new SelectListItem
            //                     {
            //                         Text = x.City,
            //                         Value = x.Id.ToString()
            //                     };
            //StatusL =Onay Bekliyor
        }
       private int getUserId()
        {
            return int.Parse(_userService.GetUser);
        }
        [HttpGet]
        public async Task<IActionResult> MyCurrentReservation()
        {
            var data = await _reservationReadApiService.GetAllAsync("GetMyCurrentReservation", getUserId(), _userService.AccessToken);
            return View(data.Data);
        }
        [HttpGet]
        public async Task<IActionResult> MyOldReservation()
        {
            //GEçmiş Rezervasyonlarım
            var data = await _reservationReadApiService.GetAllAsync("GetMyOldReservation", getUserId(), _userService.AccessToken);
            return View(data.Data);
        }

        [HttpGet]
        public async Task<IActionResult> MyApprovalReservation()
        {
            //Onay Bekleyen Rezervasyonlarım
            var data = await _reservationReadApiService.GetAllAsync("GetMyApprovedReservation", getUserId(), _userService.AccessToken);
            return View(data.Data);
        }

        [HttpGet]
        public async Task<IActionResult> NewReservation()
        {
            await GetDestination();
            return View(new CreateReservationViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> NewReservation(CreateReservationViewModel createReservationViewModel)
        {
            if (!ModelState.IsValid)
            {
                await GetDestination();
                return View(createReservationViewModel);
            }
            createReservationViewModel.AppUserId = int.Parse(_userService.GetUser);
            var response = await _reservationCommandApiService.CreateAsync(createReservationViewModel, _userService.AccessToken);
            if (response.StatusCode == StatusCodes.Status201Created)
            {
                return RedirectToAction(nameof(MyApprovalReservation));
            }
            foreach (var item in response.Errors)
            {
                ModelState.AddModelError("", item);

            }
            await GetDestination();
            return View(createReservationViewModel);
        }
    }
}
