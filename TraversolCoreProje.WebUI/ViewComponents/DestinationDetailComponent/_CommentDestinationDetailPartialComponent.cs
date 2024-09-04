using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Shared.Interfaces;

namespace TraversolCoreProje.WebUI.ViewComponents.DestinationDetailComponent
{
    public class _CommentDestinationDetailPartialComponent : ViewComponent
    {
        private readonly ICommentReadApiService _commentReadApiService;
        private readonly IDataProtector _dataProtector;
        private readonly IUserService _userService;
        public _CommentDestinationDetailPartialComponent(ICommentReadApiService commentReadApiService, IDataProtectionProvider dataProtectionProvider, IUserService userService)
        {
            _dataProtector = dataProtectionProvider.CreateProtector("DestinationController");
            _commentReadApiService = commentReadApiService;
            _userService = userService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string DataId)
        {
            var id = int.Parse(_dataProtector.Unprotect(DataId));
            var result = await _commentReadApiService.GetCommentListByDestinationId(id, string.Empty);
            return View(result.Data);
        }

    }
}
