using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Newtonsoft.Json;
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
            var response = await _httpClient.PostAsJsonAsync(string.Empty, createViewModel);
            if (!response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadFromJsonAsync<RootObject>();

                return ResponseViewModel<NoContent>.Fail(responseData.Errors.Select(x => x.Value[0].ToString()).ToList(), StatusCodes.Status400BadRequest);
            }
            return await response.Content.ReadFromJsonAsync<ResponseViewModel<NoContent>>();

        }

        public async Task<ResponseViewModel<NoContent>> CreateAsync(CreateViewModel createViewModel, string token)
        {
            _userService.TokenHeaderAuthorization(_httpClient, token);
            var response = await _httpClient.PostAsJsonAsync(string.Empty, createViewModel);
            if (!response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadFromJsonAsync<RootObject>();

                return ResponseViewModel<NoContent>.Fail(responseData.Errors.Select(x => x.Value[0].ToString()).ToList(), StatusCodes.Status400BadRequest);
            }

            return await response.Content.ReadFromJsonAsync<ResponseViewModel<NoContent>>();
        }

        public async Task<ResponseViewModel<NoContent>> DeleteAsync(string ActionName, int id, string token)
        {
            _userService.TokenHeaderAuthorization(_httpClient, token);
            var response = await _httpClient.DeleteAsync($"{ActionName}/{id}");
            if (!response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadFromJsonAsync<RootObject>();

                return ResponseViewModel<NoContent>.Fail(responseData.Errors.Select(x => x.Value[0].ToString()).ToList(), StatusCodes.Status400BadRequest);
            }
            return ResponseViewModel<NoContent>.Success(StatusCodes.Status204NoContent);

        }

        public async Task<ResponseViewModel<NoContent>> DeleteAsync(int id, string token)
        {
            _userService.TokenHeaderAuthorization(_httpClient, token);
            var response = await _httpClient.DeleteAsync($"{id}");
            if (!response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadFromJsonAsync<RootObject>();

                return ResponseViewModel<NoContent>.Fail(responseData.Errors.Select(x => x.Value[0].ToString()).ToList(), StatusCodes.Status400BadRequest);
            }
            return ResponseViewModel<NoContent>.Success(StatusCodes.Status204NoContent);
        }

        public async Task<ResponseViewModel<NoContent>> UpdateAsync(string ActionName, UpdateViewModel updateViewModel, string token)
        {
            _userService.TokenHeaderAuthorization(_httpClient, token);
            var response = await _httpClient.PutAsJsonAsync($"{ActionName}", updateViewModel);

            if (!response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadFromJsonAsync<RootObject>();

                return ResponseViewModel<NoContent>.Fail(responseData.Errors.Select(x => x.Value[0].ToString()).ToList(), StatusCodes.Status400BadRequest);
            }
            return ResponseViewModel<NoContent>.Success(StatusCodes.Status204NoContent);

        }

        public async Task<ResponseViewModel<NoContent>> UpdateAsync(UpdateViewModel updateViewModel, string token)
        {
            _userService.TokenHeaderAuthorization(_httpClient, token);
            var response = await _httpClient.PutAsJsonAsync(string.Empty, updateViewModel);
            if (!response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();

                var responseError = JsonConvert.DeserializeObject<RootObject>(responseData);
                return ResponseViewModel<NoContent>.Fail(responseError.Errors.Select(x => x.Value[0].ToString()).ToList(), StatusCodes.Status400BadRequest);
            }

            return ResponseViewModel<NoContent>.Success(StatusCodes.Status204NoContent);
        }
        public async Task<ResponseViewModel<UpdateViewModel>> UpdateGetByIdAsync(string ActionName, int id, string token)
        {
            _userService.TokenHeaderAuthorization(_httpClient, token);
            return await _httpClient.GetFromJsonAsync<ResponseViewModel<UpdateViewModel>>($"{ActionName}/{id}");
        }

        public async Task<ResponseViewModel<UpdateViewModel>> UpdateGetByIdAsync(int id, string token)
        {
            _userService.TokenHeaderAuthorization(_httpClient, token);
            return await _httpClient.GetFromJsonAsync<ResponseViewModel<UpdateViewModel>>($"{id}");
        }
    }
}
