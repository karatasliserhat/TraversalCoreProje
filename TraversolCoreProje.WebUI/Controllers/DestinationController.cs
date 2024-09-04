using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Shared.Interfaces;

namespace TraversolCoreProje.WebUI.Controllers
{
    public class DestinationController : Controller
    {
        private readonly IDestinationReadApiService _destinationReadApiService;
        private readonly IDataProtector _dataProtector;
        private readonly IUserService _userService;
        public DestinationController(IDestinationReadApiService destinationReadApiService, IDataProtectionProvider dataProtectionProvider, IUserService userService)
        {
            _destinationReadApiService = destinationReadApiService;
            _dataProtector = dataProtectionProvider.CreateProtector("DestinationController");
            _userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _destinationReadApiService.GetAllAsync("");
            if (response.Data is null)
            {
                ViewBag.Error = response.Error;
                return null;
            }
            response.Data.ForEach(x => x.DataProtect = _dataProtector.Protect(x.Id.ToString()));
            return View(response.Data);
        }

        public async Task<IActionResult> DestinationDetail(string dataId)
        {
            ViewBag.DataId = dataId;
            var id = int.Parse(_dataProtector.Unprotect(dataId));
            var response = await _destinationReadApiService.GetByIdAsync(id, "");
            return View(response.Data);

        }

    }
}
