using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class AddCommnetValidation : AbstractValidator<Comment>
    {
        public AddCommnetValidation()
        {
            RuleFor(x=>x.CommentName).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x=>x.CommentName).MaximumLength(50).WithMessage("Maksimum 50 karakter sınırı");
            RuleFor(x=>x.CommentName).MinimumLength(1).WithMessage("Minimum 1 karakter sınırı");

            RuleFor(x => x.CommentMessage).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.CommentMessage).MaximumLength(500).WithMessage("Maksimum 500 karakter sınırı");
            RuleFor(x => x.CommentMessage).MinimumLength(5).WithMessage("Minimum 5 karakter sınırı");


        }
    }
}
