
using Microsoft.EntityFrameworkCore;
using PortalMe.API.Data;
using PortalMe.API.Models;
using PortalMe.API.Repositories.Interfaces;

namespace API.Repositories.Data;

public class RoleRepository : GeneralRepository<Role>, IRoleRepository
{
    public RoleRepository(PortalMeDbContext context) : base(context) { }

    public async Task<Role?> GetByNameAsync(string name)
    {
        return await _context.Set<Role>().FirstOrDefaultAsync(r => r.RoleName == name);
    }
}
