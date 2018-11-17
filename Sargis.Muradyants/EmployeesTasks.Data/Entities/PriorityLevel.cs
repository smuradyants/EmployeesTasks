using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesTasks.Data.Entities
{
    public class PriorityLevel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }

        public virtual ICollection<EmployeeTask> PriorityLevelTasks { get; set; } = new List<EmployeeTask>();
    }
}
