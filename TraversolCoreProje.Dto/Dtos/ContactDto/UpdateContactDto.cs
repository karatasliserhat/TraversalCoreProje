namespace TraversolCoreProje.Dto.Dtos
{
    public class UpdateContactDto:UpdateBaseDto
    {
        public string Description { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string MapLocation { get; set; }
    }
}
