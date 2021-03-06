﻿using System.Threading.Tasks;

namespace Fixit.Application.Common.Services.Mail
{
    public interface IMailService
    {
        Task SendEmailAsync(string to, string subject, string content);
        Task SendEmailAsync(string from, string to, string subject, string content);
    }
}