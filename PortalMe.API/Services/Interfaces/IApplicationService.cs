using PortalMe.API.DTOs.Applications;
using PortalMe.API.DTOs.Employees;

namespace PortalMe.API.Services.Interfaces
{
    public interface IApplicationService
    {
        Task<IEnumerable<ApplicationResponseDto>?> GetAllAsync();
        Task<ApplicationResponseDto?> GetByIdAsync(Guid id);
        Task<int> CreateAsync(ApplicationRequestDto applicationRequestDto);
        Task<int> UpdateAsync(Guid id, ApplicationRequestDto applicationRequestDto);
        Task<int> DeleteAsync(Guid id);
    }
}
