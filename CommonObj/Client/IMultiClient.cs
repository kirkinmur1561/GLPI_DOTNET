using CommonObj.Base;

namespace CommonObj.Client;

public interface IMultiClient:ICommonClient,IAsyncDisposable
{    
    IEnumerable<IClient> Clients { get; }

    Task<IClient> AddClient(
        string dataAuth, 
        EAuthorizationType authorizationType, 
        bool isFullInit, 
        string? GLPIAddressForClient = default,
        string? AppTokenForClient = default,
        TimeSpan? ClientTimeout = default,
        TimeSpan? internalTimeout = default, 
        CancellationToken? cancel = default);
    
    Task<IClient> KillSessionClient(IClient client);
}