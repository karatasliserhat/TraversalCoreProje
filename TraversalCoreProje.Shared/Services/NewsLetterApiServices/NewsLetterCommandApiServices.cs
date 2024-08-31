using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class NewsLetterCommandApiServices : BaseCommandApiService<UpdateNewsLetterViewModel, CreateNewsLetterViewModel>, INewsLetterCommandApiServices
    {
        public NewsLetterCommandApiServices(IUserService userService, HttpClient httpClient) : base(userService, httpClient)
        {
        }
    }
}
