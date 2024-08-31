using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class About2CommandApiServices : BaseCommandApiService<UpdateAbout2ViewModel, CreateAbout2ViewModel>, IAbout2ApiCommandService
    {
        public About2CommandApiServices(IUserService userService, HttpClient httpClient) : base(userService, httpClient)
        {
        }
    }
}
