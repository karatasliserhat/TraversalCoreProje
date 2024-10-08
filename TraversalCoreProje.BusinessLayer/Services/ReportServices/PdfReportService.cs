using iTextSharp.text;
using iTextSharp.text.pdf;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class PdfReportService : IPdfReportService
    {
        public void PdfListReport(List<DestinationPdfReportDto> t) 
        {

            string path = Path.Combine(Directory.GetCurrentDirectory(), "PdfFile", "destinationReport.pdf");

            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);


            PdfWriter.GetInstance(document, stream);
            document.Open();

            PdfPTable pdfTable = new PdfPTable(t.Count);

            pdfTable.AddCell("Sehir");
            pdfTable.AddCell("Kac Gun");
            pdfTable.AddCell("Kapasite");

            foreach (var item in t)
            {
                pdfTable.AddCell(item.City);
                pdfTable.AddCell(item.DayNight);
                pdfTable.AddCell(item.Capacity.ToString());
            }

            document.Add(pdfTable);
            document.Close();
        }
    }
}
