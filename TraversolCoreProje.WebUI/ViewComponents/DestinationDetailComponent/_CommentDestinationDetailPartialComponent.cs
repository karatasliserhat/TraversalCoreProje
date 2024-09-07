using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Shared.Interfaces;

namespace TraversolCoreProje.WebUI.ViewComponents.DestinationDetailComponent
{
    public class _CommentDestinationDetailPartialComponent : ViewComponent
    {
        private readonly ICommentReadApiService _commentReadApiService;
        private readonly IUserService _userService;
        public _CommentDestinationDetailPartialComponent(ICommentReadApiService commentReadApiService,  IUserService userService)
        {
            _commentReadApiService = commentReadApiService;
            _userService = userService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int DataId)
        {
      
            var result = await _commentReadApiService.GetCommentListByDestinationId(DataId, _userService.AccessToken);
            return View(result.Data);
        }

    }
}
