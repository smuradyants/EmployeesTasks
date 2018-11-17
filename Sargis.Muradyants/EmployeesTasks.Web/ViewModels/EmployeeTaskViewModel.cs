using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesTasks.Data.Entities
{
    public class EmployeeTaskViewModel
    {
        public int Id { get; set; }        
        public string Title { get; set; }
        public string Description { get; set; }        
        public string Estimate { get; set; }
        public int EmployeeId { get; set; }
        public int PriorityLevelId { get; set; }
        public int StateId { get; set; }        
        public EmployeeViewModel Employee { get; set; }
        public PriorityLevelViewModel PriorityLevel { get; set; }
        public StateViewModel State { get; set; }        
    }
}
