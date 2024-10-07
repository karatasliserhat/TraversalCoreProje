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
            _dataProtector = dataProtectionProvider.CreateProtector(nameof(DestinationController));
            _userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _destinationReadApiService.GetAllAsync(_userService.AccessToken);
            if (response.Data is null)
            {
                ViewBag.Error = response.Errors.FirstOrDefault();
                return null;
            }
            response.Data.ForEach(x => x.DataProtect = _dataProtector.Protect(x.Id.ToString()));
            return View(response.Data);
        }

        public async Task<IActionResult> DestinationDetail(string dataId)
        {
         
            var id = int.Parse(_dataProtector.Unprotect(dataId));
            ViewBag.DataId = id;
            var response = await _destinationReadApiService.GetByIdAsync(id, _userService.AccessToken);
            return View(response.Data);

        }

    }
}
