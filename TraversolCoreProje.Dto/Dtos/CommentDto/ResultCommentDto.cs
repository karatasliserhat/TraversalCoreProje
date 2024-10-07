namespace TraversolCoreProje.Dto.Dtos
{
    public class ResultCommentDto:ResultBaseDto
    {
        public string User { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public string DestinationCityName { get; set; }
        public int DestinationId { get; set; }
    }
}
