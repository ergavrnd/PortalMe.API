using API.Repositories.Interfaces;
using AutoMapper;
using PortalMe.API.DTOs.Accounts;
using PortalMe.API.DTOs.Applications;
using PortalMe.API.DTOs.Employees;
using PortalMe.API.Models;
using PortalMe.API.Repositories.Data;
using PortalMe.API.Repositories.Interfaces;
using PortalMe.API.Services.Interfaces;

namespace PortalMe.API.Services
{
    public class ApplicationService : IApplicationService
    {
        private readonly IApplicationRepository _applicationRepository;
        private readonly IMapper _mapper;

        public ApplicationService(IApplicationRepository applicationRepository, IMapper mapper)
        {
            _applicationRepository = applicationRepository;
            _mapper = mapper;
        }

        public async Task<int> CreateAsync(ApplicationRequestDto applicationRequestDto)
        {
            var application = _mapper.Map<Application>(applicationRequestDto);

            await _applicationRepository.CreateAsync(application);

            return 1; // success
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            var data = await _applicationRepository.GetByIdAsync(id);

            if (data == null) return 0; // not found

            await _applicationRepository.DeleteAsync(data);

            return 1; // success
        }

        public async Task<IEnumerable<ApplicationResponseDto>?> GetAllAsync()
        {
            var data = await _applicationRepository.GetAllAsync();

            var dataMap = _mapper.Map<IEnumerable<ApplicationResponseDto>>(data);

            return dataMap; // success
        }

        public async Task<ApplicationResponseDto?> GetByIdAsync(Guid id)
        {
            var data = await _applicationRepository.GetByIdAsync(id);

            var dataMap = _mapper.Map<ApplicationResponseDto>(data);

            return dataMap; // success
        }

        public async Task<int> UpdateAsync(Guid id, ApplicationRequestDto applicationRequestDto)
        {
            var data = await _applicationRepository.GetByIdAsync(id);
            await _applicationRepository.ChangeTrackingAsync();
            if (data == null) return 0; // not found

            var application = _mapper.Map<Application>(applicationRequestDto);

            application.Id = id;
            await _applicationRepository.UpdateAsync(application);

            return 1; // success
        }
    }
}
