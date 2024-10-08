using TraversalCoreProje.Shared.Interfaces;

namespace TraversalCoreProje.Shared.Services
{
    public class ExcelReportApiService : IExcelReportApiService
    {
        private readonly HttpClient _httpClient;
        private readonly IUserService _userService;
        public ExcelReportApiService(HttpClient httpClient, IUserService userService)
        {
            _httpClient = httpClient;
            _userService = userService;
        }

        public async Task GetListDestinationExcelReport()
        {
            _userService.TokenHeaderAuthorization(_httpClient, _userService.AccessToken);
            await _httpClient.GetAsync(string.Empty);

        }

        public async Task GetListDestinationExcelReport(string actionName)
        {
            _userService.TokenHeaderAuthorization(_httpClient, _userService.AccessToken);
            await _httpClient.GetAsync(actionName);
        }
    }
}
