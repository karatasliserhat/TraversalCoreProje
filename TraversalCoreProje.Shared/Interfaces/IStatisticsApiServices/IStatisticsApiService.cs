using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Interfaces
{
    public interface IStatisticsApiService
    {
        Task<ResponseViewModel<int>> DestinationCount(string token);
        Task<ResponseViewModel<int>> GuideCount(string token);
        Task<ResponseViewModel<int>> TestimonailCount(string token);
    }
}
