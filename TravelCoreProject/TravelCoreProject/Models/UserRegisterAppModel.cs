using System.ComponentModel.DataAnnotations;

namespace TravelCoreProject.Models
{
	public class UserRegisterAppModel
	{
        [Required(ErrorMessage ="Boş bırakmayınız")]
        public string Name { get; set; }
		[Required(ErrorMessage = "Boş bırakmayınız")]
		public string Surname { get; set; }
		[Required(ErrorMessage = "Boş bırakmayınız")]
		public string Username { get; set; }
		[Required(ErrorMessage = "Boş bırakmayınız")]
		public string Mail { get; set; }
		[Required(ErrorMessage = "Boş bırakmayınız")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Boş bırakmayınız")]
		[Compare("Password",ErrorMessage ="Şifre eşleşmiyor")]
		public string ConfirmPassword { get; set; }
        

    }
}
