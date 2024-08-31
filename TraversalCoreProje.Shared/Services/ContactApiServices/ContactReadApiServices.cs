using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class ContactReadApiServices : BaseReadApiService<ResultContactViewModel>, IContacReadApiService
    {
        public ContactReadApiServices(HttpClient httpClient, IUserService userService) : base(httpClient, userService)
        {
        }
    }
}
