using Grpc.Net.Client;
using WebCore.Configs;

namespace WebCore.Communicators;

public class MireaRequestCommunicator
{
    public readonly MireaCore.MireaCoreClient _mireaClient;

    public MireaRequestCommunicator()
    {
        var config = ConfigReader.GetGrpc("MireaCore").Result;


        GrpcChannel channel = GrpcChannel.ForAddress($"http://{config.Host}:{config.Port}");
        _mireaClient = new MireaCore.MireaCoreClient(channel);
    }

    public async Task<SignInResponse> SignIn(string email)
    {
       return await _mireaClient.SignInAsync(new SignInRequest(){Email = email});
    }

    public async Task<GetUserResponse> GetUserByEmail(string email)
    {
        return await _mireaClient.GetUserByEmailAsync(new GetUserRequest() { Email = email });
    }
    
    public async Task<GetUserResponse> GetUser(string email,string token)
    {
        return await _mireaClient.GetUserAsync(new GetUser1Request() { Email = email,Token = token});
    }
}