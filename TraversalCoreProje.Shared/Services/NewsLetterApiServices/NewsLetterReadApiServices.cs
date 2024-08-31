using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class NewsLetterReadApiServices : BaseReadApiService<ResultNewsLetterViewModel>, INewsLetterReadApiServices
    {
        public NewsLetterReadApiServices(HttpClient httpClient, IUserService userService) : base(httpClient, userService)
        {
        }
    }
}
