using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class VisitorCommandApiService : BaseCommandApiService<UpdateVisitorViewModel, CreateVisitorViewModel>, IVisitorCommandApiService
    {
        public VisitorCommandApiService(IUserService userService, HttpClient httpClient) : base(userService, httpClient)
        {
        }
    }
}
