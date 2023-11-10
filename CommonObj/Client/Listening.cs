using System.Diagnostics.CodeAnalysis;

namespace CommonObj.Client;

public class Listening
{
    public readonly string Url;
    public readonly string Method;
    public readonly string? ListenerId;

    public readonly Type TypeObj;
    public readonly Func<string?, string?, Task> Response;
    public readonly Func<object?, string?, Task> ResponseObj;
    
    private Listening(string url, string method, string? listenerId = default)
    {
        Url = url;
        Method = method;
        ListenerId = listenerId;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="url">The last character must be /</param>
    /// <param name="method">post/put/...</param>
    /// <param name="response">Action for response string:data, string: listenerId, Task: for thread</param>
    /// <param name="listenerId"></param>
    public Listening(string url, string method, Func<string?, string?, Task> response, string? listenerId = default) :
        this(url, method, listenerId) =>
        Response = response;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="url">The last character must be /</param>
    /// <param name="method">post/put/...</param>
    /// <param name="responseObj">Action for response object:Deserializable from json to object, string: listenerId, Task: for thread</param>
    /// <param name="listenerId"></param>>
    public Listening(string url, string method, Func<object?, string?, Task> responseObj, Type typeObj, string? listenerId = default) :
        this(url, method, listenerId)
    {
        TypeObj = typeObj;
        ResponseObj = responseObj;
    }
        
}