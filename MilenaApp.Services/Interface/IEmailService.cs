using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MilenaApp.Domain.DomainModels;

namespace MilenaApp.Services.Interface
{
    public interface IEmailService
    {
        Task SendEmailAsync(List<EmailMessage> allMails);
    }
}
