    using System.ComponentModel.DataAnnotations;

    namespace TravelCoreProject.Models
    {
	    public class ChangePasswordViewModel
	    {
        public string UserId { get; set; }
        public string token { get; set; }


        [Required(ErrorMessage ="Boş bırakmayız")]
            public string Password { get; set; }
            [Required(ErrorMessage ="Boş bırakmayız")]
            [Compare("Password", ErrorMessage ="Şifre eşleşmiyoır")]
            public string ConfigPassword { get; set; }
        }
    }
