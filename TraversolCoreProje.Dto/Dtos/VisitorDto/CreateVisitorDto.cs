using TraversolCoreProje.Dto.Dtos.Enums;

namespace TraversolCoreProje.Dto.Dtos
{
    public class CreateVisitorDto:CreateBaseDto
    {
        public ECity City { get; set; }
        public int Count { get; set; }
        public DateTime VisitorDate { get; set; }

    }
}
