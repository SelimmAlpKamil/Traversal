using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class ContactValidation : AbstractValidator<Contact>
    {
        public ContactValidation()
        {
            RuleFor(x => x.ContactDescription).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.ContactAddress).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.ContactMail).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.ContactPhone).NotEmpty().WithMessage("Boş geçilemez");

            RuleFor(x => x.ContactDescription).MaximumLength(500).WithMessage("Maksimum karakter sınırı 500");
            RuleFor(x => x.ContactAddress).MaximumLength(500).WithMessage("Maksimum karakter sınırı 500");
            RuleFor(x => x.ContactMail).MaximumLength(100).WithMessage("Maksimum karakter sınırı 100");
            RuleFor(x => x.ContactPhone).MaximumLength(20).WithMessage("Maksimum karakter sınırı 100");

            RuleFor(x => x.ContactDescription).MinimumLength(5).WithMessage("Minimum karakter sınırı 5");
            RuleFor(x => x.ContactMail).MinimumLength(5).WithMessage("Minimum karakter sınırı 5");
            RuleFor(x => x.ContactPhone).MinimumLength(7).WithMessage("Minimum karakter sınırı 7");
        }
    }
}
