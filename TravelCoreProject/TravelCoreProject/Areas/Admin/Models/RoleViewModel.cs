using System.ComponentModel.DataAnnotations;

namespace TravelCoreProject.Areas.Admin.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage ="Boş Geçilemez")]
        [MaxLength(50,ErrorMessage ="Maksimum karakter sınırı 50")]
        [MinLength(2,ErrorMessage ="Minimum karakter sınırı 1")]
        public string Name { get; set; }
    }
}
