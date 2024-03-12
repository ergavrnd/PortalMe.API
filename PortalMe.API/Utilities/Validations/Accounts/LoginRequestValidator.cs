using FluentValidation;
using PortalMe.API.DTOs.Accounts;

namespace PortalMe.API.Utilities.Validations.Accounts
{
    public class LoginRequestValidator : AbstractValidator<LoginRequestDto>
    {
        public LoginRequestValidator() {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("email is required")
                .EmailAddress().WithMessage("Invalid email address");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("password is required");
        }
    }
}
