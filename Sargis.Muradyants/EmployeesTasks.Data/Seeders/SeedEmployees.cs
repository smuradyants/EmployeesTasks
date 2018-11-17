using EmployeesTasks.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesTasks.Data.Seeders
{
    public class SeedEmployees
    {
        public static async Task InitializeAsync(EmployeesTasksDbContext context)
        {
            if (!context.Employees.Any())
            {
                var employees = new List<Employee>
                {
                    new Employee { Name = "Employee 1" },
                    new Employee { Name = "Employee 2" }
                };

                await context.Employees.AddRangeAsync(employees);
                await context.SaveChangesAsync();
            }
        }
    }
}
