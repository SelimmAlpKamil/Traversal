using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTOLayer.ProfileEditViewModelDTOs
{
    public class ProfileEditVİewModelAddDTOs
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
        public IFormFile Image { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        public string Mail { get; set; }
    }
}
