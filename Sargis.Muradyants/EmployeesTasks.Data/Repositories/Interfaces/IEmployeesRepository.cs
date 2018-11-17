using EmployeesTasks.Data.Entities;
using EmployeesTasks.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesTasks.Data.Repositories.Interfaces
{
    public interface IEmployeesRepository : IBaseRepository<Employee>
    {
        
    }
}
