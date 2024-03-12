using PortalMe.API.DTOs.Companys;
using PortalMe.API.DTOs.LogAdmins;

namespace PortalMe.API.Services.Interfaces
{
    public interface ILogAdminService
    {
        Task<IEnumerable<LogAdminResponseDto>?> GetAllAsync();
        Task<LogAdminResponseDto?> GetByIdAsync(Guid id);
        Task<int> CreateAsync(LogAdminRequestDto logAdminRequestDto);
        Task<int> UpdateAsync(Guid id, LogAdminRequestDto logAdminRequestDto);
        Task<int> DeleteAsync(Guid id);
    }
}
