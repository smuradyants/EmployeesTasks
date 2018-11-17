using EmployeesTasks.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesTasks.Data.Seeders
{
    public class SeedStates
    {
        public static async Task InitializeAsync(EmployeesTasksDbContext context)
        {
            if (!context.States.Any())
            {
                var states = new List<State>
                {
                    new State { Name = "New" },
                    new State { Name = "Active" },
                    new State { Name = "Resolved" },
                    new State { Name = "Closed" }
                };

                await context.States.AddRangeAsync(states);
                await context.SaveChangesAsync();
            }            
        }
    }
}
