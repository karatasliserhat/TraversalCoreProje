using Newtonsoft.Json;
using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class MovieApiReadService : IMovieApiReadService
    {
        private readonly HttpClient _httpClient;

        public MovieApiReadService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ResultApiMovieViewModel>> GetTop100Movie()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
    {
        { "x-rapidapi-key", "d70f9ec97amshf8b901ee7f40356p187de5jsn3b617dd43622" },
        { "x-rapidapi-host", "imdb-top-100-movies.p.rapidapi.com" },
    },
            };
            var response = await _httpClient.SendAsync(request);

            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<ResultApiMovieViewModel>>(body);
        }
    }
}
