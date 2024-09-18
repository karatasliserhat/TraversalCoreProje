using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TraversalCoreProje.CoreLayer.Concrete;

namespace TraversolCoreProje.DataAccessLayer.Configurations
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasOne(x => x.AppUser).WithMany(x => x.Reservations).HasForeignKey(x => x.AppUserId);
            builder.HasOne(x => x.Destination).WithMany(x => x.Reservations).HasForeignKey(x => x.DestinationId);
        }
    }
}
