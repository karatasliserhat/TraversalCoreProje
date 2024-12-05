namespace TraversolCoreProje.Dto.Dtos
{
    public class VisitorChartDto
    {
        public VisitorChartDto()
        {
            Counts = new List<int>();
        }
        public string VisitDate { get; set; }
        public List<int> Counts { get; set; }
    }
}
