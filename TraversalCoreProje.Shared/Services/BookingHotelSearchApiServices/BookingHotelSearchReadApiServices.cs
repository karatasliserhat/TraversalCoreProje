using Newtonsoft.Json;
using TraversalCoreProje.Shared.Interface;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class BookingHotelSearchReadApiServices : IBookingHotelSearchReadApiService
    {
        private readonly HttpClient _httpClient;

        public BookingHotelSearchReadApiServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ResultBookingHotelViewModel> GetAllBookingHotelList()
        {

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com15.p.rapidapi.com/api/v1/hotels/searchDestination?query=Turkey"),
                Headers =
    {
        { "x-rapidapi-key", "d70f9ec97amshf8b901ee7f40356p187de5jsn3b617dd43622" },
        { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
    },
            };
            var response = await _httpClient.SendAsync(request);

            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ResultBookingHotelViewModel>(body);
        }
    }
}
