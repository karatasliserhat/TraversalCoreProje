using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Interfaces
{
    public interface ITestimonialCommandService:IGenericCommandService<UpdateTestimonialDto,CreateTestimonialDto,Testimonial>
    {
    }
}
