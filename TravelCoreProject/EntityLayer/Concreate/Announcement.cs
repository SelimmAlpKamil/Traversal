using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Announcement
    {
        public int AnnouncementId { get; set; }
        public string AnnouncementTitle { get; set; }
        public string AnnouncementContent { get; set; }
        public DateTime AnnouncementDate { get; set; }

        public bool AnnouncementStatus { get; set; }
    }
}
