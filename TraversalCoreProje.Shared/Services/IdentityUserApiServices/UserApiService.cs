using System.Net.Http.Json;
using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class UserApiService : IUserApiService
    {
        private readonly HttpClient _httpClient;

        public UserApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ResponseViewModel<CreateUserViewModel>> CreateUserAsync(CreateUserViewModel model)
        {
            var result = await _httpClient.PostAsJsonAsync(string.Empty, model);
            var resultData = await result.Content.ReadFromJsonAsync<ResponseViewModel<CreateUserViewModel>>();
            if (!result.IsSuccessStatusCode)
                return ResponseViewModel<CreateUserViewModel>.Fail(resultData.Errors, resultData.StatusCode);
            return ResponseViewModel<CreateUserViewModel>.Success(resultData.Data, resultData.StatusCode);

        }
    }
}
