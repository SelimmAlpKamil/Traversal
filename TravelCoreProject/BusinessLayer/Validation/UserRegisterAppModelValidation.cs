using DTOLayer.AppUserDTOs;
using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class UserRegisterAppModelValidation : AbstractValidator<UserRegisterAppModelAddDTOs>
    {
        public UserRegisterAppModelValidation()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x=>x.Surname).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x=>x.Username).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x=>x.Mail).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x=>x.Password).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x=>x.ConfirmPassword).NotEmpty().WithMessage("Boş geçilemez");

            RuleFor(x => x.Name).MaximumLength(20).WithMessage("Maksimum 20 karakter ");
            RuleFor(x => x.Surname).MaximumLength(20).WithMessage("Maksimum 20 karakter ");
            RuleFor(x => x.Username).MaximumLength(20).WithMessage("Maksimum 20 karakter ");
            RuleFor(x => x.Mail).MaximumLength(20).WithMessage("Maksimum 20 karakter ");
            RuleFor(x => x.Password).MaximumLength(50).WithMessage("Maksimum 50 karakter ");
            RuleFor(x => x.ConfirmPassword).MaximumLength(50).WithMessage("Maksimum 50 karakter ");

            RuleFor(x => x.Name).MinimumLength(1).WithMessage("Minimum 1 karakter ");
            RuleFor(x => x.Surname).MinimumLength(1).WithMessage("Minimum 1 karakter ");
            RuleFor(x => x.Username).MinimumLength(4).WithMessage("Minimum 4 karakter ");
            RuleFor(x => x.Mail).MinimumLength(10).WithMessage("Minimum 10 karakter ");
            RuleFor(x => x.Password).MinimumLength(6).WithMessage("Minimum 6 karakter ");
            RuleFor(x => x.ConfirmPassword).MinimumLength(6).WithMessage("Minimum 6 karakter ");

            RuleFor(x => x.ConfirmPassword).Equal(x => x.Password).WithMessage("Şifre eşleşmiyor");
           
        }
    }
}
