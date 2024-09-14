using Microsoft.AspNetCore.Http.HttpResults;
using System.Net.Http.Json;
using System.Text.Json;
using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class UserApiService : IUserApiService
    {
        private readonly HttpClient _httpClient;
        private readonly IUserService _userService;
        public UserApiService(HttpClient httpClient, IUserService userService)
        {
            _httpClient = httpClient;
            _userService = userService;
        }

        public async Task<ResponseViewModel<CreateUserViewModel>> CreateUserAsync(CreateUserViewModel model)
        {
            var result = await _httpClient.PostAsJsonAsync(string.Empty, model);
            var resultData = await result.Content.ReadFromJsonAsync<ResponseViewModel<CreateUserViewModel>>();
            if (!result.IsSuccessStatusCode)
                return ResponseViewModel<CreateUserViewModel>.Fail(resultData.Errors, resultData.StatusCode);
            return ResponseViewModel<CreateUserViewModel>.Success(resultData.Data, resultData.StatusCode);

        }

        public async Task<ResponseViewModel<ResultUserViewModel>> GetUserAsync(string token)
        {
            _userService.TokenHeaderAuthorization(_httpClient, token);
            var result = await _httpClient.GetFromJsonAsync<ResponseViewModel<ResultUserViewModel>>($"{int.Parse(_userService.GetUser)}");
            return result;
        }

        public async Task<ResponseViewModel<UserEditViewModel>> GetUserUpdateAsync(string token)
        {
            _userService.TokenHeaderAuthorization(_httpClient, token);
            var result = await _httpClient.GetFromJsonAsync<ResponseViewModel<UserEditViewModel>>($"{int.Parse(_userService.GetUser)}");
            result.Data.Id = int.Parse(_userService.GetUser);
            return result;
        }

        public async Task<ResponseViewModel<NoContent>> UserEditAsync(UserEditViewModel model, string token)
        {
            if (model.ImageFile is { Length: > 0 })
            {
                var newName = Guid.NewGuid().ToString() + Path.GetExtension(model.ImageFile.FileName);
                var path = Directory.GetCurrentDirectory() + "/wwwroot/userimage/" + newName;
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await model.ImageFile.CopyToAsync(stream);
                    model.ImageUrl = newName;
                }
            }
            _userService.TokenHeaderAuthorization(_httpClient, token);
            var result = await _httpClient.PutAsJsonAsync(string.Empty, model);
            var resultData = await result.Content.ReadFromJsonAsync<ResponseViewModel<NoContent>>(new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = false,
            });
            if (!result.IsSuccessStatusCode)
                return ResponseViewModel<NoContent>.Fail(resultData.Errors, (int)result.StatusCode);
            return ResponseViewModel<NoContent>.Success((int)result.StatusCode);
        }
    }
}
