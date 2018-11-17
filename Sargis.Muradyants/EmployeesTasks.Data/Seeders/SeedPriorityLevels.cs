using EmployeesTasks.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesTasks.Data.Seeders
{
    public class SeedPriorityLevels
    {
        public static async Task InitializeAsync(EmployeesTasksDbContext context)
        {
            if (!context.PriorityLevels.Any())
            {
                var priorityLevels = new List<PriorityLevel>
            {
                new PriorityLevel { Name = "Critical", Order = 1 },
                new PriorityLevel { Name = "Medium" , Order = 2 },
                new PriorityLevel { Name = "Low" , Order = 3 }
            };

                await context.PriorityLevels.AddRangeAsync(priorityLevels);
                await context.SaveChangesAsync();
            }            
        }
    }   
}
