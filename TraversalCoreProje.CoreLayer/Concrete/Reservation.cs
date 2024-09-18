using TraversalCoreProje.CoreLayer.BaseConcrete;

namespace TraversalCoreProje.CoreLayer.Concrete
{
    public class Reservation:BaseEntity
    {
        
        public int AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public string PersonCount { get; set; }
        public int DestinationId { get; set; }
        public virtual Destination Destination { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string StatusL { get; set; }
    }
}
