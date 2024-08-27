using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class AdminAboutValidation : AbstractValidator<About>
    {
        public AdminAboutValidation()
        {
            RuleFor(x=>x.AboutTitle1).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x=>x.AboutTitle2).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x=>x.AboutDetails1).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x=>x.AboutDetails2).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x=>x.AboutImage1).NotEmpty().WithMessage("Boş geçilemez");

            RuleFor(x => x.AboutTitle1).MaximumLength(500).WithMessage("Maksimum karakter sınırı 500");
            RuleFor(x => x.AboutTitle2).MaximumLength(500).WithMessage("Maksimum karakter sınırı 500");
            RuleFor(x => x.AboutDetails1).MaximumLength(5000).WithMessage("Maksimum karakter sınırı 5000");
            RuleFor(x => x.AboutDetails2).MaximumLength(5000).WithMessage("Maksimum karakter sınırı 5000");
            RuleFor(x => x.AboutImage1).MaximumLength(500).WithMessage("Maksimum karakter sınırı 500");

            RuleFor(x => x.AboutTitle1).MinimumLength(5).WithMessage("Minimum karakter sınırı 5");
            RuleFor(x => x.AboutTitle2).MinimumLength(5).WithMessage("Minimum karakter sınırı 5");
            RuleFor(x => x.AboutDetails1).MinimumLength(10).WithMessage("Minimum karakter sınırı 10");
            RuleFor(x => x.AboutDetails2).MinimumLength(10).WithMessage("Minimum karakter sınırı 10");
            RuleFor(x => x.AboutImage1).MinimumLength(5).WithMessage("Minimum karakter sınırı 5");
        }
    }
}
