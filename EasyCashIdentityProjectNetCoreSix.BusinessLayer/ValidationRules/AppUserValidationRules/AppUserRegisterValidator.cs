using EasyCashIdentityProjectNetCoreSix.DtoLayer.Dtos.AppRoleDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProjectNetCoreSix.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name field cannot be empty");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Surname field be empty");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Username field be empty");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email field be empty");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password field be empty");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("ConfirmPassword field be empty");
           
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Please enter up to 30 characters");
            RuleFor(x => x.Name).MinimumLength(2).WithName("Please enter at least 2 characters");

            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Your passwords do not match");

            RuleFor(x => x.Email).EmailAddress().WithMessage("Please enter a valid email address");

            
        }
    }
}
