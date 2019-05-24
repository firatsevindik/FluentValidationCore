using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidationCore.Models;

namespace FluentValidationCore.Validators
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("The Name field is required").Length(3, 50).WithMessage("'Name' must be between 3 and 50 characters long.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("The Email field is required").EmailAddress().WithMessage("'Email' is not a valid email address.");
            RuleFor(x => x.Age).InclusiveBetween(18, 60).WithMessage("'Age' must be between 18 and 60.");
        }
    }
}
