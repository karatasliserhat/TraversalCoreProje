using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Shared.Interfaces;

namespace TraversolCoreProje.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[Controller]/[Action]")]
    public class AdminContactUsController : Controller
    {
        private readonly IContactUsReadApiService _contactUsReadApiService;
        private readonly IUserService _userService;
        private readonly IDataProtector _dataProtector;
        public AdminContactUsController(IContactUsReadApiService contactUsReadApiService, IUserService userService, IDataProtectionProvider dataProtector)
        {
            _contactUsReadApiService = contactUsReadApiService;
            _userService = userService;
            _dataProtector = dataProtector.CreateProtector("ContactUsController");
        }

        public async Task<IActionResult> Index()
        {
            var datas = await _contactUsReadApiService.GetAllAsync("ContactUsListTrue", _userService.AccessToken);
            datas.Data.ForEach(x => x.DataProtect = _dataProtector.Protect(x.Id.ToString()));
            return View(datas.Data);

        }
        public async Task<IActionResult> ContatUsChangeStatusFalse(string dataId)
        {
            var contactUsId = int.Parse(_dataProtector.Unprotect(dataId));
            var response = await _contactUsReadApiService.GetContatUsStatusChangeFalse(contactUsId);
            if (response.StatusCode == StatusCodes.Status204NoContent)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
