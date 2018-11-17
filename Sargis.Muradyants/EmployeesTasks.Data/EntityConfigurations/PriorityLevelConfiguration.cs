using EmployeesTasks.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeesTasks.Data.EntityConfigurations
{
    public class PriorityLevelConfiguration : IEntityTypeConfiguration<PriorityLevel>
    {
        public void Configure(EntityTypeBuilder<PriorityLevel> builder)
        {
            builder.HasKey(p => p.Id);

            builder.ToTable("PriorityLevels");

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.Order)
                .IsRequired();
        }
    }
}
