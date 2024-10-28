using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class VisitorReadApiService : BaseReadApiService<ResultVisitorViewModel>, IVisitorReadApiService
    {
        public VisitorReadApiService(HttpClient httpClient, IUserService userService) : base(httpClient, userService)
        {
        }
    }
}
