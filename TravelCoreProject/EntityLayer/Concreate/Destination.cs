using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Destination
    {
        [Key]
        public int DestinationId { get; set; }

        [Required(ErrorMessage ="Boş geçilemez")]
        public string DestinationCity { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        [MaxLength(50,ErrorMessage ="Maksimum 50 karakter olabilir")]
        public string DestinationDescription { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public string DestinationDescriptionLong1 { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public string DestinationDescriptionLong2 { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public string DestinationImage { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public string DestinationImageDetail { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public string DestinationImageCover { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public string DestinationDayAndNight { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public bool DestinationStatus { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public double DestinationPrice { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public int DestinationCapacity { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public bool FeatureMainPost { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public bool FeatureSubPost { get; set; }
        
        public Guide Guide { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        public int GuideID { get; set; }

        public ICollection<Comment> Comment { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
