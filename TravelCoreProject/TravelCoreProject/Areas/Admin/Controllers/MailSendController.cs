using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System.Linq;
using System.Net.Mail;
using TravelCoreProject.Areas.Admin.Models;

namespace TravelCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class MailSendController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AdminMail p)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("admin", "travelsalcoreinfo@gmail.com");
            
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", p.ReceiverMail);

            mimeMessage.To.Add(mailboxAddressTo);

            BodyBuilder bodyBuilder = new BodyBuilder();

            bodyBuilder.TextBody = p.Body;

            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = p.Subject;

            MailKit.Net.Smtp.SmtpClient client = new MailKit.Net.Smtp.SmtpClient();


            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("travelsalcoreinfo@gmail.com", "bjpu zeev tufm jcgo");
            client.Send(mimeMessage);
            client.Disconnect(true);

            return RedirectToAction("ActiveContact", "ContactUs");

        }
    }
}
