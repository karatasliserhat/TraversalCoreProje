using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class CommentCommandApiService : BaseCommandApiService<UpdateCommentViewModel, CreateCommentViewModel>, ICommentCommandApiService
    {
        public CommentCommandApiService(IUserService userService, HttpClient httpClient) : base(userService, httpClient)
        {
        }
    }
}
