namespace PortalMe.API.DTOs.ViewModels;

    public record SingleResponseVM<TEntity>(
        int Code,
        string Status,
        string Message,
        TEntity Data);