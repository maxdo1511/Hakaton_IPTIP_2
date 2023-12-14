using Grpc.Net.Client;
using LogicCore.Configs;
using Grpc.Core;

namespace LogicCore.Communicators;

public class EmailCommunicator
{
    private readonly Email.EmailClient _emailClient;

    public EmailCommunicator(IConfiguration configuration)
    {
        
        var config = ConfigReader.GetGrpc("MailSenderius").Result;


        GrpcChannel channel = GrpcChannel.ForAddress($"http://{config.Host}:{config.Port}");
        _emailClient = new Email.EmailClient(channel);
        
    }

    public async Task<EmailSendReply> SendLetter(string recipient, string text, string subject, string attachments,bool isHtml)
    {
        return await  _emailClient.SendLetterAsync(new EmailSendRequest()
        {
            Recipient = recipient,
            Text = text,
            Attachments = attachments,
            Subject = subject,
            IsHtml = isHtml
        });
    }
}