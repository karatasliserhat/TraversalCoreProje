using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Interfaces
{
    public interface IAccountApiService
    {
        Task<ResponseViewModel<TokenResponseViewModel>> SignInAsync(SignInViewModel signInViewModel);
    }
}
