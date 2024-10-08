namespace TraversalCoreProje.Shared.Interfaces
{
    public interface IExcelReportApiService
    {
        Task GetListDestinationExcelReport();
        Task GetListDestinationExcelReport(string actionName);
    }
}
