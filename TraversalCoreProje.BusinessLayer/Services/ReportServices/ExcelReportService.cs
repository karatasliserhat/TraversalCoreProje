using OfficeOpenXml;
using TraversalCoreProje.BusinessLayer.Interfaces;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class ExcelReportService : IExcelReportService
    {
        public async Task<byte[]> ExcelListReport<T>(List<T> t) where T : class
        {

            ExcelPackage excelPackage = new ExcelPackage();

            
            var workSheet = excelPackage.Workbook.Worksheets.Add("Sayfa1");
            workSheet.Cells["A1"].LoadFromCollection(t, true, OfficeOpenXml.Table.TableStyles.Light10);

            return await excelPackage.GetAsByteArrayAsync();


        }
    }
}


