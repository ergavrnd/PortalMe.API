using FluentValidation;
using PortalMe.API.DTOs.Employees;

namespace PortalMe.API.Utilities.Validations.Employees
{
    public class EmployeeRequestValidator : AbstractValidator<EmployeeRequestDto>
    {
        public EmployeeRequestValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("First Name is required");
            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Last Name is required");
            RuleFor(x => x.Department)
                .NotEmpty().WithMessage("Department is required");
            RuleFor(x => x.Position)
                .NotEmpty().WithMessage("First Name is required");
        }
    }
}
