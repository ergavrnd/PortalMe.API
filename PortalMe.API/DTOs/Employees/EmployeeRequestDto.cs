namespace PortalMe.API.DTOs.Employees;

    public record EmployeeRequestDto(
    string FirstName,
    string LastName,
    string Photo,
    string Position,
    string Department,
    Guid CompanyId);

