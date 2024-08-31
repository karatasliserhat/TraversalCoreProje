using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Services    
{
    public class TestimonialReadApiService : BaseReadApiService<ResultTestimonialViewModel>, ITestimonialReadApiServices
    {
        public TestimonialReadApiService(HttpClient httpClient, IUserService userService) : base(httpClient, userService)
        {
        }
    }
}
