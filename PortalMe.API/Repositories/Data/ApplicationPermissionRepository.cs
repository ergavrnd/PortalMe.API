﻿using API.Repositories.Data;
using PortalMe.API.Data;
using PortalMe.API.Models;
using PortalMe.API.Repositories.Interfaces;

namespace PortalMe.API.Repositories.Data
{
    public class ApplicationPermissionRepository : GeneralRepository<ApplicationPermission>, IApplicationPermissionRepository
    {
        public ApplicationPermissionRepository(PortalMeDbContext context) : base(context)
        {
        }
    }
}
