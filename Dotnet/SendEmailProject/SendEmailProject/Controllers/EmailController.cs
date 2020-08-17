using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SendEmailProject.Models;

namespace SendEmailProject.Controllers
{
    public class EmailController : Controller
    {


        public EmailController()
        {

        }

        // GET: Email
        public async Task<IActionResult> Send()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Send(EmailModel model)
        {
            try

            {
                model.SenderEmail = "rajendiransangeetha@gmail.com";


                using (MailMessage mm = new MailMessage(model.SenderEmail, model.To))
                {
                    mm.Subject = model.Subject;
                    mm.Body = model.Body;


                    using (SmtpClient smtp = new SmtpClient())
                    {
                        smtp.Host = "kingmailer.org";                      
                        NetworkCredential NetworkCred = new NetworkCredential("rajendiransangeetha-gmail-com/free-trial", "FyKrbi3xot565jxPDGlFRttN");
                        smtp.Credentials = NetworkCred;
                        smtp.Port = 25;
                        smtp.Send(mm);
                        ViewBag.Message = "Email sent.";
                    }
                }
            }
            catch(Exception ex)
            {
                ViewBag.Message = "Email sending failed.";
            }

            return View();
        }

        // GET: Email/Details/5

    }
}
