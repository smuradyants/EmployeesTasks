using EmployeesTasks.Data.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;

namespace EmployeesTasks.Data
{
    public interface IUnitOfWork
    {
        IEmployeeTasksRepository EmployeeTasksRepository { get; }
        IEmployeesRepository EmployeesRepository { get; }
        IConfiguration Configuration { get; }
        int SaveChanges();
    }
}
