using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesTasks.Data.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<EmployeeTask> EmployeeTasks { get; set; } = new List<EmployeeTask>();
    }
}
