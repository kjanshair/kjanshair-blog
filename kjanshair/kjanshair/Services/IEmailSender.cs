using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kjanshair.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string name, string email, string subject, string message);

        Task<bool> VerifyAsync(string EncodedResponse);
    }
}
