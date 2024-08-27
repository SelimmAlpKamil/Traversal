using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class NewLetterValidation : AbstractValidator<NewLetter>
    {
        public NewLetterValidation()
        {
            RuleFor(x=>x.NewLetterMail).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x=>x.NewLetterMail).MinimumLength(5).WithMessage("Minimum karakter sınırı");
            RuleFor(x=>x.NewLetterMail).MaximumLength(50).WithMessage("Maksimum karakter sınırı");
        }
    }
}
