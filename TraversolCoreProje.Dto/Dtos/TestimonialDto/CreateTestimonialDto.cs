namespace TraversolCoreProje.Dto.Dtos
{
    public class CreateTestimonialDto:CreateBaseDto
    {
        public string Client { get; set; }
        public string Comment { get; set; }
        public string ClientImage { get; set; }
    }
}
