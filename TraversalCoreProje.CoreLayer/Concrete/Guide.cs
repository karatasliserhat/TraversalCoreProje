using TraversalCoreProje.CoreLayer.BaseConcrete;

namespace TraversalCoreProje.CoreLayer.Concrete
{
    public class Guide:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string TwitterUrl { get; set; }
        public string InstagramUrl { get; set; }

        public virtual List<Destination> Destinations { get; set; }
    }
}
