using EmployeesTasks.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeesTasks.Data.EntityConfigurations
{
    public class EmployeeTaskConfiguration : IEntityTypeConfiguration<EmployeeTask>
    {
        public void Configure(EntityTypeBuilder<EmployeeTask> builder)
        {
            builder.HasKey(p => p.Id);

            builder.ToTable("EmployeeTasks");

            builder.Property(p => p.Title)
                .IsRequired();

            builder.HasOne(x => x.State)
                .WithMany(x => x.StateTasks)
                .HasForeignKey(x => x.StateId)                
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.PriorityLevel)
                .WithMany(x => x.PriorityLevelTasks)
                .HasForeignKey(x => x.PriorityLevelId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Employee)
                .WithMany(x => x.EmployeeTasks)
                .HasForeignKey(x => x.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
