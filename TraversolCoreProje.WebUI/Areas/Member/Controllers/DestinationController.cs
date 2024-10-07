using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Shared.Interfaces;

namespace TraversolCoreProje.WebUI.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[Controller]/[Action]")]
    public class DestinationController : Controller
    {
        private readonly IDestinationReadApiService _destinationReadApiService;
        private readonly IDataProtector _dataProtector;
        private readonly IUserService _userService;
        public DestinationController(IDestinationReadApiService destinationReadApiService, IDataProtectionProvider dataProtectionProvider, IUserService userService)
        {
            _dataProtector = dataProtectionProvider.CreateProtector(nameof(DestinationController));
            _destinationReadApiService = destinationReadApiService;
            _userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _destinationReadApiService.GetAllAsync(_userService.AccessToken);
            response.Data.ForEach(x => x.DataProtect = _dataProtector.Protect(x.Id.ToString()));
            return View(response.Data);
        }
    }
}
