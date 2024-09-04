using System.Net.Http.Json;
using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class CommentReadApiService : BaseReadApiService<ResultCommentViewModel>, ICommentReadApiService
    {
        private readonly HttpClient _httpClient;
        private readonly IUserService _userService;
        public CommentReadApiService(HttpClient httpClient, IUserService userService) : base(httpClient, userService)
        {
            _httpClient = httpClient;
            _userService = userService;
        }

        public async Task<ResponseViewModel<List<ResultCommentViewModel>>> GetCommentListByDestinationId(int id, string token)
        {
            _userService.TokenHeaderAuthorization(_httpClient, token);

            var result = await _httpClient.GetAsync($"CommentListByDestinationId/{id}");
            return await result.Content.ReadFromJsonAsync<ResponseViewModel<List<ResultCommentViewModel>>>();



        }
    }
}
