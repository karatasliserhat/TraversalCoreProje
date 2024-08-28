using AutoMapper;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class TestimonialReadService : GenericReadService<ResultTestimonialDto, Testimonial>, ITestimonialReadService
    {
        public TestimonialReadService(IGenericReadRepository<Testimonial> genericReadRepository, IMapper mapper) : base(genericReadRepository, mapper)
        {
        }
    }
}
