using CommonObj.Client;
using Newtonsoft.Json;

namespace Single;

public class Initialization:IInitialization
{
    /// <summary>
    /// Токен для запросов к GLPI. Обязательно для запроса после инициализации
    /// </summary>
    [JsonProperty("session_token")]
    public string SessionToken { get; set; }

    


    /// <summary>
    /// Способ инициализации.
    /// </summary>
    public bool IsFullInit
    {
        get => _isFullInIt;
        private set
        {
            if (value.Equals(_isFullInIt)) return;
            _isFullInIt = value;
        }
    }
    
    private bool _isFullInIt;
    
    /// <summary>
    /// Информация о сессии
    /// </summary>
    [JsonProperty("session")]
    public Session _Session
    {
        get => _session;
        set
        {
            _session = value; 
            IsFullInit = true;
        }
    }

    private Session _session;

    [JsonIgnore]
    public ISession Session => _session;
}