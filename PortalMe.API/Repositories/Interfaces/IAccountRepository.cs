// using API.Models;
using PortalMe.API.Models;

namespace API.Repositories.Interfaces;

public interface IAccountRepository : IRepository<Account>
{
    Task<Account?> GetByEmailAsync(string email);
}
