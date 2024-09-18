using Microsoft.AspNetCore.Identity;

namespace TraversalCoreProje.CoreLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageUrl { get; set; }
        public string Gender { get; set; }
        public virtual List<Reservation> Reservations { get; set; }
    }
}
