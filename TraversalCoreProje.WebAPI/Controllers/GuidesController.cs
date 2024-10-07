using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.WebAPI.Controllers
{

    public class GuidesController : BaseController
    {
        private readonly IGuideReadService _GuideReadService;
        private readonly IGuideCommandService _GuideCommandService;

        public GuidesController(IGuideReadService GuideReadService, IGuideCommandService GuideCommandService)
        {
            _GuideReadService = GuideReadService;
            _GuideCommandService = GuideCommandService;
        }

        [HttpGet]
        public async Task<IActionResult> GuideList()
        {
            return CreateAction(await _GuideReadService.GetListAsync());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetGuide(int id)
        {
            return CreateAction(await _GuideReadService.GetByIdAsync(id));
        }
        [HttpPost]
        public async Task<IActionResult> GuideCreate(CreateGuideDto createGuideDto)
        {
            createGuideDto.Status = true;
            return CreateAction(await _GuideCommandService.CreateAsync(createGuideDto));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateGuide(UpdateGuideDto updateGuideDto)
        {
            return CreateAction(await _GuideCommandService.UpdateAsync(updateGuideDto));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGuide(int id)
        {
            return CreateAction(await _GuideCommandService.DeleteAsync(id));
        }
    }
}
