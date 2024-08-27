using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class AppUser: IdentityUser<int>
    {
        [Key]

        public string ImageURL { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }






    }
}
