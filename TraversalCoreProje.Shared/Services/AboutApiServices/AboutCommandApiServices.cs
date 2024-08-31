using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class AboutCommandApiServices : BaseCommandApiService<UpdateAboutViewModel, CreateAboutViewModel>, IAboutApiCommandService
    {
        public AboutCommandApiServices(IUserService userService, HttpClient httpClient) : base(userService, httpClient)
        {
        }
    }
}
