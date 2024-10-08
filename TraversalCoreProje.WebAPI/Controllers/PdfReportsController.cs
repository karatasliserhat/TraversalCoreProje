using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PdfReportsController : ControllerBase
    {
        private readonly IDestinationReadService _destinationReadService;
        private readonly IPdfReportService _pdfReportService;

        public PdfReportsController(IDestinationReadService destinationReadService, IPdfReportService pdfReportService)
        {
            _destinationReadService = destinationReadService;
            _pdfReportService = pdfReportService;
        }
        [HttpGet]
        public async Task<IActionResult> GetPdfDestinationReport()
        {
            List<DestinationPdfReportDto> listData = new() { };
            var data = await _destinationReadService.GetListAsync();

            if (data.Data is not null)
            {
                data.Data.ForEach(x =>
                {
                    listData.Add(new DestinationPdfReportDto() { Capacity = x.Capacity, City = x.City, DayNight = x.DayNight });
                });
            }
            _pdfReportService.PdfListReport(listData);
            return File("/PdfFile/destinationReport.pdf", "application/pdf", "DestinationReport.pdf");
        }
    }
}
