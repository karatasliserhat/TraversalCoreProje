using TraversalCoreProje.CoreLayer.BaseConcrete;

namespace TraversalCoreProje.CoreLayer.Concrete
{
    public class Comment:BaseEntity
    {
        public string User { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }

        public int DestinationId { get; set; }
        public virtual Destination Destination { get; set; }
    }
}
