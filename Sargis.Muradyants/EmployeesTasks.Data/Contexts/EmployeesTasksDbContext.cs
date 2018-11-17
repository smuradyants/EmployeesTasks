using EmployeesTasks.Data.Entities;
using EmployeesTasks.Data.EntityConfigurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EmployeesTasks.Data
{
    public class EmployeesTasksDbContext : IdentityDbContext<IdentityUser>
    {
        public EmployeesTasksDbContext(DbContextOptions<EmployeesTasksDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<EmployeeTask> EmployeeTasks { get; set; }

        public DbSet<PriorityLevel> PriorityLevels { get; set; }

        public DbSet<State> States { get; set; }      

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new EmployeeConfiguration());
            builder.ApplyConfiguration(new EmployeeTaskConfiguration());
            builder.ApplyConfiguration(new PriorityLevelConfiguration());
            builder.ApplyConfiguration(new StateConfiguration());           
        }
    }
}
