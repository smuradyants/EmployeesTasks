using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EmployeesTasks.Data.Entities;
using System.Threading.Tasks;

namespace EmployeesTasks.Data.Seeders
{
    public class SeedEmployeeTasks
    {
        public static async Task InitializeAsync(EmployeesTasksDbContext context)
        {
            if (!context.EmployeeTasks.Any())
            {
                var employeeTasks = new List<EmployeeTask>
                {
                    new EmployeeTask { Title = "Title 1", Description = "Description 1", Estimate = "2d", PriorityLevelId = 1, StateId = 1, EmployeeId = 1},
                    new EmployeeTask { Title = "Title 2", Description = "Description 2", Estimate = "5d", PriorityLevelId = 2, StateId = 2, EmployeeId = 1},
                    new EmployeeTask { Title = "Title 3", Description = "Description 3", Estimate = "6d", PriorityLevelId = 3, StateId = 3, EmployeeId = 1},
                    new EmployeeTask { Title = "Title 4", Description = "Description 4", Estimate = "7d", PriorityLevelId = 1, StateId = 4, EmployeeId = 2},
                    new EmployeeTask { Title = "Title 5", Description = "Description 5", Estimate = "8h", PriorityLevelId = 2, StateId = 1, EmployeeId = 2},
                    new EmployeeTask { Title = "Title 6", Description = "Description 6", Estimate = "11d", PriorityLevelId = 3, StateId = 2, EmployeeId = 2}
                };

                await context.EmployeeTasks.AddRangeAsync(employeeTasks);
                await context.SaveChangesAsync();
            }            
        }
    }
}
