using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.WebAPI.Controllers
{
    public class Abouts2Controller : BaseController
    {
        private readonly IAbout2ReadService _About2ReadService;
        private readonly IAbout2CommandService _About2CommandService;

        public Abouts2Controller(IAbout2ReadService About2ReadService, IAbout2CommandService About2CommandService)
        {
            _About2ReadService = About2ReadService;
            _About2CommandService = About2CommandService;
        }

        [HttpGet]
        public async Task<IActionResult> About2List()
        {
            return CreateAction(await _About2ReadService.GetListAsync());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAbout2(int id)
        {
            return CreateAction(await _About2ReadService.GetByIdAsync(id));
        }
        [HttpPost]
        public async Task<IActionResult> About2Create(CreateAbout2Dto createAbout2Dto)
        {
            return CreateAction(await _About2CommandService.CreateAsync(createAbout2Dto));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAbout2(UpdateAbout2Dto updateAbout2Dto)
        {
            return CreateAction(await _About2CommandService.UpdateAsync(updateAbout2Dto));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAbout2(int id)
        {
            return CreateAction(await _About2CommandService.DeleteAsync(id));
        }
    }
}
