using FluentValidation;
using Journey.Communication.Requests;
using Journey.Exception;

namespace Journey.Application.UseCases.Activities.Register
{
    public class RegisterActvityValidator : AbstractValidator<RequestRegisterActivityJson>
    {
        public RegisterActvityValidator()
        {
            RuleFor(request => request.Name).NotEmpty().WithMessage(ResourceErrorMessage.NAME_EMPTY);
        }
    }
}
