using API.Repositories.Data;
using PortalMe.API.Data;
using PortalMe.API.Models;
using PortalMe.API.Repositories.Interfaces;

namespace PortalMe.API.Repositories.Data
{
    public class LogAdminRepository : GeneralRepository<LogAdmin>, ILogAdminRepository
    {
        public LogAdminRepository(PortalMeDbContext context) : base(context)
        {
        }
    }
}
