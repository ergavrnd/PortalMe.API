namespace PortalMe.API.DTOs.Employees;

    public record EmployeeResponseDto(
    Guid Id,
    string FirstName,
    string LastName,
    string Photo,
    string Position,
    string Department);
        

