using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace AccesoDatos.ServiciosCorreo
{
    public abstract class ServiciosCorreo
    {
        private SmtpClient smtpClient;
        protected string SenderMail {  get; set; }
        protected string Password { get; set; }
        protected string Host { get; set; }
        protected int Port { get; set; }
        protected bool ssl { get; set; }


        protected void InitializeSmtpClient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(SenderMail, Password);
            smtpClient.Host = Host;
            smtpClient.Port = Port;
            smtpClient.EnableSsl = ssl;

        }

        public void sendMail(string subject, string body, List<string> recipientMail)
        {
            var MailMessage = new MailMessage();
            try
            {
                MailMessage.From = new MailAddress(SenderMail);
                foreach (string mail in recipientMail)
                {
                    MailMessage.To.Add(mail);
                }
                MailMessage.Subject = subject;
                MailMessage.Body = body;
                MailMessage.Priority = MailPriority.Normal;
                smtpClient.Send(MailMessage);
            }
            catch(Exception){}
            finally {
                MailMessage.Dispose();
                smtpClient?.Dispose();
            }
        }
    }
}
