using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.WebAPI.Controllers
{

    public class DestinationsController : BaseController
    {
        private readonly IDestinationReadService _DestinationReadService;
        private readonly IDestinationCommandService _DestinationCommandService;

        public DestinationsController(IDestinationReadService DestinationReadService, IDestinationCommandService DestinationCommandService)
        {
            _DestinationReadService = DestinationReadService;
            _DestinationCommandService = DestinationCommandService;
        }

        [HttpGet]
        public async Task<IActionResult> DestinationList()
        {
            return CreateAction(await _DestinationReadService.GetListAsync());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDestination(int id)
        {
            return CreateAction(await _DestinationReadService.DestinationwithGuidebyDestinationId(id));
        }
        [HttpGet("[Action]")]
        public async Task<IActionResult> GetLastFourDestination()
        {
            return CreateAction(await _DestinationReadService.GetLastFourDestinationIdAsync());
        }
        [HttpPost]
        public async Task<IActionResult> DestinationCreate(CreateDestinationDto createDestinationDto)
        {
            createDestinationDto.Date = DateTime.Now;
            return CreateAction(await _DestinationCommandService.CreateAsync(createDestinationDto));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateDestination(UpdateDestinationDto updateDestinationDto)
        {
            return CreateAction(await _DestinationCommandService.UpdateAsync(updateDestinationDto));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDestination(int id)
        {
            return CreateAction(await _DestinationCommandService.DeleteAsync(id));
        }
    }
}
