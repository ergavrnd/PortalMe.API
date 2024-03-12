using API.Repositories.Data;
using API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using PortalMe.API.Data;
using PortalMe.API.Models;

namespace PortalMe.API.Repositories.Data
{
    public class AccountRepository : GeneralRepository<Account>, IAccountRepository
    {
        public AccountRepository(PortalMeDbContext context) : base(context) { }

        public async Task<Account?> GetByEmailAsync(string email)
        {
            return await _context.Set<Account>().FirstOrDefaultAsync(a => a.Email == email);
        }
    }

}
