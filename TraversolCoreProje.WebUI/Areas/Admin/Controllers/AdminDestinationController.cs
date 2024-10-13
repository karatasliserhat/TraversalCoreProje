using AutoMapper;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;
using TraversolCoreProje.WebUI.Areas.Member.Controllers;

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
        private readonly IMapper _mapper;
        public AdminDestinationController(IDestinationReadApiService destinationReadApiService, IDestinationCommandApiService destinationCommandApiService, IUserService userService, IDataProtectionProvider dataProtectionProvider, IMapper mapper)
        {
            _destinationReadApiService = destinationReadApiService;
            _destinationCommandApiService = destinationCommandApiService;
            _userService = userService;
            _dataProtector = dataProtectionProvider.CreateProtector(nameof(DestinationController));
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new UpdateDestinationViewModel());
        }
        public async Task<JsonResult> GetDestinations()
        {
            var data = await _destinationReadApiService.GetAllAsync(_userService.AccessToken);
            data.Data.ForEach(x => x.DataProtect = _dataProtector.Protect(x.Id.ToString()));
            return Json(data.Data);
        }

        [HttpPost]
        public async Task<JsonResult> Create(UpdateDestinationViewModel updateDestinationViewModel)
        {
            if (!ModelState.IsValid)
            {
                var allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return Json(new { success = false, Errors = allErrors });
            }

            var result = await _destinationCommandApiService.CreateAsync(_mapper.Map<CreateDestinationViewModel>(updateDestinationViewModel), _userService.AccessToken);
            if (result.StatusCode == StatusCodes.Status201Created)
            {
                return Json("Rota Kaydedildi");
            }
            result.Errors.ForEach(x =>
            {
                ModelState.AddModelError("", x);
            });
            return Json(updateDestinationViewModel);

        }

        [HttpGet]
        public async Task<JsonResult> Update(string dataId)
        {
            var id = int.Parse(_dataProtector.Unprotect(dataId));
            var result = await _destinationCommandApiService.UpdateGetByIdAsync(id, _userService.AccessToken);
            return Json(result.Data);
        }
        [HttpPost]
        public async Task<JsonResult> Update(UpdateDestinationViewModel updateDestinationViewModel)
        {
            if (!ModelState.IsValid)
            {
                var allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return Json(new { success = false, Errors = allErrors });
            }
               
            var result = await _destinationCommandApiService.UpdateAsync(updateDestinationViewModel, _userService.AccessToken);
            if (result.StatusCode == StatusCodes.Status204NoContent)
                return Json("Rota Güncellendi");
            result.Errors.ForEach(x => { ModelState.AddModelError("", x); });
            return Json("Rota Güncellenemedi");
        }
        [HttpPost]
        public async Task<JsonResult> Delete(string dataId)
        {
            var id = int.Parse(_dataProtector.Unprotect(dataId));
            var result = await _destinationCommandApiService.DeleteAsync(id, _userService.AccessToken);
            if (result.StatusCode == StatusCodes.Status204NoContent)
            {
                return Json("Rota Silindi");
            }
            result.Errors.ForEach(x => { ModelState.AddModelError("", x); });
            return Json("Rota Silinemedi");
        }
    }
}
