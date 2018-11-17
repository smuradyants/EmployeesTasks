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
    public class EmployeesRepository : BaseRepository<Employee>, IEmployeesRepository
    {
        public EmployeesRepository(DbContext context) : base(context)
        {
            
        }
    }   
}
