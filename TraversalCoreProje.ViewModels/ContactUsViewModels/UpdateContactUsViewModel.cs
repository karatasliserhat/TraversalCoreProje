namespace TraversalCoreProje.ViewModels
{
    public class UpdateContactUsViewModel:UpdateBaseViewModel
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string MessageBody { get; set; }
        public DateTime MessageDate { get; set; }
    }
}
