namespace PortalMe.API.DTOs.Accounts;

public record RegisterDto(
    string FirstName,
    string LastName,
    string Email,
    string Photo,
    string Position,
    string Department,
    Guid CompanyId,
    string Password,
    string ConfirmPassword
    );