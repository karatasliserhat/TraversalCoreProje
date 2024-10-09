using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Net.Http.Json;
using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class GuideCommandApiService : BaseCommandApiService<UpdateGuideViewModel, CreateGuideViewModel>, IGuideCommandApiService
    {
        private readonly HttpClient _httpClient;
        private readonly IUserService _userService;
        public GuideCommandApiService(IUserService userService, HttpClient httpClient) : base(userService, httpClient)
        {
            _httpClient = httpClient;
            _userService = userService;
        }

        public async Task<ResponseViewModel<NoContent>> GuideStatusChange(string ActionName, int id)
        {
            _userService.TokenHeaderAuthorization(_httpClient, _userService.AccessToken);

            var response = await _httpClient.GetAsync($"{ActionName}/{id}");

            if (!response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadFromJsonAsync<RootObject>();

                return ResponseViewModel<NoContent>.Fail(responseData.Errors.Select(x => x.Value[0].ToString()).ToList(), StatusCodes.Status400BadRequest);
            }
            return ResponseViewModel<NoContent>.Success(StatusCodes.Status204NoContent);
        }
    }
}
