using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class AnnouncementCommandApiService : BaseCommandApiService<UpdateAnnouncementViewModel, CreateAnnouncementViewModel>, IAnnouncementCommandApiService
    {
        public AnnouncementCommandApiService(IUserService userService, HttpClient httpClient) : base(userService, httpClient)
        {
        }
    }
}
