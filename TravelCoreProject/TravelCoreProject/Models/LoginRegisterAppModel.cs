using System.ComponentModel.DataAnnotations;

namespace TravelCoreProject.Models
{
    public class LoginRegisterAppModel
    {
 
        [Required(ErrorMessage ="Boş geçilemez")]
        public  string UserName { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        public  string PassWord { get; set; }
    }
}
