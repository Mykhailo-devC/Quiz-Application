﻿using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace QuizProject.Services
{
    public interface IEmailService
    {
        Task SendEmailAsync(string toEmail, string subject, string mail);
    }
    public class EmailService: IEmailService
    {
        private IConfiguration _configuration;
        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendEmailAsync(string toEmail, string subject, string mail)
        {
            MailAddress to = new MailAddress(toEmail);
            MailAddress from = new MailAddress(_configuration["EmailSender:EmailFrom:From"], _configuration["EmailSender:EmailFrom:Name"]);
            MailMessage mailMessage = new MailMessage(from, to);
            mailMessage.Subject = subject;
            mailMessage.Body = mail;
            mailMessage.IsBodyHtml = true;

            SmtpClient smtpClient = new SmtpClient(_configuration["SMTP:Client:Host"], Convert.ToInt32(_configuration["SMTP;Client:Port"]));
            smtpClient.Credentials = new NetworkCredential(_configuration["SMTP:Credentials:Name"], _configuration["SMTP:Credentials:Password"]);
            smtpClient.EnableSsl = true;

            await smtpClient.SendMailAsync(mailMessage);

        }
    }
}
