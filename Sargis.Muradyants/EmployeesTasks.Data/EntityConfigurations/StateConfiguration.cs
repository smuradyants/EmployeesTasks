using EmployeesTasks.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeesTasks.Data.EntityConfigurations
{
    public class StateConfiguration : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.HasKey(p => p.Id);

            builder.ToTable("States");

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);            
        }
    }
}
