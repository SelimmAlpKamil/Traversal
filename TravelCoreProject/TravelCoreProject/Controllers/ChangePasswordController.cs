using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using OfficeOpenXml.FormulaParsing.LexicalAnalysis;
using System.Threading.Tasks;
using TravelCoreProject.Models;

namespace TravelCoreProject.Controllers
{
    [AllowAnonymous]
    public class ChangePasswordController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ChangePasswordController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordViewModels p)
        {
            var user = await _userManager.FindByEmailAsync(p.Mail);

            if (user == null)
            {
                ViewBag.user = "Böyle bir kullanıcı bulunamadı";
                return View(p);
            }

            var userToken = await _userManager.GeneratePasswordResetTokenAsync(user);

            var userTokenLink = Url.Action("ResetPassword", "ChangePassword", new
            {
                userId = user.Id,
                token = userToken
            }, HttpContext.Request.Scheme);

            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("admin", "travelsalcoreinfo@gmail.com");

            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", p.Mail);

            mimeMessage.To.Add(mailboxAddressTo);

            BodyBuilder bodyBuilder = new BodyBuilder();

            bodyBuilder.TextBody = userTokenLink;

            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = "Şifre Sıfırlama linki";

            MailKit.Net.Smtp.SmtpClient client = new MailKit.Net.Smtp.SmtpClient();


            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("travelsalcoreinfo@gmail.com", "bjpu zeev tufm jcgo");
            client.Send(mimeMessage);
            client.Disconnect(true);

            return View();
        }

        [HttpGet]
        public IActionResult ResetPassword(string userid, string token)
        {
            var model = new ChangePasswordViewModel
            {
                UserId = userid,
                token = token
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ChangePasswordViewModel p)
        {
            var userId = p.UserId;
            var userToken = p.token;

            var user = await _userManager.FindByIdAsync(userId.ToString());

            if (p.Password == p.ConfigPassword && p.Password != null && p.ConfigPassword != null)
            {
                var result = await _userManager.ResetPasswordAsync(user, userToken.ToString(), p.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("SingIn", "Login");
                }
				else
				{
					foreach (var x in result.Errors)
					{
                        ModelState.AddModelError("",x.Description);
					}
				}
			}

            return View(p);
        }

    }
}
