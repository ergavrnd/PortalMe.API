using PortalMe.API.DTOs.Accounts;

namespace PortalMe.API.Services.Interfaces;

    public interface IAccountService
    {
    Task<int> RegisterAsync(RegisterDto registerDto);
    Task<LoginResponseDto?> LoginAsync(LoginRequestDto loginRequestDto);

    Task<int> AddAccountRoleAsync(AddAccountRoleRequestDto addAccountRoleRequestDto);

    Task<int> RemoveRoleAsync(RemoveAccountRoleRequestDto removeAccountRoleRequestDto);

    Task<IEnumerable<AccountResponseDto>?> GetAllAsync();

    Task<AccountResponseDto?> GetByIdAsync(Guid id);

    Task<int> CreateAsync(AccountRequestDto accountRequestDto);

    Task<int> UpdateAsync(Guid id, AccountRequestDto accountRequestDto);

    Task<int> DeleteAsync(Guid id);

}

