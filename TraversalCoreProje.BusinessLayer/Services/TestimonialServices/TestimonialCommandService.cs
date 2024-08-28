using AutoMapper;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class TestimonialCommandService : GenericCommandService<UpdateTestimonialDto, CreateTestimonialDto, Testimonial>, ITestimonialCommandService
    {
        public TestimonialCommandService(IGenericCommandRepository<Testimonial> genericCommandRepository, IMapper mapper) : base(genericCommandRepository, mapper)
        {
        }
    }
}
