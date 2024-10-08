using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Interfaces
{
    public interface IPdfReportService
    {
        void PdfListReport(List<DestinationPdfReportDto> t);
    }
}
