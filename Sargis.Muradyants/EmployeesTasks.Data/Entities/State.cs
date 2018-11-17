using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesTasks.Data.Entities
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<EmployeeTask> StateTasks { get; set; } = new List<EmployeeTask>();
    }
}
