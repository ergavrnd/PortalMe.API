using API.Repositories.Interfaces;
using PortalMe.API.Models;

namespace PortalMe.API.Repositories.Interfaces
{
    public interface IRoleRepository : IRepository<Role>
    {
        Task<Role?> GetByNameAsync(string name);
    }
}
