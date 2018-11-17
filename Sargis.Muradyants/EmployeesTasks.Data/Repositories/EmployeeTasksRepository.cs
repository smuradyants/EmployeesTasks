using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using EmployeesTasks.Data.Entities;
using EmployeesTasks.Data.Repositories.Interfaces;

namespace EmployeesTasks.Data.Repositories
{
    public class EmployeeTasksRepository : BaseRepository<EmployeeTask>, IEmployeeTasksRepository
    {
        public EmployeeTasksRepository(DbContext context) : base(context)
        {
            
        }

        public IEnumerable<EmployeeTask> GetEmployeeTasks(int employeeId)
        {
            return AppContext.EmployeeTasks.Where(et => et.EmployeeId == employeeId).Include(e => e.PriorityLevel).OrderBy(p=>p.PriorityLevel.Order).ToList();
        }

        public EmployeeTask GetEmployeeTask(int taskId)
        {
            return AppContext.EmployeeTasks.Include(e => e.Employee).Include(e => e.PriorityLevel).Include(e => e.State).Where(et => et.Id == taskId).FirstOrDefault();
        }
    }   
}
