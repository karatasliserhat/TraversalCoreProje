using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services
{
    public class TestimonialCommandApiService : BaseCommandApiService<UpdateTestimonialViewModel, CreateTestimonialViewModel>, ITestimonialCommandApiServices
    {
        public TestimonialCommandApiService(IUserService userService, HttpClient httpClient) : base(userService, httpClient)
        {
        }
    }
}
