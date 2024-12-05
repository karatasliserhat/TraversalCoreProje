namespace TraversalCoreProje.ViewModels
{
    public class ResultCommentViewModel : ResultBaseViewModel
    {
        public int AppUserId { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public string DestinationCityName { get; set; }
        public string ImageFile { get; set; }

        public int DestinationId { get; set; }
        public string DataProtect { get; set; }

        public string FullName { get { return UserName + " " + UserSurname; } }
    }
}
