namespace TraversolCoreProje.Dto.Dtos
{
    public class ResultCommentDto : ResultBaseDto
    {
        public int AppUserId { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public string DestinationCityName { get; set; }
        public int DestinationId { get; set; }
        public string ImageFile { get; set; }
        public string NameSurname
        {
            get
            {

                return UserName + " " + UserSurname;
            }
        }
    }
}
