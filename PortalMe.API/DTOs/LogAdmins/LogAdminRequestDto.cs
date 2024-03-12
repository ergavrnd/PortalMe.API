namespace PortalMe.API.DTOs.LogAdmins;

    public record LogAdminRequestDto(
        string action,
        DateTime time,
        Guid accountId);

