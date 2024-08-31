using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalCoreProje.BusinessLayer.Interfaces;

namespace TraversalCoreProje.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : BaseController
    {
        private readonly IStatisticsService _statisticsService;

        public StatisticsController(IStatisticsService statisticsService)
        {
            _statisticsService = statisticsService;
        }

        [HttpGet("[Action]")]
        public async Task<IActionResult> DestinationCount()
        {
            return CreateAction(await _statisticsService.DestinationCount());
        }
        [HttpGet("[Action]")]
        public async Task<IActionResult> GuideCount()
        {
            return CreateAction(await _statisticsService.GuideCount());
        }
        [HttpGet("[Action]")]
        public async Task<IActionResult> TestimonialCount()
        {
            return CreateAction(await _statisticsService.TestimonialCount());
        }
    }
}
