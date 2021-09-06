using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Credits1
{
    static class SendDataByEmail
    {
        public static void SendEmail(string data, string emailTo)
        {
            var client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("miro.bank.nik@gmail.com", "NikitaIsProgrammer");//TODO: Сменить почту и пароль на свои
            //trade.organizationMGK@    "!worst_prog39"
            var mail = new MailMessage();
            mail.From = new MailAddress("trade.nikitosikus01@gmail.com");
            mail.To.Add(emailTo);
            mail.IsBodyHtml = true;
            mail.Subject = "Таблица с данными";
            string[] paragraphs = data.Split('\n');
            string mailBody = string.Empty;
            foreach (var p in paragraphs)
            {
                mailBody += $"<p>{p}</p>";
            }

            mail.Body = mailBody;
            client.Send(mail);
        }
        public static void SendConfirmCode(string emailTo, int code)
        {
            var client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("miro.bank.nik@gmail.com", "NikitaIsProgrammer");

            var mail = new MailMessage();
            mail.From = new MailAddress("miro.bank.nik@gmail.com");
            mail.To.Add(emailTo);
            mail.IsBodyHtml = true;
            mail.Subject = "Код подтверждения";
            mail.Body = $"<p>Код подтверждения: {code}</p>";

            client.Send(mail);
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                if (!(addr.Address == email))
                {
                    throw new Exception();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsConnectedToInternet()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
