using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        public int? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }

        [Required(ErrorMessage ="Boş geçilemez")]
        public int? PersonCount { get; set; }
        
        [Required(ErrorMessage = "Boş geçilemez")]
        public DateTime? ReservationDate { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        public string status { get; set; }

        public Destination  Destination { get; set; }

        public int DestinationId { get; set; }



    }
}
