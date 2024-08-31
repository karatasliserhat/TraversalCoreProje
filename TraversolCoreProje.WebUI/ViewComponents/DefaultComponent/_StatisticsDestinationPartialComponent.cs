using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Shared.Interfaces;

namespace TraversolCoreProje.WebUI.ViewComponents.DefaultComponent
{
    public class _StatisticsDestinationPartialComponent : ViewComponent
    {
        private readonly IStatisticsApiService _statisticsApiService;
        private readonly IUserService _userService;
        public _StatisticsDestinationPartialComponent(IStatisticsApiService statisticsApiService, IUserService userService)
        {
            _statisticsApiService = statisticsApiService;
            _userService = userService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var destinationCount = await _statisticsApiService.DestinationCount("");
            ViewBag.DestinationCount = destinationCount.Data;

            var guideCount = await _statisticsApiService.GuideCount("");
            ViewBag.GuideCount = guideCount.Data;

            var testimonialCount = await _statisticsApiService.TestimonailCount("");
            ViewBag.TestimonailCount = testimonialCount.Data;
            return View();
        }
    }
}
