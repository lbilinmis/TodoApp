using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TodoApp.Entities.Concrete;

namespace TodoApp.DataAccess.Configurations
{
    public class WorkConfiguration : IEntityTypeConfiguration<Work>
    {
        public void Configure(EntityTypeBuilder<Work> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Definition).HasMaxLength(100).IsRequired();
            builder.Property(x => x.IsCompleted).IsRequired();
        }
    }
}
