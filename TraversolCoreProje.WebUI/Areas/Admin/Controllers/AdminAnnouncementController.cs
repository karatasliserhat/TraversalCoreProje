using AutoMapper;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversolCoreProje.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[Controller]/[Action]")]
    public class AdminAnnouncementController : Controller
    {
        private readonly IAnnouncementReadApiService _AnnouncementReadApiService;
        private readonly IAnnouncementCommandApiService _AnnouncementCommandApiService;
        private readonly IUserService _userService;
        private readonly IDataProtector _dataProtector;
        private readonly IMapper _mapper;
        public AdminAnnouncementController(IAnnouncementReadApiService AnnouncementReadApiService, IAnnouncementCommandApiService AnnouncementCommandApiService, IUserService userService, IDataProtectionProvider dataProtectionProvider, IMapper mapper)
        {
            _AnnouncementReadApiService = AnnouncementReadApiService;
            _AnnouncementCommandApiService = AnnouncementCommandApiService;
            _userService = userService;
            _dataProtector = dataProtectionProvider.CreateProtector(nameof(AdminAnnouncementController));
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var data = await _AnnouncementReadApiService.GetAllAsync(_userService.AccessToken);
            data.Data.ForEach(x => x.DataProtect = _dataProtector.Protect(x.Id.ToString()));
            return View(data.Data);
        }

        [HttpGet]
        public IActionResult CreateAnnouncement()
        {

            return View(new CreateAnnouncementViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> CreateAnnouncement(CreateAnnouncementViewModel createAnnouncementViewModel)
        {
            if (!ModelState.IsValid)
            {

                return View(createAnnouncementViewModel);
            }

            var result = await _AnnouncementCommandApiService.CreateAsync(_mapper.Map<CreateAnnouncementViewModel>(createAnnouncementViewModel), _userService.AccessToken);
            if (result.StatusCode == StatusCodes.Status201Created)
            {
                return RedirectToAction(nameof(Index));
            }
            result.Errors.ForEach(x =>
            {
                ModelState.AddModelError("", x);
            });
            return View(createAnnouncementViewModel);

        }

        [HttpGet]
        public async Task<IActionResult> Update(string dataId)
        {
            var id = int.Parse(_dataProtector.Unprotect(dataId));
            var result = await _AnnouncementCommandApiService.UpdateGetByIdAsync(id, _userService.AccessToken);
            return View(result.Data);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateAnnouncementViewModel updateAnnouncementViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(updateAnnouncementViewModel);
            }

            var result = await _AnnouncementCommandApiService.UpdateAsync(updateAnnouncementViewModel, _userService.AccessToken);
            if (result.StatusCode == StatusCodes.Status204NoContent)
                return RedirectToAction(nameof(Index));
            result.Errors.ForEach(x => { ModelState.AddModelError("", x); });
            return View(updateAnnouncementViewModel);
        }
        public async Task<IActionResult> Delete(string dataId)
        {
            var id = int.Parse(_dataProtector.Unprotect(dataId));
            var result = await _AnnouncementCommandApiService.DeleteAsync(id, _userService.AccessToken);
            if (result.StatusCode == StatusCodes.Status204NoContent)
            {
                return RedirectToAction(nameof(Index));
            }
            result.Errors.ForEach(x => { ModelState.AddModelError("", x); });
            return View();
        }
    }
}
