using Microsoft.AspNetCore.Identity;

namespace TravelCoreProject.Models
{
	public class CostemIdentityValidationcs:IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError()
			{
				Code="PasswordTooShort",
				Description = $"En az {length} karakter olması gerekmektedir"
				
			};
		}

		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError()
			{
				Code= "PasswordRequiresUpper",
				Description = "En az bir büyük harf olması gerekmektedir"
			};
		}

		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError()
			{
				Code= "PasswordRequiresLower",
				Description ="En az bir küçük harf olması gerekmektedir"
			};
		}

		public override IdentityError PasswordRequiresDigit()
		{
			return new IdentityError()
			{
				Code= "PasswordRequiresDigit",
				Description="Enz az bir adet rakam içermelidir"
			};
		}

		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return new IdentityError()
			{
				Code= "PasswordRequiresNonAlphanumeric",
				Description = "Enz az bir adet özel karakter içermelidir"
			};
		}


	}
}
