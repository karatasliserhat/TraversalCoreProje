using Microsoft.AspNetCore.Http.HttpResults;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Interfaces
{
    public interface IGuideCommandApiService:IBaseCommandApiService<UpdateGuideViewModel,CreateGuideViewModel>
    {
        Task<ResponseViewModel<NoContent>> GuideStatusChange(string ActionName, int id);
    }
}
