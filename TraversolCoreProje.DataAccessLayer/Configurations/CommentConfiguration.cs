using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TraversalCoreProje.CoreLayer.Concrete;

namespace TraversolCoreProje.DataAccessLayer.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasOne(x => x.Destination).WithMany(x => x.Comments).HasForeignKey(x => x.DestinationId);
        }
    }
}
