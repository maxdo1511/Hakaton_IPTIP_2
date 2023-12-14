using System.Net;
using System.Net.Mail;
using EmailCore.Configs;

namespace EmailCore.Logic;

public class Mailer
{

    private List<string>? ParseAttachments(string attachments)
    {
        if (attachments == "")
        {
            return null;
        }
        else
        {
            string[] s = attachments.Split("-_-");
            return s.ToList();
        }
    }
    public async void SendEmail(string recipient, string text,string subject, string attachments,bool IsHtml)
    {
        var email = await ConfigReader.GetEmail();
        MailAddress from = new MailAddress(email.adress);
       
        MailAddress to = new MailAddress(recipient);
        MailMessage m = new MailMessage(from, to);
        
        m.Subject = subject;
        m.Body = text;
        m.IsBodyHtml = IsHtml;
        if (ParseAttachments(attachments) == null)
        {
            SmtpClient smtp = new SmtpClient(email.stmp, email.port);
            smtp.Credentials = new NetworkCredential(email.adress, email.password);
            smtp.EnableSsl = true;
            smtp.Send(m);
        }
        
      
    }
    
}