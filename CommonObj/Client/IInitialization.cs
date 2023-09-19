using Newtonsoft.Json;

namespace CommonObj.Client;

public interface IInitialization
{
    /// <summary>
    /// Token session. Required for inquiries
    /// </summary>
    [JsonProperty("session_token")]
    string SessionToken { get; }
    
    /// <summary>
    /// type of session
    /// </summary>
    bool IsFullInit { get; }
    
    /// <summary>
    /// info of session
    /// </summary>
    [JsonProperty("session")]
    ISession Session { get; }
}