using TraversalCoreProje.CoreLayer.BaseConcrete;

namespace TraversalCoreProje.CoreLayer.Concrete
{
    public class Announcement:BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}
