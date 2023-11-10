using System.Net;
using System.Net.Http.Headers;
using System.Text;
using CommonObj.Base;
using CommonObj.Client;
using Newtonsoft.Json;

namespace Single;

/// <summary>
/// Single client for GLPI API
/// </summary>
public class Client:IClient
{
    public string GLPIAddress { get; }
    public string AppToken { get; }
    public TimeSpan CommonTimeout { get; set; }
    public HttpClient http { get; private set; }
    private IInitialization? _Init;
    private string[] BaseUri { get; }
    public IInitialization? Initialization => _Init;
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="glpiAddress">absolute address to you system glpi</param>
    /// <param name="appToken">generated key in the application</param>
    /// <param name="commonTimeout">Total time waiting for a response from the server</param>
    /// <exception cref="ArgumentException">Check arg</exception>
    public Client(string glpiAddress, string appToken,TimeSpan commonTimeout = default)
    {
        if (string.IsNullOrEmpty(glpiAddress) || string.IsNullOrEmpty(appToken))
            throw new ArgumentException("Error in arg or args");            
        
        GLPIAddress = glpiAddress;
        BaseUri = glpiAddress.Split(BaseResource.SEPARATOR_URI);        
        AppToken = appToken;
        CommonTimeout = commonTimeout == default ? TimeSpan.FromSeconds(100) : commonTimeout;
    }
    
    public bool Equals(Client? other)
    {
        throw new NotImplementedException();
    }
    
    public bool Equals(IClient? other)
    {
        throw new NotImplementedException();
    }

    public async ValueTask DisposeAsync()
    {
        using CancellationTokenSource cts =
            new CancellationTokenSource(CommonTimeout == default ? TimeSpan.FromMinutes(2) : CommonTimeout);
        await KillSession(cts.Token);        
        _Init = null;
        if (http is IAsyncDisposable httpClientAsyncDisposable)
            await httpClientAsyncDisposable.DisposeAsync();
        else
            http.Dispose();
        GC.Collect();
    }


    

    public async Task<IInitialization> InitSession(
        string dataAuth,
        EAuthorizationType authorizationType,
        bool isFullInit,
        TimeSpan? internalTimeout = default,
        CancellationToken? cancel = default)
    {        
        http = new HttpClient();
        http.BaseAddress = new Uri(GLPIAddress);
        http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(BaseResource.MIMO_APPLICATION_JSON));
        http.DefaultRequestHeaders.Add(BaseResource.HEADER_APP_TOKEN, AppToken);
        http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
            authorizationType == EAuthorizationType.UserToken
                ? BaseResource.HEADER_USER_TOKEN
                : BaseResource.HEADER_BASIC,
            dataAuth);


        HttpResponseMessage response = await http.GetAsync(
            isFullInit
                ? BaseResource.ROUTE_INIT_SESSION_GET_FULL_SESSION
                : BaseResource.ROUTE_INIT_SESSION, cancel ?? default);

        string responseValue = await response.Content.ReadAsStringAsync(cancel ?? default);
        if (!response.IsSuccessStatusCode) throw new ExceptionGLPI_ErrorCommon(responseValue, response.StatusCode);

        _Init = JsonConvert.DeserializeObject<Initialization>(responseValue);
        response.Dispose();
        return _Init;
    }

    public void SetHeaderDefault(string mediaType = BaseResource.MIMO_APPLICATION_JSON)
    {
        if (_Init == null || string.IsNullOrWhiteSpace(_Init.SessionToken))
            throw new Exception("_Init or _Init SessionToken equal null");
        http.DefaultRequestHeaders.Clear();
        http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(mediaType));
        http.DefaultRequestHeaders.Add(BaseResource.HEADER_SESSION_TOKEN, _Init.SessionToken);
        http.DefaultRequestHeaders.Add(BaseResource.HEADER_APP_TOKEN, AppToken);
    }

    public string ExceptUri(Uri uri) =>
        string.Join(BaseResource.SEPARATOR_URI, uri.ToString().Split(BaseResource.SEPARATOR_URI).Except(BaseUri));

    private HttpListener _listener;
    private IEnumerable<Listening> _listenings;

    /// <summary>
    /// For WebHook plugin https://github.com/ericferon/glpi-webhook
    /// </summary>
    /// <param name="listenings"></param>
    /// <param name="cancel"></param>
    /// <returns></returns>
    public async Task InitListener(IEnumerable<Listening> listenings,CancellationToken cancel = default)
    {
        _listenings = listenings;
        _listener = new HttpListener();
        foreach (Listening url in listenings) _listener.Prefixes.Add(url.Url);
        _listener.Start();
        while (true)
        {
            HttpListenerContext context = await _listener.GetContextAsync();
            Push(context, cancel);
        }
    }

    private async Task Push(HttpListenerContext context,CancellationToken cancel)
    {
        Listening? listening = _listenings.FirstOrDefault(f =>
            f.Url.Equals(context.Request.Url?.OriginalString) && f.Method.Equals(context.Request.HttpMethod));

        if (listening == null) return;
        
        using StreamReader sr = new StreamReader(context.Request.InputStream);
        string values = await sr.ReadToEndAsync(cancel);

        Task.Run(() =>
            Nullable.Equals(listening.TypeObj, null)
                ? listening.Response.Invoke(values, listening.ListenerId)
                : listening.ResponseObj(JsonConvert.DeserializeObject(values, listening.TypeObj),
                    listening.ListenerId), cancel);
        
        
        Encoding? encoding = context.Response.ContentEncoding;
        if (encoding == null)
        {
            encoding = Encoding.UTF8;
            context.Response.ContentEncoding = encoding;
        }
        
        byte[] buffer = encoding.GetBytes(string.Empty);
        context.Response.StatusCode = (int) HttpStatusCode.OK;
        context.Response.StatusDescription = "OK";
        context.Response.ProtocolVersion = new Version ("1.1");
        context.Response.KeepAlive = false;
        await using Stream sw = context.Response.OutputStream;
        await sw.WriteAsync(buffer, cancel);
    }

    public Task DisposableListener()
    {
        _listener?.Stop();
        _listener?.Close();
        return Task.CompletedTask;
    }


    private Task KillSession(CancellationToken cancel = default) =>
        http.GetAsync(BaseResource.ROUTE_KILL_SESSION, cancel);
    
    public static string ConvertToBase64(string log, string pass) =>
        Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Join(':', log, pass)));
}