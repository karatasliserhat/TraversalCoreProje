using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.WebAPI.Controllers
{

    public class TestimonialsController : BaseController
    {
        private readonly ITestimonialReadService _TestimonialReadService;
        private readonly ITestimonialCommandService _TestimonialCommandService;

        public TestimonialsController(ITestimonialReadService TestimonialReadService, ITestimonialCommandService TestimonialCommandService)
        {
            _TestimonialReadService = TestimonialReadService;
            _TestimonialCommandService = TestimonialCommandService;
        }

        [HttpGet]
        public async Task<IActionResult> TestimonialList()
        {
            return CreateAction(await _TestimonialReadService.GetListAsync());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTestimonial(int id)
        {
            return CreateAction(await _TestimonialReadService.GetByIdAsync(id));
        }
        [HttpPost]
        public async Task<IActionResult> TestimonialCreate(CreateTestimonialDto createTestimonialDto)
        {
            return CreateAction(await _TestimonialCommandService.CreateAsync(createTestimonialDto));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            return CreateAction(await _TestimonialCommandService.UpdateAsync(updateTestimonialDto));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            return CreateAction(await _TestimonialCommandService.DeleteAsync(id));
        }
    }
}
