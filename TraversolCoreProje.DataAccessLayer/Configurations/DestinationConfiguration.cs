using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TraversalCoreProje.CoreLayer.Concrete;

namespace TraversolCoreProje.DataAccessLayer.Configurations
{
    public class DestinationConfiguration : IEntityTypeConfiguration<Destination>
    {
        public void Configure(EntityTypeBuilder<Destination> builder)
        {
            builder.HasOne(x => x.Guide).WithMany(x => x.Destinations).HasForeignKey(x => x.GuideId);
        }
    }
}
