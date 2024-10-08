using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraversalCoreProje.BusinessLayer.Interfaces
{
    public interface IExcelReportService
    {
        Task<byte[]> ExcelListReport<T>(List<T> t) where T : class;
    }
}
