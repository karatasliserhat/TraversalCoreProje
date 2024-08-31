using System.Net.Http.Json;
using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class BaseReadApiService<ResultViewModel> : IBaseApiReadService<ResultViewModel> where ResultViewModel : ResultBaseViewModel
    {
        private readonly HttpClient _httpClient;
        private readonly IUserService _userService;

        public BaseReadApiService(HttpClient httpClient, IUserService userService)
        {
            _httpClient = httpClient;
            _userService = userService;
        }

        public async Task<ResponseViewModel<List<ResultViewModel>>> GetAllAsync(string token)
        {
            _userService.TokenHeaderAuthorization(_httpClient, token);
            var response = await _httpClient.GetFromJsonAsync<ResponseViewModel<List<ResultViewModel>>>(string.Empty);
            return response;

        }

        public async Task<ResponseViewModel<List<ResultViewModel>>> GetAllAsync(string ActionName, string token)
        {
            _userService.TokenHeaderAuthorization(_httpClient, token);
            return await _httpClient.GetFromJsonAsync<ResponseViewModel<List<ResultViewModel>>>($"{ActionName}");
        }

        public async Task<ResponseViewModel<List<ResultViewModel>>> GetAllAsync(string ActionName, int id, string token)
        {
            _userService.TokenHeaderAuthorization(_httpClient, token);
            return await _httpClient.GetFromJsonAsync<ResponseViewModel<List<ResultViewModel>>>($"{ActionName}/{id}");
        }

        public async Task<ResponseViewModel<ResultViewModel>> GetByIdAsync(string ActionName, int id, string token)
        {
            _userService.TokenHeaderAuthorization(_httpClient, token);
            return await _httpClient.GetFromJsonAsync<ResponseViewModel<ResultViewModel>>($"{ActionName}/{id}");
        }

        public async Task<ResponseViewModel<ResultViewModel>> GetByIdAsync(int id, string token)
        {
            _userService.TokenHeaderAuthorization(_httpClient, token);
            return await _httpClient.GetFromJsonAsync<ResponseViewModel<ResultViewModel>>($"{id}");
        }
    }
}