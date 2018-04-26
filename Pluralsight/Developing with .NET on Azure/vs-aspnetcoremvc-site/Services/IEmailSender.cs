using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vs_aspnetcoremvc_site.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
