using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversolCoreProje.WebUI.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly IContactReadApiService _contactReadApiService;
        private readonly IUserService _userService;
        private readonly IContactUsCommandApiService _contactCommandApiService;

        public ContactUsController(IContactReadApiService contactReadApiService, IUserService userService, IContactUsCommandApiService contactCommandApiService)
        {
            _contactReadApiService = contactReadApiService;
            _userService = userService;
            _contactCommandApiService = contactCommandApiService;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _contactReadApiService.GetAllAsync(_userService.AccessToken);


            return View(data.Data.FirstOrDefault());
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateContactUsViewModel createContactUsViewModel)
        {
            if (!ModelState.IsValid)
                return RedirectToAction(nameof(Index));
            var response = await _contactCommandApiService.CreateAsync(createContactUsViewModel, _userService.AccessToken);
            if (response.StatusCode == StatusCodes.Status201Created)
            {
                return RedirectToAction(nameof(Index));
            }

            foreach (var item in response.Errors)
            {
                ModelState.AddModelError("", item);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
