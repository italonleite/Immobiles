using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Immobiles.Domain.Models.Validation
{
    public class UserValidation : AbstractValidator<User>
    {
        public ValidationResult ValidationResult { get; protected set; }

        
        public bool IsValid(User user)
        {
            ValidationResult = new UserValidation().Validate(user);
            return ValidationResult.IsValid;
        }
        public UserValidation()
        {
            RuleFor(u => u.Login)
                .NotEmpty().WithMessage("Por favor, certifique-se de ter inserido o nome")
                .Length(2, 20).WithMessage("O Login deve ter entre 2 e 20 caracteres");

            RuleFor(u => u.Password)
               .NotEmpty().WithMessage("Por favor, certifique-se de ter inserido a senha");


            RuleFor(u => u.Email)
                .NotEmpty().EmailAddress();

            RuleFor(u => u.Id)
                .NotEqual(Guid.Empty);
        }
    }
}
