using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.WebAPI.Controllers
{

    public class AboutsController : BaseController
    {
        private readonly IAboutReadService _aboutReadService;
        private readonly IAboutCommandService _aboutCommandService;

        public AboutsController(IAboutReadService aboutReadService, IAboutCommandService aboutCommandService)
        {
            _aboutReadService = aboutReadService;
            _aboutCommandService = aboutCommandService;
        }

        [HttpGet]
        public async Task<IActionResult> AboutList()
        {
            return CreateAction(await _aboutReadService.GetListAsync());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAbout(int id)
        {
            return CreateAction(await _aboutReadService.GetByIdAsync(id));
        }
        [HttpPost]
        public async Task<IActionResult> AboutCreate(CreateAboutDto createAboutDto)
        {
            return CreateAction(await _aboutCommandService.CreateAsync(createAboutDto));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            return CreateAction(await _aboutCommandService.UpdateAsync(updateAboutDto));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAbout(int id)
        {
            return CreateAction(await _aboutCommandService.DeleteAsync(id));
        }

    }
}
