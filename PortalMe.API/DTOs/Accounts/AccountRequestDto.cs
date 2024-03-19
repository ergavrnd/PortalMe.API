namespace PortalMe.API.DTOs.Accounts;

    public record AccountRequestDto(
    Guid Id,
    string Email,
    string Password);