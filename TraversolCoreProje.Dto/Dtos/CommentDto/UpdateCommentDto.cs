namespace TraversolCoreProje.Dto.Dtos
{
    public class UpdateCommentDto:UpdateBaseDto
    {
        public int AppUserId { get; set; }

        public DateTime Date { get; set; }
        public string Content { get; set; }

        public int DestinationId { get; set; }
    }
}
