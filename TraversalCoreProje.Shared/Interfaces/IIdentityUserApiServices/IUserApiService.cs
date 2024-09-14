using Microsoft.AspNetCore.Http.HttpResults;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Interfaces
{
    public interface IUserApiService
    {
        Task<ResponseViewModel<CreateUserViewModel>> CreateUserAsync(CreateUserViewModel model);
        Task<ResponseViewModel<ResultUserViewModel>> GetUserAsync(string token);
        Task<ResponseViewModel<UserEditViewModel>> GetUserUpdateAsync(string token);
        Task<ResponseViewModel<NoContent>> UserEditAsync(UserEditViewModel model, string token);
    }
}
