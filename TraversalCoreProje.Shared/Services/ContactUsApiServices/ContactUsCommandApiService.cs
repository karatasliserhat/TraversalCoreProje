using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class ContactUsCommandApiService : BaseCommandApiService<UpdateContactUsViewModel, CreateContactUsViewModel>, IContactUsCommandApiService
    {
        public ContactUsCommandApiService(IUserService userService, HttpClient httpClient) : base(userService, httpClient)
        {
        }
    }
}
