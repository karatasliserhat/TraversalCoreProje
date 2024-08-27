using TraversalCoreProje.CoreLayer.BaseConcrete;

namespace TraversalCoreProje.CoreLayer.Concrete
{
    public class Testimonial:BaseEntity
    {
        public string Client { get; set; }
        public string Comment { get; set; }
        public string ClientImage { get; set; }
    }
}
