using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class ContactCommandApiService : BaseCommandApiService<UpdateContactViewModel, CreateContactViewModel>, IContacCommandApiService
    {
        public ContactCommandApiService(IUserService userService, HttpClient httpClient) : base(userService, httpClient)
        {
        }
    }
}
