using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class Feature2ReadApiService : BaseReadApiService<ResultFeature2ViewModel>, IFeature2ReadApiService
    {
        public Feature2ReadApiService(HttpClient httpClient, IUserService userService) : base(httpClient, userService)
        {
        }
    }
}
