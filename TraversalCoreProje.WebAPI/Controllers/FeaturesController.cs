using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.WebAPI.Controllers
{

    public class FeaturesController : BaseController
    {
        private readonly IFeatureReadService _FeatureReadService;
        private readonly IFeatureCommandService _FeatureCommandService;

        public FeaturesController(IFeatureReadService FeatureReadService, IFeatureCommandService FeatureCommandService)
        {
            _FeatureReadService = FeatureReadService;
            _FeatureCommandService = FeatureCommandService;
        }

        [HttpGet]
        public async Task<IActionResult> FeatureList()
        {
            return CreateAction(await _FeatureReadService.GetListAsync());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFeature(int id)
        {
            return CreateAction(await _FeatureReadService.GetByIdAsync(id));
        }
        [HttpPost]
        public async Task<IActionResult> FeatureCreate(CreateFeatureDto createFeatureDto)
        {
            return CreateAction(await _FeatureCommandService.CreateAsync(createFeatureDto));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            return CreateAction(await _FeatureCommandService.UpdateAsync(updateFeatureDto));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFeature(int id)
        {
            return CreateAction(await _FeatureCommandService.DeleteAsync(id));
        }
    }
}
