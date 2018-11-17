using AutoMapper;
using EmployeesTasks.Data.Entities;

namespace EmployeesTasks.Web.Helpers.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Employee, EmployeeViewModel>();
            CreateMap<EmployeeViewModel, Employee>();

            CreateMap<EmployeeTask, EmployeeTaskViewModel>();
            CreateMap<EmployeeTaskViewModel, EmployeeTask>();

            CreateMap<PriorityLevel, PriorityLevelViewModel>();
            CreateMap<PriorityLevelViewModel, PriorityLevel>();

            CreateMap<State, StateViewModel>();
            CreateMap<StateViewModel, State>();
        }
    }
}
