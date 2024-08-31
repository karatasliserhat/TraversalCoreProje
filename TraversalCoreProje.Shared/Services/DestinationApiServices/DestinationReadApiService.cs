using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class DestinationReadApiService : BaseReadApiService<ResultDestinationViewModel>, IDestinationReadApiService
    {
        public DestinationReadApiService(HttpClient httpClient, IUserService userService) : base(httpClient, userService)
        {
        }
    }
}
