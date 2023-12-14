using MireaCore.Models;
using Newtonsoft.Json;

namespace MireaCore.RequestSenders;

public class MireaRequestSender
{ 
    private HttpClient _client;
    public MireaRequestSender(HttpClient client)
    {
        _client = client;
        GetAppToken("http://94.103.83.231:5186/mirea/signInApp");
    }

    public async Task GetAppToken(string url)
    {
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri(url)
        };
        var response = await _client.SendAsync(request);
        var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        System.Environment.SetEnvironmentVariable("token", responseBody);
    }
    public async Task<TokenModel> SignIn(string email,string url)
    {
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri(url+"?email="+email)
        };
        var response = await _client.SendAsync(request);
        var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
       
        return new TokenModel(){email = email,token = url};
    }

    public async Task<UserModel> GetUserInfo(string email,string AppToken,string url)
    {
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(url+"/"+email)
        };
        request.Headers.Add("Authorization", "Bearer "+AppToken);
        var response = await _client.SendAsync(request);
        var responseBody =  JsonConvert.DeserializeObject<UserModel>(await response.Content.ReadAsStringAsync());

        return responseBody;
    }
    public async Task<UserModel> GetUserInfo(string userToken,string url)
    {
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(url)
        };
        request.Headers.Add("Authorization", "Bearer "+userToken);
        var response = await _client.SendAsync(request);
        var responseBody =  JsonConvert.DeserializeObject<UserModel>(await response.Content.ReadAsStringAsync());

        return responseBody;
    }
    public async Task<List<UserModel>> GetUsersInfo(string AppToken,string url)
    {
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(url)
        };
        request.Headers.Add("Authorization", "Bearer "+AppToken);
        var response = await _client.SendAsync(request);
        var responseBody =  JsonConvert.DeserializeObject<List<UserModel>>(await response.Content.ReadAsStringAsync());
    
        return responseBody;
    }

    public async Task<List<UserModel>> GetUsersByGroup(string AppToken, string url)
    {
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(url)
        };
        request.Headers.Add("Authorization", "Bearer "+AppToken);
        var response = await _client.SendAsync(request);
        var responseBody =  JsonConvert.DeserializeObject<List<UserModel>>(await response.Content.ReadAsStringAsync());
    
        return responseBody;
    }

    public async Task<List<GroupModel>> GetGroups(string AppToken, string url)
    {
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(url)
        };
        request.Headers.Add("Authorization", "Bearer "+AppToken);
        var response = await _client.SendAsync(request);
        var responseBody =  JsonConvert.DeserializeObject<List<GroupModel>>(await response.Content.ReadAsStringAsync());
    
        return responseBody;
    }
   
}