using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class NewLetter
    {
        [Key]
        public int NewLetterId { get; set; }
        public string NewLetterMail { get; set; }
    }
}
