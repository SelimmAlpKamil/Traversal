using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Guide
    {
        [Key]
        public int GuideID { get; set; }

        [Required(ErrorMessage ="Boş geçilemez")]
        public string GuideName { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public string GuideImage { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        [MaxLength(50,ErrorMessage ="Makisimum Karakter Sınırı")]
        public string GuideDescripton { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public string GuideInstagramURL { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public string GuideXURL { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public bool GuideStatus { get; set; }

        public ICollection<Destination> Destination { get; set; }

    }
}
