namespace PortalMe.API.DTOs.ViewModels;

    public record ListResponseVM<TEntity>(
        int Code,
        string Status,
        string Message,
        IEnumerable<TEntity> Data
        );