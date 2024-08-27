using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class AboutPartner
    {
        [Key]
        public int AboutPartnerId { get; set; }
        public string AboutPartnerTitle1 { get; set; }
        public string AboutPartnerTitle2 { get; set; }
        public string AboutPartnerDescription { get; set; }
        public string AboutPartnerImage { get; set; }

    }

}
