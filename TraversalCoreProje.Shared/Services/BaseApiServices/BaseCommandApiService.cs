using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Net.Http.Json;
using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class BaseCommandApiService<UpdateViewModel, CreateViewModel> : IBaseCommandApiService<UpdateViewModel, CreateViewModel> where UpdateViewModel : UpdateBaseViewModel where CreateViewModel : CreateBaseViewModel
    {
        private readonly IUserService _userService;
        private readonly HttpClient _httpClient;

        public BaseCommandApiService(IUserService userService, HttpClient httpClient)
        {
            _userService = userService;
            _httpClient = httpClient;
        }

        public async Task<ResponseViewModel<NoContent>> CreateAsync(string ActionName, CreateViewModel createViewModel, string token)
        {
            _userService.TokenHeaderAuthorization(_httpClient, token);
            var response = await _httpClient.PostAsJsonAsync($"{ActionName}", createViewModel);
            var responseData = await response.Content.ReadFromJsonAsync<ResponseViewModel<NoContent>>();
            return responseData;
        }

        public async Task<ResponseViewModel<NoContent>> CreateAsync(CreateViewModel createViewModel, string token)
        {
            _userService.TokenHeaderAuthorization(_httpClient, token);
            var response = await _httpClient.PostAsJsonAsync(string.Empty, createViewModel);
            var responseData = await response.Content.ReadFromJsonAsync<ResponseViewModel<NoContent>>();
            return responseData;
        }

        public async Task<ResponseViewModel<NoContent>> DeleteAsync(string ActionName, int id, string token)
        {
            _userService.TokenHeaderAuthorization(_httpClient, token);
            var response = await _httpClient.DeleteAsync($"{ActionName}/{id}");
            var responseData = await response.Content.ReadFromJsonAsync<ResponseViewModel<NoContent>>();
            return responseData;
        }

        public async Task<ResponseViewModel<NoContent>> DeleteAsync(int id, string token)
        {
            _userService.TokenHeaderAuthorization(_httpClient, token);
            _userService.TokenHeaderAuthorization(_httpClient, token);
            var response = await _httpClient.DeleteAsync($"{id}");
            var responseData = await response.Content.ReadFromJsonAsync<ResponseViewModel<NoContent>>();
            return responseData;
        }

        public async Task<ResponseViewModel<NoContent>> UpdateAsync(string ActionName, UpdateViewModel updateViewModel, string token)
        {
            _userService.TokenHeaderAuthorization(_httpClient, token);
            var response = await _httpClient.PostAsJsonAsync($"{ActionName}", updateViewModel);
            var responseData = await response.Content.ReadFromJsonAsync<ResponseViewModel<NoContent>>();
            return responseData;
        }

        public async Task<ResponseViewModel<NoContent>> UpdateAsync(UpdateViewModel updateViewModel, string token)
        {
            _userService.TokenHeaderAuthorization(_httpClient, token);
            var response = await _httpClient.PostAsJsonAsync(string.Empty, updateViewModel);
            var responseData = await response.Content.ReadFromJsonAsync<ResponseViewModel<NoContent>>();
            return responseData;
        }
    }
}
