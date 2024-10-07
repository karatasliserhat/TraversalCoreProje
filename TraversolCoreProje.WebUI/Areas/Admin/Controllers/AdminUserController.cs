using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversolCoreProje.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[Controller]/[Action]")]
    public class AdminUserController : Controller
    {
        private readonly IUserApiService _userApiService;
        private readonly IUserService _userService;
        private readonly IDataProtector _dataProtector;
        private readonly IReservationReadApiService _reservationReadApiService;
        public AdminUserController(IUserApiService userApiService, IUserService userService, IDataProtectionProvider dataProtector, IReservationReadApiService reservationReadApiService)
        {
            _userApiService = userApiService;
            _userService = userService;
            _dataProtector = dataProtector.CreateProtector(nameof(AdminUserController));
            _reservationReadApiService = reservationReadApiService;
        }

        public async Task<IActionResult> Index()
        {
            var dataUser = await _userApiService.GetListUserAsync(_userService.AccessToken);
            dataUser.Data.ForEach(x => x.DataProtect = _dataProtector.Protect(x.Id.ToString()));
            return View(dataUser.Data);
        }

        public async Task<IActionResult> ReservationUser(string dataId)
        {
            var dataInt = int.Parse(_dataProtector.Unprotect(dataId));
            var userReservations = await _reservationReadApiService.GetAllAsync("GetMyOldReservation", dataInt, _userService.AccessToken);
            return View(userReservations.Data);
        }
        public async Task<IActionResult> Update(string dataId)
        {
            var id = int.Parse(_dataProtector.Unprotect(dataId));
            var result = await _userApiService.GetUserAsync(_userService.AccessToken, id);
            return View(result.Data);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UserEditViewModel userEditViewModel)
        {
            if (!ModelState.IsValid)
                return View(userEditViewModel);
            var result = await _userApiService.UserEditAsync(userEditViewModel, _userService.AccessToken);
            if (result.StatusCode == StatusCodes.Status204NoContent)
                return RedirectToAction(nameof(Index));
            result.Errors.ForEach(x => { ModelState.AddModelError("", x); });
            return View(userEditViewModel);
        }
        public async Task<IActionResult> Delete(string dataId)
        {
            var id = int.Parse(_dataProtector.Unprotect(dataId));
            var result = await _userApiService.DeleteUserAsync(id, _userService.AccessToken);
            if (result.StatusCode == StatusCodes.Status204NoContent)
            {
                return RedirectToAction(nameof(Index));
            }
            result.Errors.ForEach(x => { ModelState.AddModelError("", x); });
            return View();
        }
    }
}