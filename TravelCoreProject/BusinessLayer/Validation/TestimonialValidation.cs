using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class TestimonialValidation : AbstractValidator<Testimonial>
    {
        public TestimonialValidation()
        {
            RuleFor(x => x.TestimonialClient).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.TestimonialComment).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.TestimonialImage).NotEmpty().WithMessage("Boş geçilemez");

            RuleFor(x => x.TestimonialClient).MaximumLength(50).WithMessage("Maksimum karakter sınırı 50");
            RuleFor(x => x.TestimonialComment).MaximumLength(500).WithMessage("Maksimum karakter sınırı 500");
            RuleFor(x => x.TestimonialImage).MaximumLength(500).WithMessage("Maksimum karakter sınırı 500");

            RuleFor(x => x.TestimonialClient).MinimumLength(1).WithMessage("Minimum karakter sınırı 1");
            RuleFor(x => x.TestimonialComment).MinimumLength(5).WithMessage("Minimum karakter sınırı 5");
            RuleFor(x => x.TestimonialImage).MinimumLength(5).WithMessage("Minimum karakter sınırı 5");
        }
    }
}
