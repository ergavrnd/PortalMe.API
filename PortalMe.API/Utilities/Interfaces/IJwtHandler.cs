using System.Security.Claims;

namespace API.Utilities.Interfaces
{
    public interface IJwtHandler
    {
        string Generate(IEnumerable<Claim> claims);
    }
}
