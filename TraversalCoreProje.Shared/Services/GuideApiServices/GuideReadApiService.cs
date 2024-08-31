using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class GuideReadApiService : BaseReadApiService<ResultGuideViewModel>, IGuideReadApiService
    {
        public GuideReadApiService(HttpClient httpClient, IUserService userService) : base(httpClient, userService)
        {
        }
    }
}
