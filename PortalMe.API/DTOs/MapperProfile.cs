using AutoMapper;
using PortalMe.API.DTOs.Accounts;
using PortalMe.API.DTOs.Applications;
using PortalMe.API.DTOs.Companys;
using PortalMe.API.DTOs.Employees;
using PortalMe.API.DTOs.LogAdmins;
using PortalMe.API.DTOs.Roles;
using PortalMe.API.Models;
using PortalMe.API.Utilities.Handlers;

namespace PortalMe.API.DTOs
{
    public class MapperProfile : Profile
    {
        public MapperProfile() 
        {
            // For Employees
            CreateMap<RegisterDto, Employee>();
            CreateMap<EmployeeRequestDto, Employee>();
            CreateMap<Employee, EmployeeResponseDto>();

            // For Accounts
            CreateMap<RegisterDto, Account>()
              .ForMember(dest => dest.Password,
                         opt => opt.MapFrom(src => BCrpytHandler.HashPassword(src.Password)));

            CreateMap<AccountRequestDto, Account>()
           .ForMember(dest => dest.Password,
                      opt => opt.MapFrom(src => BCrpytHandler.HashPassword(src.Password)));

            CreateMap<Account, AccountResponseDto>()
            .ForMember(dest => dest.Roles,
                     opt => opt.MapFrom(src => src.AccountRoles.Select(ar => ar.Role.RoleName)));

            //For AccountRoles
            CreateMap<AddAccountRoleRequestDto, AccountRole>();
            CreateMap<RemoveAccountRoleRequestDto, AccountRole>();
            CreateMap<AccountRole, AccountRoleResponseDto>();

            //For Roles
            CreateMap<RoleRequestDto, Role>();
            CreateMap<Role, RoleResponseDto>();

            //For LogAdmins
            CreateMap<LogAdminRequestDto, LogAdmin>();
            CreateMap<LogAdmin, LogAdminResponseDto>();

            //For Companys
            CreateMap<CompanyRequestDto, Company>();
            CreateMap<Company, CompanyResponseDto>();

            //For Applications
            CreateMap<ApplicationRequestDto, Application>();
            CreateMap<Application, ApplicationResponseDto>();







        }
    }
}
