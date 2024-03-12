using FluentValidation;
using PortalMe.API.DTOs.Accounts;

namespace PortalMe.API.Utilities.Validations.Accounts
{
    public class RegisterRequestValidator : AbstractValidator<RegisterDto>
    {
        public RegisterRequestValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("First Name is required");
            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Last name is required");
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("email is required")
                .EmailAddress().WithMessage("Invalid email address");
            RuleFor(x => x.Position)
                .NotEmpty().WithMessage("position is required");
            RuleFor(x => x.Department)
                .NotEmpty().WithMessage("department is required");
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("password is required");
            RuleFor(x => x.ConfirmPassword)
                .NotEmpty().WithMessage("confirm password is required");


        }
    }
}

