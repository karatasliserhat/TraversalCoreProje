using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class SubAboutReadApiService : BaseReadApiService<ResultSubAboutViewModel>, ISubAboutReadApiServices
    {
        public SubAboutReadApiService(HttpClient httpClient, IUserService userService) : base(httpClient, userService)
        {
        }
    }
}
