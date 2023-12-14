using System.Text;
using Newtonsoft.Json;

namespace EmailCore.Configs;

public static class ConfigReader
{
    public static async Task<EmailConfig> GetEmail()
    {
        var json = string.Empty;
        using (var fs = File.OpenRead("MailSenderius/Configs/EmailConfig.json"))
        using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
            json = await sr.ReadToEndAsync().ConfigureAwait(false);
        var configJson = JsonConvert.DeserializeObject<EmailConfig>(json);
        return configJson;
    }
    public static async Task<GrpcConfig> GetGrpc(string name)
    {
        var json = string.Empty;
        using (var fs = File.OpenRead("MailSenderius/Configs/GrpcConfig.json"))
        using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
            json = await sr.ReadToEndAsync().ConfigureAwait(false);
        var configJson = JsonConvert.DeserializeObject<List<GrpcConfig>>(json);
        foreach (var VARIABLE in configJson)
        {
            if (name == VARIABLE.Name)
            {
                return VARIABLE;
            }
        }
        return null;
    }
    
} 