using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class FeatureReadApiService : BaseReadApiService<ResultFeatureViewModel>, IFeatureReadApiService
    {
        public FeatureReadApiService(HttpClient httpClient, IUserService userService) : base(httpClient, userService)
        {
        }
    }
}
