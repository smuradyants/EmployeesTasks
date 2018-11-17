using EmployeesTasks.Data.Repositories;
using EmployeesTasks.Data.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace EmployeesTasks.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly EmployeesTasksDbContext m_Context;
        private IConfiguration m_Configuration;
        private IHttpContextAccessor HttpContextAccessor { get; set; }

        IEmployeeTasksRepository m_EmployeeTasksRepository;
        IEmployeesRepository m_EmployeesRepository;

        public UnitOfWork(EmployeesTasksDbContext context, IHttpContextAccessor httpAccessor, IConfiguration configuration)
        {
            m_Configuration = configuration;
            HttpContextAccessor = httpAccessor;
            m_Context = context;
        }

        public IConfiguration Configuration => m_Configuration;

        public IEmployeeTasksRepository EmployeeTasksRepository
        {
            get
            {
                if (m_EmployeeTasksRepository == null)
                    m_EmployeeTasksRepository = new EmployeeTasksRepository(m_Context);

                return m_EmployeeTasksRepository;
            }
        }

        public IEmployeesRepository EmployeesRepository
        {
            get
            {
                if (m_EmployeesRepository == null)
                    m_EmployeesRepository = new EmployeesRepository(m_Context);

                return m_EmployeesRepository;
            }
        }

        public int SaveChanges()
        {
            return m_Context.SaveChanges();
        }
    }
}
