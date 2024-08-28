namespace TraversolCoreProje.Dto.Dtos
{
    public class CreateFeatureDto:CreateBaseDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
