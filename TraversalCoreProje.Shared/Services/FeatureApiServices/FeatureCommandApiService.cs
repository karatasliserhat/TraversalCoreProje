using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class FeatureCommandApiService : BaseCommandApiService<UpdateFeatureViewModel, CreateFeatureViewModel>, IFeatureCommandApiService
    {
        public FeatureCommandApiService(IUserService userService, HttpClient httpClient) : base(userService, httpClient)
        {
        }
    }
}
