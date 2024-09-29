namespace TraversalCoreProje.ViewModels
{

    public class RootObject
    {
        public string type { get; set; }
        public string title { get; set; }
        public int status { get; set; }
        public Dictionary<string, string[]> Errors { get; set; }
        public string traceId { get; set; }
    }


}


