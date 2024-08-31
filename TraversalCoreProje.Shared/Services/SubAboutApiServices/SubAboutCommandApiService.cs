using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class SubAboutCommandApiService : BaseCommandApiService<UpdateSubAboutViewModel, CreateSubAboutViewModel>, ISubAboutCommandApiServices
    {
        public SubAboutCommandApiService(IUserService userService, HttpClient httpClient) : base(userService, httpClient)
        {
        }
    }
}
