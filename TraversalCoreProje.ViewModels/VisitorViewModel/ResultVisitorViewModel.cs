using TraversalCoreProje.ViewModels.BaseEnumsViewModel;

namespace TraversalCoreProje.ViewModels
{
    public class ResultVisitorViewModel:ResultBaseViewModel
    {
        public ECity City { get; set; }
        public int Count { get; set; }
        public DateTime VisitorDate { get; set; }

    }
}
