using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Interfaces
{
    public interface IBaseApiReadService<ResultViewModel> where ResultViewModel : ResultBaseViewModel
    {
        Task<ResponseViewModel<List<ResultViewModel>>> GetAllAsync(string token);
        Task<ResponseViewModel<List<ResultViewModel>>> GetAllAsync(string ActionName, string token);
        Task<ResponseViewModel<List<ResultViewModel>>> GetAllAsync(string ActionName, int id, string token);

        Task<ResponseViewModel<ResultViewModel>> GetByIdAsync(string ActionName, int id, string token);
        Task<ResponseViewModel<ResultViewModel>> GetByIdAsync(int id, string token);
    }
}
