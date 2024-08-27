using System.ComponentModel.DataAnnotations;

namespace TravelCoreProject.Areas.Admin.Models
{
    public class VisitoryViewModel
    {
  
        public int VisitorId { get; set; }

        [Required(ErrorMessage ="Boş geçilemez")]
        public string VisitorName { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public string VisitorSurname { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public string VisitorCity { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public string VisitorCountry { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public string VisitorMail { get; set; }
    }
}
