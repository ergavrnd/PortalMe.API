namespace PortalMe.API.DTOs.Accounts
{
    public class AccountResponseDto
    {
        public Guid Id { get; init; }
        public string Email { get; init; }
        public string Password { get; init; }
        public bool IsLoggedIn { get; init; }
        public IEnumerable<string> Roles { get; init; }
    }
}
