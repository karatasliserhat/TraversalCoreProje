using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class DestinationCommandApiService : BaseCommandApiService<UpdateDestinationViewModel, CreateDestinationViewModel>, IDestinationCommandApiService
    {
        public DestinationCommandApiService(IUserService userService, HttpClient httpClient) : base(userService, httpClient)
        {
        }
    }
}
