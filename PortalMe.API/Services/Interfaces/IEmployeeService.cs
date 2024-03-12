﻿using PortalMe.API.DTOs.Companys;
using PortalMe.API.DTOs.Employees;

namespace PortalMe.API.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeResponseDto>?> GetAllAsync();
        Task<EmployeeResponseDto?> GetByIdAsync(Guid id);
        Task<int> CreateAsync(EmployeeRequestDto employeeRequestDto);
        Task<int> UpdateAsync(Guid id, EmployeeRequestDto employeeRequestDto);
        Task<int> DeleteAsync(Guid id);
    }
}
