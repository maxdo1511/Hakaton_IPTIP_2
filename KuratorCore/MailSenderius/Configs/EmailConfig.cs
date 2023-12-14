using Newtonsoft.Json;

namespace EmailCore.Configs;

public class EmailConfig
{
    [JsonProperty("adress")]
    public string adress { get; private set; }
    [JsonProperty("stmp")]
    public string stmp { get; private set; }
    [JsonProperty("port")]
    public int port { get; private set; }
    [JsonProperty("password")]
    public string password { get; private set; }
}