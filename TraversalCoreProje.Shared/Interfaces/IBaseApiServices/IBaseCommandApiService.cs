using Microsoft.AspNetCore.Http.HttpResults;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Interfaces
{
    public interface IBaseCommandApiService<UpdateViewModel, CreateViewModel> where UpdateViewModel : UpdateBaseViewModel where CreateViewModel : CreateBaseViewModel
    {
        Task<ResponseViewModel<NoContent>> CreateAsync(string ActionName, CreateViewModel createViewModel, string token);
        Task<ResponseViewModel<NoContent>> CreateAsync(CreateViewModel createViewModel, string token);

        Task<ResponseViewModel<NoContent>> UpdateAsync(string ActionName, UpdateViewModel updateViewModel, string token);
        Task<ResponseViewModel<NoContent>> UpdateAsync(UpdateViewModel updateViewModel, string token);

        Task<ResponseViewModel<NoContent>> DeleteAsync(string ActionName, int id, string token);
        Task<ResponseViewModel<NoContent>> DeleteAsync(int id, string token);
        Task<ResponseViewModel<UpdateViewModel>> UpdateGetByIdAsync(string ActionName, int id, string token);
        Task<ResponseViewModel<UpdateViewModel>> UpdateGetByIdAsync(int id, string token);

    }
}
