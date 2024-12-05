using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.WebAPI.Controllers
{

    public class CommentsController : BaseController
    {
        private readonly ICommentReadService _CommentReadService;
        private readonly ICommentCommandService _CommentCommandService;

        public CommentsController(ICommentReadService CommentReadService, ICommentCommandService CommentCommandService)
        {
            _CommentReadService = CommentReadService;
            _CommentCommandService = CommentCommandService;
        }

        [HttpGet]
        public async Task<IActionResult> CommentList()
        {
            return CreateAction(await _CommentReadService.GetListWithDestinationCityAsync());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetComment(int id)
        {
            return CreateAction(await _CommentReadService.GetByIdAsync(id));
        }
        [HttpGet("[Action]/{id}")]
        public async Task<IActionResult> CommentListByDestinationId(int id)
        {
            return CreateAction(await _CommentReadService.CommentAllWithAsppUserIncludeByIdAsync(id));
        }
        [HttpPost]
        public async Task<IActionResult> CommentCreate(CreateCommentDto createCommentDto)
        {
            return CreateAction(await _CommentCommandService.CreateAsync(createCommentDto));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateComment(UpdateCommentDto updateCommentDto)
        {
            return CreateAction(await _CommentCommandService.UpdateAsync(updateCommentDto));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComment(int id)
        {
            return CreateAction(await _CommentCommandService.DeleteAsync(id));
        }
    }
}
