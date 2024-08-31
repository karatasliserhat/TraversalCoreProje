using System.Net.Http.Json;
using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class StatisticsApiService : IStatisticsApiService
    {
        private readonly HttpClient _httpClient;
        private readonly IUserService _userService;
        public StatisticsApiService(HttpClient httpClient, IUserService userService)
        {
            _httpClient = httpClient;
            _userService = userService;
        }

        public async Task<ResponseViewModel<int>> DestinationCount(string token)
        {
            _userService.TokenHeaderAuthorization(_httpClient, token);
            return await _httpClient.GetFromJsonAsync<ResponseViewModel<int>>($"DestinationCount");
        }

        public async Task<ResponseViewModel<int>> GuideCount(string token)
        {
            _userService.TokenHeaderAuthorization(_httpClient, token);

            return await _httpClient.GetFromJsonAsync<ResponseViewModel<int>>($"GuideCount");
        }

        public async Task<ResponseViewModel<int>> TestimonailCount(string token)
        {
            _userService.TokenHeaderAuthorization(_httpClient, token);

            return await _httpClient.GetFromJsonAsync<ResponseViewModel<int>>($"TestimonialCount");
        }
    }
}
