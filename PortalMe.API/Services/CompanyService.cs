using AutoMapper;
using PortalMe.API.DTOs.Applications;
using PortalMe.API.DTOs.Companys;
using PortalMe.API.Models;
using PortalMe.API.Repositories.Data;
using PortalMe.API.Repositories.Interfaces;
using PortalMe.API.Services.Interfaces;

namespace PortalMe.API.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;

        public CompanyService(ICompanyRepository companyRepository, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }
        public async Task<int> CreateAsync(CompanyRequestDto companyRequestDto)
        {

            var company = _mapper.Map<Company>(companyRequestDto);

            await _companyRepository.CreateAsync(company);

            return 1; // success
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            var data = await _companyRepository.GetByIdAsync(id);

            if (data == null) return 0; // not found

            await _companyRepository.DeleteAsync(data);

            return 1; // success
        }

        public async Task<IEnumerable<CompanyResponseDto>?> GetAllAsync()
        {
            var data = await _companyRepository.GetAllAsync();

            var dataMap = _mapper.Map<IEnumerable<CompanyResponseDto>>(data);

            return dataMap; // success
        }

        public async Task<CompanyResponseDto?> GetByIdAsync(Guid id)
        {
            var data = await _companyRepository.GetByIdAsync(id);

            var dataMap = _mapper.Map<CompanyResponseDto>(data);

            return dataMap; // success
        }

        public async Task<int> UpdateAsync(Guid id, CompanyRequestDto companyRequestDto)
        {
            var data = await _companyRepository.GetByIdAsync(id);
            await _companyRepository.ChangeTrackingAsync();
            if (data == null) return 0; // not found

            var company = _mapper.Map<Company>(companyRequestDto);

            company.Id = id;
            await _companyRepository.UpdateAsync(company);

            return 1; // success
        }
    }
}
