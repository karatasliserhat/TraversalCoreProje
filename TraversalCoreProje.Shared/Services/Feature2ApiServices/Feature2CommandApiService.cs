using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class Feature2CommandApiService : BaseCommandApiService<UpdateFeature2ViewModel, CreateFeature2ViewModel>, IFeature2CommandApiService
    {
        public Feature2CommandApiService(IUserService userService, HttpClient httpClient) : base(userService, httpClient)
        {
        }
    }
}
