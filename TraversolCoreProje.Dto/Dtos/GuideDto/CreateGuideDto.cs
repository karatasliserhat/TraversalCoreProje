namespace TraversolCoreProje.Dto.Dtos
{
    public class CreateGuideDto:CreateBaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string TwitterUrl { get; set; }
        public string InstagramUrl { get; set; }
    }
}
