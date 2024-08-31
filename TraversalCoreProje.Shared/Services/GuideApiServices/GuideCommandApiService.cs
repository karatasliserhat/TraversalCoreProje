using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class GuideCommandApiService : BaseCommandApiService<UpdateGuideViewModel, CreateGuideViewModel>, IGuideCommandApiService
    {
        public GuideCommandApiService(IUserService userService, HttpClient httpClient) : base(userService, httpClient)
        {
        }
    }
}
