using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversolCoreProje.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[Controller]/[Action]")]
    public class AdminDestinationController : Controller
    {
        private readonly IDestinationReadApiService _destinationReadApiService;
        private readonly IDestinationCommandApiService _destinationCommandApiService;
        private readonly IUserService _userService;
        private readonly IDataProtector _dataProtector;

        public AdminDestinationController(IDestinationReadApiService destinationReadApiService, IDestinationCommandApiService destinationCommandApiService, IUserService userService, IDataProtectionProvider dataProtectionProvider)
        {
            _destinationReadApiService = destinationReadApiService;
            _destinationCommandApiService = destinationCommandApiService;
            _userService = userService;
            _dataProtector = dataProtectionProvider.CreateProtector(nameof(AdminDestinationController));
        }

        public async Task<IActionResult> Index()
        {
            var data = await _destinationReadApiService.GetAllAsync(_userService.AccessToken);
            data.Data.ForEach(x => x.DataProtect = _dataProtector.Protect(x.Id.ToString()));
            return View(data.Data);
        }
        public IActionResult Create()
        {
            return View(new CreateDestinationViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateDestinationViewModel createDestinationViewModel)
        {
            if (!ModelState.IsValid)
                return View(createDestinationViewModel);
            var result = await _destinationCommandApiService.CreateAsync(createDestinationViewModel, _userService.AccessToken);
            if (result.StatusCode == StatusCodes.Status201Created)
            {
                return RedirectToAction(nameof(Index));
            }
            result.Errors.ForEach(x =>
            {
                ModelState.AddModelError("", x);
            });
            return View(createDestinationViewModel);

        }

        public async Task<IActionResult> Update(string dataId)
        {
            var id = int.Parse(_dataProtector.Unprotect(dataId));
            var result = await _destinationCommandApiService.UpdateGetByIdAsync(id, _userService.AccessToken);
            return View(result.Data);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateDestinationViewModel updateDestinationViewModel)
        {
            if (!ModelState.IsValid)
                return View(updateDestinationViewModel);
            var result = await _destinationCommandApiService.UpdateAsync(updateDestinationViewModel, _userService.AccessToken);
            if (result.StatusCode == StatusCodes.Status204NoContent)
                return RedirectToAction(nameof(Index));
            result.Errors.ForEach(x => { ModelState.AddModelError("", x); });
            return View(updateDestinationViewModel);
        }
        public async Task<IActionResult> Delete(string dataId)
        {
            var id = int.Parse(_dataProtector.Unprotect(dataId));
            var result = await _destinationCommandApiService.DeleteAsync(id, _userService.AccessToken);
            if (result.StatusCode==StatusCodes.Status204NoContent)
            {
                return RedirectToAction(nameof(Index));
            }
            result.Errors.ForEach(x => { ModelState.AddModelError("", x); });
            return View();
        }
    }
}
