using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversolCoreProje.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[Controller]/[Action]")]
    public class AdminVisitorController : Controller
    {
        private readonly IVisitorReadApiService _VisitorReadApiService;
        private readonly IVisitorCommandApiService _VisitorCommandApiService;
        private readonly IUserService _userService;
        private readonly IDataProtector _dataProtector;
        public AdminVisitorController(IVisitorReadApiService VisitorReadApiService, IVisitorCommandApiService VisitorCommandApiService, IUserService userService, IDataProtectionProvider dataProtectionProvider)
        {
            _VisitorReadApiService = VisitorReadApiService;
            _VisitorCommandApiService = VisitorCommandApiService;
            _userService = userService;
            _dataProtector = dataProtectionProvider.CreateProtector(nameof(AdminVisitorController));
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            //var data = await _VisitorReadApiService.GetAllAsync(_userService.AccessToken);
            //data.Data.ForEach(x => x.DataProtect = _dataProtector.Protect(x.Id.ToString()));
            //return View(data.Data);
            return View();
        }

        [HttpGet]
        public IActionResult CreateVisitor()
        {

            return View(new CreateVisitorViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> CreateVisitor(CreateVisitorViewModel createVisitorViewModel)
        {
            if (!ModelState.IsValid)
            {

                return View(createVisitorViewModel);
            }

            var result = await _VisitorCommandApiService.CreateAsync(createVisitorViewModel, _userService.AccessToken);
            if (result.StatusCode == StatusCodes.Status201Created)
            {
                return RedirectToAction(nameof(Index));
            }
            result.Errors.ForEach(x =>
            {
                ModelState.AddModelError("", x);
            });
            return View(createVisitorViewModel);

        }

        [HttpGet]
        public async Task<IActionResult> Update(string dataId)
        {
            var id = int.Parse(_dataProtector.Unprotect(dataId));
            var result = await _VisitorCommandApiService.UpdateGetByIdAsync(id, _userService.AccessToken);
            return View(result.Data);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateVisitorViewModel updateVisitorViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(updateVisitorViewModel);
            }

            var result = await _VisitorCommandApiService.UpdateAsync(updateVisitorViewModel, _userService.AccessToken);
            if (result.StatusCode == StatusCodes.Status204NoContent)
                return RedirectToAction(nameof(Index));
            result.Errors.ForEach(x => { ModelState.AddModelError("", x); });
            return View(updateVisitorViewModel);
        }
        public async Task<IActionResult> Delete(string dataId)
        {
            var id = int.Parse(_dataProtector.Unprotect(dataId));
            var result = await _VisitorCommandApiService.DeleteAsync(id, _userService.AccessToken);
            if (result.StatusCode == StatusCodes.Status204NoContent)
            {
                return RedirectToAction(nameof(Index));
            }
            result.Errors.ForEach(x => { ModelState.AddModelError("", x); });
            return View();
        }
    }
}
