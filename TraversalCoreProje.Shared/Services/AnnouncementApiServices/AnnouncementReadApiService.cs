using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class AnnouncementReadApiService : BaseReadApiService<ResultAnnouncementViewModel>, IAnnouncementReadApiService
    {
        public AnnouncementReadApiService(HttpClient httpClient, IUserService userService) : base(httpClient, userService)
        {
        }
    }
}
