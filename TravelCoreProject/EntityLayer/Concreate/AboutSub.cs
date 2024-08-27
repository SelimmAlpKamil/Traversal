using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class AboutSub
    {
        [Key]
        public int AboutId { get; set; }
        public string AboutTitle { get; set; }
        public string AboutDescription { get; set; }
    }
}
