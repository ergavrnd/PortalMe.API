using AutoMapper;
using PortalMe.API.DTOs.Companys;
using PortalMe.API.DTOs.Employees;
using PortalMe.API.Models;
using PortalMe.API.Repositories.Data;
using PortalMe.API.Repositories.Interfaces;
using PortalMe.API.Services.Interfaces;

namespace PortalMe.API.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        private readonly ICompanyRepository _companyRepository;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper, ICompanyRepository companyRepository)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
            _companyRepository = companyRepository;
        }
        public async Task<int> CreateAsync(EmployeeRequestDto employeeRequestDto)
        {
            var company = await _companyRepository.GetByIdAsync(employeeRequestDto.CompanyId);
            if (company == null)
            {
                return 0;
            }

            var employee = _mapper.Map<Employee>(employeeRequestDto);

            await _employeeRepository.CreateAsync(employee);

            return 1; // success
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            var data = await _employeeRepository.GetByIdAsync(id);

            if (data == null) return 0; // not found

            await _employeeRepository.DeleteAsync(data);

            return 1; // success
        }

        public async Task<IEnumerable<EmployeeResponseDto>?> GetAllAsync()
        {
            var data = await _employeeRepository.GetAllAsync();

            var dataMap = _mapper.Map<IEnumerable<EmployeeResponseDto>>(data);

            return dataMap; // success
        }

        public async Task<EmployeeResponseDto?> GetByIdAsync(Guid id)
        {
            var data = await _employeeRepository.GetByIdAsync(id);

            var dataMap = _mapper.Map<EmployeeResponseDto>(data);

            return dataMap; // success
        }

        public async Task<int> UpdateAsync(Guid id, EmployeeRequestDto employeeRequestDto)
        {
            var data = await _employeeRepository.GetByIdAsync(id);
            await _employeeRepository.ChangeTrackingAsync();
            if (data == null) return 0; // not found

            var employee = _mapper.Map<Employee>(employeeRequestDto);

            employee.Id = id;
            await _employeeRepository.UpdateAsync(employee);

            return 1; // success
        }
    }
}
