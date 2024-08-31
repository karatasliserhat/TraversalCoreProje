using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class About2ReadApiServices : BaseReadApiService<ResultAbout2ViewModel>, IAbout2ApiReadService
    {
        public About2ReadApiServices(HttpClient httpClient, IUserService userService) : base(httpClient, userService)
        {
        }
    }
}
