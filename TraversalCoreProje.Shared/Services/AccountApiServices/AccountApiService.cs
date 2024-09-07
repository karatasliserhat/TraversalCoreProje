using System.Net.Http.Json;
using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class AccountApiService : IAccountApiService
    {
        private readonly HttpClient _httpClient;

        public AccountApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ResponseViewModel<TokenResponseViewModel>> SignInAsync(SignInViewModel signInViewModel)
        {
            var result = await _httpClient.PostAsJsonAsync(string.Empty, signInViewModel);
            var resultData = await result.Content.ReadFromJsonAsync<ResponseViewModel<TokenResponseViewModel>>();
            if (!result.IsSuccessStatusCode)
                return ResponseViewModel<TokenResponseViewModel>.Fail(resultData.Errors, resultData.StatusCode);
            return ResponseViewModel<TokenResponseViewModel>.Success(resultData.Data, resultData.StatusCode);

        }
    }
}
