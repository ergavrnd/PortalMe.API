using API.Repositories.Interfaces;
using API.Utilities.Interfaces;
using AutoMapper;
using PortalMe.API.DTOs.Accounts;
using PortalMe.API.Models;
using PortalMe.API.Repositories.Interfaces;
using PortalMe.API.Services.Interfaces;
using PortalMe.API.Utilities.Handlers;
using System.Security.Claims;

namespace PortalMe.API.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IAccountRoleRepository _accountRoleRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;
        private readonly IJwtHandler _jwtHandler;

        public AccountService(IAccountRepository accountRepository, IMapper mapper,
                         IAccountRoleRepository accountRoleRepository, IRoleRepository roleRepository,
                         IEmployeeRepository employeeRepository, IJwtHandler jwtHandler)
        {
            _accountRepository = accountRepository;
            _mapper = mapper;
            _accountRoleRepository = accountRoleRepository;
            _employeeRepository = employeeRepository;
            _roleRepository = roleRepository;
            _jwtHandler = jwtHandler;
        }
        


        public async Task<int> AddAccountRoleAsync(AddAccountRoleRequestDto addAccountRoleRequestDto)
        {
            var account = await _accountRepository.GetByIdAsync(addAccountRoleRequestDto.AccountId);

            if (account == null) return 0; // Account not found

            var role = await _roleRepository.GetByIdAsync(addAccountRoleRequestDto.RoleId);

            if (role == null) return -1; // Account not found

            var accountRole = _mapper.Map<AccountRole>(addAccountRoleRequestDto);

            await _accountRoleRepository.CreateAsync(accountRole);

            return 1; // success

        }

        public async Task<int> CreateAsync(AccountRequestDto accountRequestDto)
        {
            await using var transaction = await _accountRepository.BeginTransactionAsync();
            try
            {
                var account = _mapper.Map<Account>(accountRequestDto);

                await _accountRepository.CreateAsync(account);

                var Role = await _roleRepository.GetByNameAsync("Employee"); //bikin admin
                

                if (Role == null) return 0;
                var accountRole = new AccountRole { AccountId = accountRequestDto.Id,
                                                    RoleId = Role.Id};

                await _accountRoleRepository.CreateAsync(accountRole);

                await transaction.CommitAsync();

                return 1; // success}
            }

            catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            var data = await _accountRepository.GetByIdAsync(id);

            if (data == null) return 0; // not found

            await _accountRepository.DeleteAsync(data);

            return 1; // success
        }

        public async Task<IEnumerable<AccountResponseDto>?> GetAllAsync()
        {
            var data = await _accountRepository.GetAllAsync();

            var dataMap = _mapper.Map<IEnumerable<AccountResponseDto>>(data);

            return dataMap; // success
        }

        public async Task<AccountResponseDto?> GetByIdAsync(Guid id)
        {
            var account = await _accountRepository.GetByIdAsync(id);

            if (account == null) return null; // not found 

            var dataMap = _mapper.Map<AccountResponseDto>(account);

            return dataMap; // success
        }

        public async Task<LoginResponseDto?> LoginAsync(LoginRequestDto loginRequestDto)
        {
            var account = await _accountRepository.GetByEmailAsync(loginRequestDto.Email);

            if (account == null)
            {
                throw new Exception("Akun tidak ditemukan.");
            }// not found

            //Verifikasi Password
            var isPasswordValid = BCrpytHandler.VerifyPassword(loginRequestDto.Password, account.Password);
            if (!isPasswordValid)
            {
                loginRequestDto = new LoginRequestDto(loginRequestDto.Email, account.Password);
            }

            //mengumpulkan peran dari akun
            var claims = new List<Claim>();

            var accountRole = account.AccountRoles.Select(ar => ar.Role.RoleName);
            foreach (var role in accountRole)
            {
                claims.Add(new Claim(ClaimTypes.Email, account.Email));
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            //membuat token JWT
            var token = _jwtHandler.Generate(claims);

            return new LoginResponseDto(token);
        }

        public async Task<int> RegisterAsync(RegisterDto registerDto)
        {
            await using var transaction = await _accountRepository.BeginTransactionAsync();
            try
            {
                var employee = _mapper.Map<Employee>(registerDto);

                var employeeResult = await _employeeRepository.CreateAsync(employee);

                var account = _mapper.Map<Account>(registerDto);

                account.Id = employeeResult.Id;

                var accountResult = await _accountRepository.CreateAsync(account);

                var roleEmployee = await _roleRepository.GetByNameAsync("Employee");

                var roleAdmin = await _roleRepository.GetByNameAsync("Admin");

                if (roleEmployee == null || roleAdmin == null) return -1; // Role not found 

                var accountRoleAdmin = new AccountRole
                {
                    AccountId = accountResult.Id,
                    RoleId = roleAdmin.Id
                };

                var accountRoleEmployee = new AccountRole
                {
                    AccountId = accountResult.Id,
                    RoleId = roleEmployee.Id
                };

                await _accountRoleRepository.CreateAsync(accountRoleAdmin);
                await _accountRoleRepository.CreateAsync(accountRoleEmployee);
                await transaction.CommitAsync();
                return 1; // success
            }
            catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        public async Task<int> RemoveRoleAsync(RemoveAccountRoleRequestDto removeAccountRoleRequestDto)
        {
           var accountRole =
           await _accountRoleRepository.GetDataByAccountIdAndRoleAsync(removeAccountRoleRequestDto.AccountId,
                                                                       removeAccountRoleRequestDto.RoleId);

            if (accountRole == null) return 0; // Account or Role not found

            await _accountRoleRepository.DeleteAsync(accountRole);

            return 1; // success
        }

        public async Task<int> UpdateAsync(Guid id, AccountRequestDto accountRequestDto)
        {
            var data = await _accountRepository.GetByIdAsync(id);
            await _accountRepository.ChangeTrackingAsync();
            if (data == null) return 0; // not found

            var account = _mapper.Map<Account>(accountRequestDto);

            account.Id = id;
            await _accountRepository.UpdateAsync(account);

            return 1; // success
        }
    }
}