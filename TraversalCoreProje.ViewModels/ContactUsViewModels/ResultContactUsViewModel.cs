namespace TraversalCoreProje.ViewModels
{
    public class ResultContactUsViewModel:ResultBaseViewModel
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string MessageBody { get; set; }
        public DateTime MessageDate { get; set; }
        public string DataProtect { get; set; }
    }
}
