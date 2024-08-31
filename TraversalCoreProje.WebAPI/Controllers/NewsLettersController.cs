using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.WebAPI.Controllers
{

    public class NewsLettersController : BaseController
    {
        private readonly INewsLetterReadService _NewsLetterReadService;
        private readonly INewsLetterCommandService _NewsLetterCommandService;

        public NewsLettersController(INewsLetterReadService NewsLetterReadService, INewsLetterCommandService NewsLetterCommandService)
        {
            _NewsLetterReadService = NewsLetterReadService;
            _NewsLetterCommandService = NewsLetterCommandService;
        }

        [HttpGet]
        public async Task<IActionResult> NewsLetterList()
        {
            return CreateAction(await _NewsLetterReadService.GetListAsync());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetNewsLetter(int id)
        {
            return CreateAction(await _NewsLetterReadService.GetByIdAsync(id));
        }
        [HttpPost]
        public async Task<IActionResult> NewsLetterCreate(CreateNewsLetterDto createNewsLetterDto)
        {
            return CreateAction(await _NewsLetterCommandService.CreateAsync(createNewsLetterDto));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateNewsLetter(UpdateNewsLetterDto updateNewsLetterDto)
        {
            return CreateAction(await _NewsLetterCommandService.UpdateAsync(updateNewsLetterDto));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNewsLetter(int id)
        {
            return CreateAction(await _NewsLetterCommandService.DeleteAsync(id));
        }
    }
}
