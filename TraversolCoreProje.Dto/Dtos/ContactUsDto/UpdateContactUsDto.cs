namespace TraversolCoreProje.Dto.Dtos
{
    public class UpdateContactUsDto:UpdateBaseDto
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string MessageBody { get; set; }
        public DateTime MessageDate { get; set; }
    }
}
