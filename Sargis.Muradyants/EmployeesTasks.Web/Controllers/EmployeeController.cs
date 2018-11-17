using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EmployeesTasks.Data;
using EmployeesTasks.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesTasks.Web.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IMapper m_Mapper;
        private IUnitOfWork m_UnitOfWork;

        public EmployeeController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            m_UnitOfWork = unitOfWork;
            m_Mapper = mapper;
        }        

        [HttpGet("[action]")]
        public IEnumerable<EmployeeViewModel> GetAllEmployees()
        {
            var employees = m_UnitOfWork.EmployeesRepository.GetAll().OrderBy(e => e.Name).ToList();
            var employeesVm = m_Mapper.Map<IEnumerable<EmployeeViewModel>>(employees);

            return employeesVm;
        }

        [HttpGet("[action]/{id}")]
        public IEnumerable<EmployeeTaskViewModel> GetEmployeeTasks(int id)
        {
            var employeeTasks = m_UnitOfWork.EmployeeTasksRepository.GetEmployeeTasks(id);
            var employeeTasksVm = m_Mapper.Map<IEnumerable<EmployeeTaskViewModel>>(employeeTasks);

            return employeeTasksVm;
        }

        [HttpGet("[action]/{id}")]
        public EmployeeTaskViewModel GetEmployeeTask(int id)
        {
            var employeeTask = m_UnitOfWork.EmployeeTasksRepository.GetEmployeeTask(id);
            var employeeTaskVm = m_Mapper.Map<EmployeeTaskViewModel>(employeeTask);

            return employeeTaskVm;
        }
    }
}
