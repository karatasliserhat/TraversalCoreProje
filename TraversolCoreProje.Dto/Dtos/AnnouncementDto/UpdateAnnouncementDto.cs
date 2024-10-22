namespace TraversolCoreProje.Dto.Dtos
{
    public class UpdateAnnouncementDto:UpdateBaseDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}
