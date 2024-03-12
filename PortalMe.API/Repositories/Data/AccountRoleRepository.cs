using API.Repositories.Data;
using API.Repositories.Interfaces;
using PortalMe.API.Data;
using PortalMe.API.Models;

namespace PortalMe.API.Repositories.Data
{
    public class AccountRoleRepository : GeneralRepository<AccountRole>, IAccountRoleRepository
    {
        public AccountRoleRepository(PortalMeDbContext context) : base(context)
        {
        }

        public Task<IEnumerable<AccountRole?>> GetByAccountIdAsync(Guid accountId)
        {
            throw new NotImplementedException();
        }

        public Task<AccountRole?> GetDataByAccountIdAndRoleAsync(Guid accountId, Guid roleId)
        {
            throw new NotImplementedException();
        }
    }
}
