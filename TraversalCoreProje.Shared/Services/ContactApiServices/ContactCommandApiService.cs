using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class ContactCommandApiService : BaseCommandApiService<UpdateContactViewModel, CreateContactViewModel>, IContactCommandApiService
    {
        public ContactCommandApiService(IUserService userService, HttpClient httpClient) : base(userService, httpClient)
        {
        }
    }
}
