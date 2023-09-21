using CommonObj.Base;

namespace CommonObj.Client;

public interface IClient:ICommonClient, IEquatable<IClient>,IAsyncDisposable
{
    IInitialization? Initialization { get; }

    /// <summary>
    /// Required method. Upon successful initialization, the session will be enabled
    /// </summary>
    /// <param name="dataAuth">user token or login and pass user in base 64</param>
    /// <param name="authorizationType">if used user token set EAuthorizationType.UserToken, else used log and pass to use EAuthorizationType.LoginPassInBase64</param>
    /// <param name="isFullInit">full init of use for working applications</param> 
    /// <param name="internalTimeout">will only be used for this method</param>
    /// <param name="cancel">for cancel task</param>
    /// <returns>Initialization data in session. Null - error</returns>
    /// <exception cref="InvalidOperationException">from HttpResponseMessage</exception>
    /// <exception cref="HttpRequestException">from HttpResponseMessage</exception>
    /// <exception cref="TaskCanceledException">from HttpResponseMessage</exception>
    /// <exception cref="UriFormatException">from HttpResponseMessage</exception> 
    /// <exception cref="ExceptionGLPI_ErrorCommon">from GLPI response</exception>
    Task<IInitialization> InitSession(
        string dataAuth,
        EAuthorizationType authorizationType,
        bool isFullInit,
        TimeSpan? internalTimeout = default,
        CancellationToken? cancel = default);

    void SetHeaderDefault(string mediaType = BaseResource.MIMO_APPLICATION_JSON);
    string ExceptUri(Uri uri);    
}