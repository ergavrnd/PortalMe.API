namespace PortalMe.API.DTOs.ViewModels;
    public record CustomErrorResponseVM(
        int Code, 
        string Status,
        string Message,
        string ErrorDetails
        );