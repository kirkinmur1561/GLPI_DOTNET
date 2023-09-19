namespace CommonObj.Client;

public interface ICommonClient
{
    string GLPIAddress { get; }
    string AppToken { get; }
    TimeSpan CommonTimeout { get; set; }
    HttpClient http { get; }
}