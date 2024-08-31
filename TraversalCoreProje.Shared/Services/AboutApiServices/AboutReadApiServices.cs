using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class AboutReadApiServices : BaseReadApiService<ResultAboutViewModel>, IAboutApiReadService
    {
        public AboutReadApiServices(HttpClient httpClient, IUserService userService) : base(httpClient, userService)
        {
        }
    }
}
