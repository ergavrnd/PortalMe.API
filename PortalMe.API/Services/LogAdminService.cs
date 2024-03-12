using API.Repositories.Data;
using AutoMapper;
using PortalMe.API.DTOs.Employees;
using PortalMe.API.DTOs.LogAdmins;
using PortalMe.API.DTOs.Roles;
using PortalMe.API.Models;
using PortalMe.API.Repositories.Data;
using PortalMe.API.Repositories.Interfaces;
using PortalMe.API.Services.Interfaces;

namespace PortalMe.API.Services
{
    public class LogAdminService : ILogAdminService
    {
        private readonly ILogAdminRepository _logAdminRepository;
        private readonly IMapper _mapper;

        public LogAdminService(ILogAdminRepository logAdminRepository, IMapper mapper)
        {
            _logAdminRepository = logAdminRepository;
            _mapper = mapper;
        }

        public async Task<int> CreateAsync(LogAdminRequestDto logAdminRequestDto)
        {
            var logAdmin = _mapper.Map<LogAdmin>(logAdminRequestDto);

            await _logAdminRepository.CreateAsync(logAdmin);

            return 1; // success
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            var data = await _logAdminRepository.GetByIdAsync(id);

            if (data == null) return 0; // not found

            await _logAdminRepository.DeleteAsync(data);

            return 1; // success
        }

        public async Task<IEnumerable<LogAdminResponseDto>?> GetAllAsync()
        {
            var data = await _logAdminRepository.GetAllAsync();

            var dataMap = _mapper.Map<IEnumerable<LogAdminResponseDto>>(data);

            return dataMap; // success
        }

        public async Task<LogAdminResponseDto?> GetByIdAsync(Guid id)
        {
            var data = await _logAdminRepository.GetByIdAsync(id);

            var dataMap = _mapper.Map<LogAdminResponseDto>(data);

            return dataMap; // success
        }

        public async Task<int> UpdateAsync(Guid id, LogAdminRequestDto logAdminRequestDto)
        {
            var data = await _logAdminRepository.GetByIdAsync(id);
            await _logAdminRepository.ChangeTrackingAsync();
            if (data == null) return 0; // not found

            var logAdmin = _mapper.Map<LogAdmin>(logAdminRequestDto);

            logAdmin.Id = id;
            await _logAdminRepository.UpdateAsync(logAdmin);

            return 1; // success
        }
    }
}
