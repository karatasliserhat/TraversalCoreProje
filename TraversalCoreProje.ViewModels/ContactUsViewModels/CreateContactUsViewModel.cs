namespace TraversalCoreProje.ViewModels
{
    public class CreateContactUsViewModel:CreateBaseViewModel
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string MessageBody { get; set; }
        public DateTime MessageDate { get; set; }
    }
}
