using AutoMapper;
using PortalMe.API.DTOs.LogAdmins;
using PortalMe.API.DTOs.Roles;
using PortalMe.API.Models;
using PortalMe.API.Repositories.Data;
using PortalMe.API.Repositories.Interfaces;
using PortalMe.API.Services.Interfaces;

namespace PortalMe.API.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;

        public RoleService(IRoleRepository roleRepository, IMapper mapper)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
        }
        public async Task<int> CreateAsync(RoleRequestDto roleRequestDto)
        {
            var role = _mapper.Map<Role>(roleRequestDto);

            await _roleRepository.CreateAsync(role);

            return 1; // success
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            var data = await _roleRepository.GetByIdAsync(id);

            if (data == null) return 0; // not found

            await _roleRepository.DeleteAsync(data);

            return 1; // success
        }

        public async Task<IEnumerable<RoleResponseDto>?> GetAllAsync()
        {
            var data = await _roleRepository.GetAllAsync();

            var dataMap = _mapper.Map<IEnumerable<RoleResponseDto>>(data);

            return dataMap; // success
        }

        public async Task<RoleResponseDto?> GetByIdAsync(Guid id)
        {
            var data = await _roleRepository.GetByIdAsync(id);

            var dataMap = _mapper.Map<RoleResponseDto>(data);

            return dataMap; // success
        }

        public async Task<int> UpdateAsync(Guid id, RoleRequestDto roleRequestDto)
        {
            var data = await _roleRepository.GetByIdAsync(id);
            await _roleRepository.ChangeTrackingAsync();
            if (data == null) return 0; // not found

            var role = _mapper.Map<Role>(roleRequestDto);

            role.Id = id;
            await _roleRepository.UpdateAsync(role);

            return 1; // success
        }
    }
}
