using FluentValidation;
using FluentValidation_Sample.Models;

namespace FluentValidation_Sample.Validations
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(customer => customer.FirstName)
                .NotEmpty().WithName("Nome").WithMessage(Constants.REQUIRE_MESSAGE)
                .MaximumLength(100).WithMessage(Constants.MAX_LENGHT_MESSAGE);              

            RuleFor(customer => customer.LastName)
                .NotEmpty().WithName("Sobrenome").WithMessage(Constants.REQUIRE_MESSAGE)
                .MaximumLength(100).WithMessage(Constants.MAX_LENGHT_MESSAGE); ;

            RuleFor(customer => customer.Email).NotEmpty().EmailAddress();

            RuleFor(customer => customer.Age)
                .NotEmpty().WithName("Idade").WithMessage(Constants.REQUIRE_MESSAGE)
                .InclusiveBetween(18, 80).WithMessage($"{Constants.INCLUSIVE_BEETWEN_MESSAGE} anos"); 

            RuleFor(customer => customer.Address).SetValidator(new AddressValidator());
        }
    }
}
