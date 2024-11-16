using Newtonsoft.Json;
using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class BookingExchangeReadApiServices : IBookingExchangeReadApiServices
    {
        private readonly HttpClient _httpClient;

        public BookingExchangeReadApiServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ResultBookingExchangeViewModel> BookingExchangeList()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com15.p.rapidapi.com/api/v1/meta/getExchangeRates?base_currency=TRY"),
                Headers =
    {
        { "x-rapidapi-key", "d70f9ec97amshf8b901ee7f40356p187de5jsn3b617dd43622" },
        { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
    },
            };
            var response = await _httpClient.SendAsync(request);

            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ResultBookingExchangeViewModel>(body);

        }
    }
}
