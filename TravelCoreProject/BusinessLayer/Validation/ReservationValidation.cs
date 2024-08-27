using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class ReservationValidation : AbstractValidator<Reservation>
    {
        public ReservationValidation()
        {
            RuleFor(x=> x.Description).NotEmpty().WithMessage("Boş geçilemez");    
            RuleFor(x=> x.ReservationDate).NotEmpty().WithMessage("Boş geçilemez");    
            RuleFor(x=> x.PersonCount).NotEmpty().WithMessage("Boş geçilemez");    
        }
    }
}
