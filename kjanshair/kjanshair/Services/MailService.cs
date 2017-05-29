using kjanshair.Models;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using MimeKit;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace kjanshair.Services
{
    public class MailService : IEmailSender
    {
        public IConfigurationRoot Configuration { get; }

        public async Task SendEmailAsync(string name, string email, string subject, string message)
        {
            var mimeMessage = new MimeMessage();
            mimeMessage.From.Add(new MailboxAddress(subject, "<FROM-EMAIL>"));
            mimeMessage.To.Add(new MailboxAddress(subject, "<TO-EMAIL>"));
            mimeMessage.Subject = subject;

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = $"<div class='col-md-12' style='text-align: center; font-family: Segoe UI; font-weight: 400'><h1 style = 'font-family: Segoe UI; font-weight: 700'> {name}: {email} </h1><h2 style = 'font-family: Segoe UI; font-weight: 600'> {subject} </h2><h4 style = 'font-family: Segoe UI; font-weight: 500' >{message}</h4></div>";

            mimeMessage.Body = bodyBuilder.ToMessageBody();

            using (var client = new SmtpClient())
            {

                client.Connect("<SMTP-HOST>", 587, false);
                // Note: only needed if the SMTP server requires authentication  
                // Error 5.5.1 Authentication   
                client.Authenticate("<FROM-EMAIL>", "<APP-PASSORD>");
                await client.SendAsync(mimeMessage);
                client.Disconnect(true);
            }
        }

        public async Task<bool> VerifyAsync(string encodedResponse)
        {
            var client = new HttpClient();

            string privateKey = "<Your-Captcha-Private-Key>";
            
            var GoogleReply = await client.GetStringAsync(string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", privateKey, encodedResponse));

            return JsonConvert.DeserializeObject<CaptchaResponse>(GoogleReply).Success;
        }
    }
}
