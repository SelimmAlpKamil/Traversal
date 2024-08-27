using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class AdminAboutSubValidation : AbstractValidator<AboutSub>
    {
        public AdminAboutSubValidation()
        {
            RuleFor(x=>x.AboutTitle).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x=>x.AboutDescription).NotEmpty().WithMessage("Boş Geçilemez");

            RuleFor(x=>x.AboutTitle).MaximumLength(500).WithMessage("Maksimum karakter sınırı 500");
            RuleFor(x=>x.AboutDescription).MaximumLength(5000).WithMessage("Maksimum karakter sınırı 5000");

            RuleFor(x => x.AboutTitle).MinimumLength(5).WithMessage("Minimum karakter sınırı 5");
            RuleFor(x => x.AboutDescription).MinimumLength(10).WithMessage("Minimum karakter sınırı 10");
        }
    }
}
