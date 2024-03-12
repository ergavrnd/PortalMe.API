namespace PortalMe.API.DTOs.LogAdmins;

    public record LogAdminResponseDto(
        Guid Id,
        string action,
        DateTime time,
        Guid accountId);