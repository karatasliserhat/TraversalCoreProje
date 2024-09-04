using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversolCoreProje.WebUI.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentCommandApiService _commentCommandApiService;
        private readonly IUserService _userService;
        private readonly IDataProtector _dataProtector;
        public CommentController(ICommentCommandApiService commentCommandApiService, IDataProtectionProvider dataProtectionProvider, IUserService userService)
        {
            _dataProtector = dataProtectionProvider.CreateProtector("DestinationController");
            _commentCommandApiService = commentCommandApiService;
            _userService = userService;
        }
        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> AddComment(CreateCommentViewModel createCommentViewModel)
        {
            if (!ModelState.IsValid)
                return View();
            createCommentViewModel.Status = true;
            createCommentViewModel.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            var result = await _commentCommandApiService.CreateAsync(createCommentViewModel, "");
            if (result.StatusCode == StatusCodes.Status201Created)
                return RedirectToAction(nameof(DestinationController.DestinationDetail), "Destination", new { dataId = _dataProtector.Protect(createCommentViewModel.DestinationId.ToString()) });
            ModelState.AddModelError("", result.Error);
            return RedirectToAction(nameof(DestinationController.DestinationDetail), "Destination", new { dataId = _dataProtector.Protect(createCommentViewModel.DestinationId.ToString()) });
        }
    }
}
