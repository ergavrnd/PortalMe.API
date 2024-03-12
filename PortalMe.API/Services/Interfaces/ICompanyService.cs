using PortalMe.API.DTOs.Applications;
using PortalMe.API.DTOs.Companys;

namespace PortalMe.API.Services.Interfaces
{
    public interface ICompanyService
    {
        Task<IEnumerable<CompanyResponseDto>?> GetAllAsync();
        Task<CompanyResponseDto?> GetByIdAsync(Guid id);
        Task<int> CreateAsync(CompanyRequestDto companyRequestDto);
        Task<int> UpdateAsync(Guid id, CompanyRequestDto companyRequestDto);
        Task<int> DeleteAsync(Guid id);
    }
}
