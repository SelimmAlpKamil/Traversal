using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace TravelCoreProject.Areas.Admin.Models
{
    public class AdminProfileViewModel
    {
        [Required(ErrorMessage = "Boş geçilemez")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public string PassWord { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        [Compare("PassWord", ErrorMessage = "Şifre Eşleşmiyor")]
        public string ConfigPassWord { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public string ImageURL { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public string Mail { get; set; }
    }
}
