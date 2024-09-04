namespace TraversolCoreProje.Dto.Dtos
{
    public class CreateCommentDto:CreateBaseDto
    {
        public string User { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }

        public int DestinationId { get; set; }
    }
}
