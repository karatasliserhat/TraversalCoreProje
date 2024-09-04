namespace TraversalCoreProje.ViewModels
{
    public class UpdateCommentViewModel:UpdateBaseViewModel
    {
        public string User { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }

        public int DestinationId { get; set; }
    }
}
