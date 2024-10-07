using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Shared.Interfaces;
using TraversolCoreProje.WebUI.Controllers;

namespace TraversolCoreProje.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[Controller]/[Action]")]
    public class AdminCommentController : Controller
    {
        private readonly ICommentReadApiService _commentReadApiService;
        private readonly ICommentCommandApiService _commentCommandApiService;
        private readonly IUserService _userService;
        private readonly IDataProtector _dataProtector;
        public AdminCommentController(ICommentReadApiService commentReadApiService, IDataProtectionProvider dataProtector, IUserService userService, ICommentCommandApiService commentCommandApiService)
        {
            _commentReadApiService = commentReadApiService;
            _dataProtector = dataProtector.CreateProtector(nameof(CommentController));
            _userService = userService;
            _commentCommandApiService = commentCommandApiService;
        }

        public async Task<IActionResult> Index()
        {
            var dataComment = await _commentReadApiService.GetAllAsync(_userService.AccessToken);
            dataComment.Data.ForEach(comment => { comment.DataProtect = _dataProtector.Protect(comment.Id.ToString()); });
            return View(dataComment.Data);
        }
        public async Task<IActionResult> Delete(string DataId)
        {
            var dataInt = int.Parse(_dataProtector.Unprotect(DataId));
            await _commentCommandApiService.DeleteAsync(dataInt,_userService.AccessToken);
            return RedirectToAction(nameof(Index));
        }
    }
}
