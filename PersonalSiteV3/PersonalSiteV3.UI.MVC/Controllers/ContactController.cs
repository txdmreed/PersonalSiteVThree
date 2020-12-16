using PersonalSiteV3.UI.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace PersonalSiteV3.UI.MVC.Controllers
{
    public class ContactController : Controller
    {
  
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(ContactViewModel cvm)
           {
            if (!ModelState.IsValid)
            {
                ViewBag.Message = "Error. Please, update with the required information.";
                return View(cvm);
            }

            string body = $"{cvm.Name} has sent you the following message:<br />" +
                    $"{cvm.Message} <strong>from the email address:<strong> {cvm.Email}";
                MailMessage m = new MailMessage("no-reply@reedcoding.com", "txdmreed@outlook.com", cvm.Subject, body);
                m.IsBodyHtml = true;
                m.Priority = MailPriority.High;
                m.ReplyToList.Add(cvm.Email);
                SmtpClient client = new SmtpClient("mail.reedcoding.com");
                client.Credentials = new NetworkCredential("no-reply@reedcoding.com", "P@ssW0rd");
                client.Port = 8889;
                try
                {
                    client.Send(m);
                }
                catch (Exception e)
                {
                    ViewBag.Message = $"Sorry, something went wrong, please try again later or review the stacktrace<br>{e.StackTrace}";
                    return View(cvm);
                }
                ViewBag.CustomerMessage = $"Message sent";
                return View("EmailConfirmation",cvm);
            

          
           
        }
    }
}