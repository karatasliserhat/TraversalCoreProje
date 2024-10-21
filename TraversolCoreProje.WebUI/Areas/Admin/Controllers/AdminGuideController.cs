using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversolCoreProje.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[Controller]/[Action]")]
    public class AdminGuideController : Controller
    {
        private readonly IGuideReadApiService _guideReadApiService;
        private readonly IGuideCommandApiService _guideCommandApiService;
        private readonly IUserService _userService;
        private readonly IDataProtector _dataProtector;
        public AdminGuideController(IGuideReadApiService guideReadApiService, IGuideCommandApiService guideCommandApiService, IUserService userService, IDataProtectionProvider dataProtector)
        {
            _guideReadApiService = guideReadApiService;
            _guideCommandApiService = guideCommandApiService;
            _userService = userService;
            _dataProtector = dataProtector.CreateProtector("GuideController");
        }

        public async Task<IActionResult> Index()
        {
            var dataGuides = await _guideReadApiService.GetAllAsync(_userService.AccessToken);
            dataGuides.Data.ForEach(x => x.DataProtect = _dataProtector.Protect(x.Id.ToString()));
            return View(dataGuides.Data);
        }

        public IActionResult Create()
        {
            return View(new CreateGuideViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateGuideViewModel createGuideViewModel)
        {
            if (!ModelState.IsValid)
                return View(createGuideViewModel);
            var result = await _guideCommandApiService.CreateAsync(createGuideViewModel, _userService.AccessToken);
            if (result.StatusCode == StatusCodes.Status201Created)
            {
                return RedirectToAction(nameof(Index));
            }
            result.Errors.ForEach(x =>
            {
                ModelState.AddModelError("", x);
            });
            return View(createGuideViewModel);

        }

        public async Task<IActionResult> Update(string dataId)
        {
            var id = int.Parse(_dataProtector.Unprotect(dataId));
            var result = await _guideCommandApiService.UpdateGetByIdAsync(id, _userService.AccessToken);
            return View(result.Data);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateGuideViewModel updateGuideViewModel)
        {
            if (!ModelState.IsValid)
                return View(updateGuideViewModel);
            var result = await _guideCommandApiService.UpdateAsync(updateGuideViewModel, _userService.AccessToken);
            if (result.StatusCode == StatusCodes.Status204NoContent)
                return RedirectToAction(nameof(Index));
            result.Errors.ForEach(x => { ModelState.AddModelError("", x); });
            return View(updateGuideViewModel);
        }
        public async Task<IActionResult> Delete(string dataId)
        {
            var id = int.Parse(_dataProtector.Unprotect(dataId));
            var result = await _guideCommandApiService.DeleteAsync(id, _userService.AccessToken);
            if (result.StatusCode == StatusCodes.Status204NoContent)
            {
                return RedirectToAction(nameof(Index));
            }
            result.Errors.ForEach(x => { ModelState.AddModelError("", x); });
            return View();
        }
        public async Task<IActionResult> ChangeToTrue(string dataId)
        {
            var id = int.Parse(_dataProtector.Unprotect(dataId));
            var result = await _guideCommandApiService.GuideStatusChange("GuideStatusTrue", id);
            if (result.StatusCode == StatusCodes.Status204NoContent)
                return RedirectToAction(nameof(Index));
            result.Errors.ForEach(x => { ModelState.AddModelError("", x); });
            return View();
        }
        public async Task<IActionResult> ChangeToFalse(string dataId)
        {
            var id = int.Parse(_dataProtector.Unprotect(dataId));
            var result = await _guideCommandApiService.GuideStatusChange("GuideStatusFalse", id);
            if (result.StatusCode == StatusCodes.Status204NoContent)
                return RedirectToAction(nameof(Index));
            result.Errors.ForEach(x => { ModelState.AddModelError("", x); });
            return View();
        }
    }
}
