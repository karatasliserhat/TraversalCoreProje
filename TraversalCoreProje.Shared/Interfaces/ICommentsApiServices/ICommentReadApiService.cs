using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Interfaces
{
    public interface ICommentReadApiService:IBaseApiReadService<ResultCommentViewModel>
    {
        Task<ResponseViewModel<List<ResultCommentViewModel>>> GetCommentListByDestinationId(int id, string token);
    }
}
