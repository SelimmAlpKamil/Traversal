using DTOLayer.AnnouncementDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class AnnouncementValidation : AbstractValidator<AnnouncementAddDTOs>
    {
        public AnnouncementValidation()
        {
            RuleFor(x => x.AnnouncementTitle).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.AnnouncementContent).NotEmpty().WithMessage("Boş Geçilemez");

            RuleFor(x => x.AnnouncementTitle).MinimumLength(3).WithMessage("Minnimum 3 karakter");
            RuleFor(x => x.AnnouncementContent).MinimumLength(5).WithMessage("Minnimum 5 karakter");

            RuleFor(x => x.AnnouncementTitle).MaximumLength(20).WithMessage("Maksimum 20 karakter");
            RuleFor(x => x.AnnouncementContent).MaximumLength(500).WithMessage("Maksimum 500 karakter");
        }
    }
}
