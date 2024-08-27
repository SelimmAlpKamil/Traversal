using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class AboutValidation : AbstractValidator<About>
    {
        public AboutValidation()
        {
            RuleFor(x => x.AboutTitle1).NotEmpty().WithMessage("Boş Geçilemez...");
            RuleFor(x => x.AboutTitle2).NotEmpty().WithMessage("Boş Geçilemez...");
            RuleFor(x => x.AboutDetails1).NotEmpty().WithMessage("Boş Geçilemez...");
            RuleFor(x => x.AboutDetails2).NotEmpty().WithMessage("Boş Geçilemez...");
            RuleFor(x => x.AboutImage1).NotEmpty().WithMessage("Boş Geçilemez...");

            RuleFor(x => x.AboutTitle1).MaximumLength(100).WithMessage("Maksimum karakter sınırını aşıyor...");
            RuleFor(x => x.AboutTitle2).MaximumLength(100).WithMessage("Maksimum karakter sınırını aşıyor...");
            RuleFor(x => x.AboutDetails1).MaximumLength(1000).WithMessage("Maksimum karakter sınırını aşıyor...");
            RuleFor(x => x.AboutDetails2).MaximumLength(1000).WithMessage("Maksimum karakter sınırını aşıyor...");
            RuleFor(x => x.AboutImage1).MaximumLength(1000).WithMessage("Maksimum karakter sınırını aşıyor...");

            RuleFor(x => x.AboutTitle1).MinimumLength(5).WithMessage("Minimum karakter sınırını...");
            RuleFor(x => x.AboutTitle2).MinimumLength(5).WithMessage("Minimum karakter sınırını...");
            RuleFor(x => x.AboutDetails1).MinimumLength(20).WithMessage("Minimum karakter sınırını...");
            RuleFor(x => x.AboutDetails2).MinimumLength(20).WithMessage("Minimum karakter sınırını...");
            RuleFor(x => x.AboutImage1).MinimumLength(20).WithMessage("Minimum karakter sınırını...");

        }
    }
}
