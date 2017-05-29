using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using kjanshair.Services;
using kjanshair.Models.ContactViewModel;
using System.Net;
using Microsoft.AspNetCore.Authorization;

namespace kjanshair.Controllers
{
    public class HomeController : Controller
    {
        private IEmailSender _sender;

        public HomeController(IEmailSender sender)
        {
            _sender = sender;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contact(ContactViewModel model)
        {
            string EncodedResponse = Request.Form["captchaResponse"];
            bool IsCaptchaValid = await _sender.VerifyAsync(EncodedResponse);

            if (IsCaptchaValid)
            {
                await _sender.SendEmailAsync(model.Name, model.Email, model.Subject, model.Message);
                return View();
            }
            else
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return View(model);
            }
        }

        [Authorize(Policy = "AdministratorOnly")]
        public IActionResult Administrator()
        {
            return View();
        }

        [HttpGet("/Home/Error/{statusCode}")]
        public IActionResult Error(int statusCode)
        {
            return View(statusCode);
        }
    }
}
