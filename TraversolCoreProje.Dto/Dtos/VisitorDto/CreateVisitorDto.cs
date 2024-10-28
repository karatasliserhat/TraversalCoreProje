namespace TraversolCoreProje.Dto.Dtos
{
    public class CreateVisitorDto:CreateBaseDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Mail { get; set; }
    }
}
