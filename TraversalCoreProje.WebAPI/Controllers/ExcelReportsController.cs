using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcelReportsController : ControllerBase
    {
        private readonly IDestinationReadService _destinationReadService;
        private readonly IExcelReportService _excelReportService;
        public ExcelReportsController(IDestinationReadService destinationReadService, IExcelReportService excelReportService)
        {
            _destinationReadService = destinationReadService;
            _excelReportService = excelReportService;
        }

        [HttpGet]
        public async Task<IActionResult> DestinationListExceReport()
        {
            List<DestinationExcelReportDto> listData = new() { };
            var data = await _destinationReadService.GetListAsync();

            if (data.Data is not null)
            {
                data.Data.ForEach(x =>
                {
                    listData.Add(new DestinationExcelReportDto() { Capacity = x.Capacity, City = x.City, DayNight = x.DayNight });
                });
            }

            return File(await _excelReportService.ExcelListReport(listData), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "DestinationList.xlsx");
        }
    }
}
