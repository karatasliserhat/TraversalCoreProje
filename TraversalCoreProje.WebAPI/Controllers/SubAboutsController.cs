using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.WebAPI.Controllers
{

    public class SubAboutsController : BaseController
    {
        private readonly ISubAboutReadService _SubAboutReadService;
        private readonly ISubAboutCommandService _SubAboutCommandService;

        public SubAboutsController(ISubAboutReadService SubAboutReadService, ISubAboutCommandService SubAboutCommandService)
        {
            _SubAboutReadService = SubAboutReadService;
            _SubAboutCommandService = SubAboutCommandService;
        }

        [HttpGet]
        public async Task<IActionResult> SubAboutList()
        {
            return CreateAction(await _SubAboutReadService.GetListAsync());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSubAbout(int id)
        {
            return CreateAction(await _SubAboutReadService.GetByIdAsync(id));
        }
        [HttpPost]
        public async Task<IActionResult> SubAboutCreate(CreateSubAboutDto createSubAboutDto)
        {
            return CreateAction(await _SubAboutCommandService.CreateAsync(createSubAboutDto));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateSubAbout(UpdateSubAboutDto updateSubAboutDto)
        {
            return CreateAction(await _SubAboutCommandService.UpdateAsync(updateSubAboutDto));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubAbout(int id)
        {
            return CreateAction(await _SubAboutCommandService.DeleteAsync(id));
        }
    }
}
