using AutoMapper;
using LeaveMnagementSystem.web.Data;
using LeaveMnagementSystem.web.Models.LeaveTypes;

namespace LeaveMnagementSystem.web.MappingProfile
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<LeaveType, LeaveTypeReadOnlyVM>();
            CreateMap<LeaveTypeCreateVM, LeaveType>();
            CreateMap<LeaveTypeEditVM, LeaveType>().ReverseMap();
            CreateMap<LeaveTypeDeleteVM, LeaveType>();

        }
    }
}
