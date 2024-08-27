using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.AppUserDTOs
{
    public class LoginRegisterAppModelAddDTOs
    {
        [Required(ErrorMessage = "Boş geçilemez")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        public string PassWord { get; set; }
    }
}
