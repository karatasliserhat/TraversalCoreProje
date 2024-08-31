using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.WebAPI.Controllers
{

    public class Features2Controller : BaseController
    {
        private readonly IFeature2ReadService _Feature2ReadService;
        private readonly IFeature2CommandService _Feature2CommandService;

        public Features2Controller(IFeature2ReadService Feature2ReadService, IFeature2CommandService Feature2CommandService)
        {
            _Feature2ReadService = Feature2ReadService;
            _Feature2CommandService = Feature2CommandService;
        }

        [HttpGet]
        public async Task<IActionResult> Feature2List()
        {
            return CreateAction(await _Feature2ReadService.GetListAsync());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFeature2(int id)
        {
            return CreateAction(await _Feature2ReadService.GetByIdAsync(id));
        }
        [HttpPost]
        public async Task<IActionResult> Feature2Create(CreateFeature2Dto createFeature2Dto)
        {
            return CreateAction(await _Feature2CommandService.CreateAsync(createFeature2Dto));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateFeature2(UpdateFeature2Dto updateFeature2Dto)
        {
            return CreateAction(await _Feature2CommandService.UpdateAsync(updateFeature2Dto));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFeature2(int id)
        {
            return CreateAction(await _Feature2CommandService.DeleteAsync(id));
        }
    }
}
