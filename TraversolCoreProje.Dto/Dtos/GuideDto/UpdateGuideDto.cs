namespace TraversolCoreProje.Dto.Dtos
{
    public class UpdateGuideDto:UpdateBaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string TwitterUrl { get; set; }
        public string InstagramUrl { get; set; }
    }
}
