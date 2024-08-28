using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Concreate;
using TraversolCoreProje.DataAccessLayer.EfCore.Intercaces;
using TraversolCoreProje.DataAccessLayer.Repository;

namespace TraversolCoreProje.DataAccessLayer.EfCore.Repositories
{
    public class TestimonialReadRepository : GenericReadRepository<Testimonial>, ITestimonialReadRepository
    {
        public TestimonialReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
