using TraversalCoreProje.CoreLayer.BaseConcrete;

namespace TraversalCoreProje.CoreLayer.Concrete
{
    public class Visitor:BaseEntity
    {
        public int City { get; set; }
        public int Count { get; set; }
        public DateTime VisitorDate { get; set; }
    }
}
