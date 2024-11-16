using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Interfaces
{
    public interface IMovieApiReadService
    {
        Task<List<ResultApiMovieViewModel>> GetTop100Movie();
    }
}
