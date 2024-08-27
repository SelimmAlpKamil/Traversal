using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class ContactUs
    {
        [Key]
        public int ContactUsID { get; set; }
        public string ContactUsName { get; set; }
        public string ContactUsMail { get; set; }
        public string ContactUsSubject { get; set; }
        public string ContactUsMessage { get; set; }
        public DateTime ContactUsDate { get; set; }
        public bool ContactUsStatus { get; set; }
    }
}
