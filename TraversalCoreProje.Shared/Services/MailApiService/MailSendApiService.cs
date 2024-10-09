using Microsoft.AspNetCore.Http;
using System.Net.Http.Json;
using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class MailSendApiService : IMailSendApiService
    {
        private readonly HttpClient _httpClient;
        private readonly IUserService _userService;
        public MailSendApiService(HttpClient httpClient, IUserService userService)
        {
            _httpClient = httpClient;
            _userService = userService;
        }

        public async Task<ResponseViewModel<MailRequestViewModel>> SendMailAsync(MailRequestViewModel mailRequestViewModel)
        {
            _userService.TokenHeaderAuthorization(_httpClient, _userService.AccessToken);
            var response = await _httpClient.PostAsJsonAsync(string.Empty, mailRequestViewModel);

            if (!response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadFromJsonAsync<ResponseViewModel<MailRequestViewModel>>();

                return ResponseViewModel<MailRequestViewModel>.Fail(responseData.Errors, StatusCodes.Status400BadRequest);
            }
            return ResponseViewModel<MailRequestViewModel>.Success(StatusCodes.Status200OK);
        }
    }
}
