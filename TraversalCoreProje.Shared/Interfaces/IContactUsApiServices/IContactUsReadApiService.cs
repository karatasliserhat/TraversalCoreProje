using Microsoft.AspNetCore.Http.HttpResults;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Interfaces
{
    public interface IContactUsReadApiService:IBaseApiReadService<ResultContactUsViewModel>
    {
        Task<ResponseViewModel<NoContent>> GetContatUsStatusChangeFalse(int id);
    }
}
