using EmailCore.Logic;
using Grpc.Core;

namespace EmailCore.Services;

public class EmailService : Email.EmailBase
{
    private Mailer _mailer;
    
    public EmailService()
    {
        _mailer = new Mailer();
    }

    public override Task<EmailSendReply> SendLetter(EmailSendRequest request, ServerCallContext context)
    {
        _mailer.SendEmail(request.Recipient,request.Text,request.Subject,request.Attachments,request.IsHtml);
        return Task.FromResult(new EmailSendReply()
        {
            Reply = ""
        });
    }
}