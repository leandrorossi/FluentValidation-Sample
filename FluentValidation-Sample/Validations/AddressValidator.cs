using FluentValidation;
using FluentValidation_Sample.Models;

namespace FluentValidation_Sample.Validations
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(customer => customer.AddressName)
              .NotEmpty().WithName("Endereço").WithMessage(Constants.REQUIRE_MESSAGE)
              .MaximumLength(100).WithMessage(Constants.MAX_LENGHT_MESSAGE);

            RuleFor(customer => customer.Region)
                .NotEmpty().WithName("Bairro").WithMessage(Constants.REQUIRE_MESSAGE)
                .MaximumLength(100).WithMessage(Constants.MAX_LENGHT_MESSAGE);

            RuleFor(customer => customer.City)
                .NotEmpty().WithName("Cidade").WithMessage(Constants.REQUIRE_MESSAGE)
                .MaximumLength(100).WithMessage(Constants.MAX_LENGHT_MESSAGE);

            RuleFor(customer => customer.State)
                .NotEmpty().WithName("Estado").WithMessage(Constants.REQUIRE_MESSAGE)
                .MaximumLength(100).WithMessage(Constants.MAX_LENGHT_MESSAGE);

            RuleFor(customer => customer.ZipCode)
                .NotEmpty().WithName("CEP").WithMessage(Constants.REQUIRE_MESSAGE)
                .MaximumLength(100).WithMessage(Constants.MAX_LENGHT_MESSAGE);
        }
    }
}
