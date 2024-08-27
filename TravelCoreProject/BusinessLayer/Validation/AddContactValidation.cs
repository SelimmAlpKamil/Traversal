using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class AddContactValidation : AbstractValidator<ContactUs>
    {
        public AddContactValidation()
        {
            RuleFor(x => x.ContactUsName).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.ContactUsMail).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.ContactUsMessage).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.ContactUsSubject).NotEmpty().WithMessage("Boş geçilemez");

            RuleFor(x => x.ContactUsName).MaximumLength(50).WithMessage("Maksimum karakter 50");
            RuleFor(x => x.ContactUsMail).MaximumLength(50).WithMessage("Maksimum karakter 50");
            RuleFor(x => x.ContactUsMessage).MaximumLength(500).WithMessage("Maksimum karakter 500");
            RuleFor(x => x.ContactUsSubject).MaximumLength(50).WithMessage("Maksimum karakter 50");

            RuleFor(x => x.ContactUsName).MinimumLength(1).WithMessage("Minimum karakter 1");
            RuleFor(x => x.ContactUsMail).MinimumLength(5).WithMessage("Minimum karakter 5");
            RuleFor(x => x.ContactUsMessage).MinimumLength(5).WithMessage("Minimum karakter 5");
            RuleFor(x => x.ContactUsSubject).MinimumLength(5).WithMessage("Minimum karakter 5");

        }
    }
}
