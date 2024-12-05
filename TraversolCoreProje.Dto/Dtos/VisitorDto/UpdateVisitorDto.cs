using TraversolCoreProje.Dto.Dtos.Enums;

namespace TraversolCoreProje.Dto.Dtos
{
    public class UpdateVisitorDto:UpdateBaseDto
    {
        public ECity City { get; set; }
        public int Count { get; set; }
    }
}
