using System.Net;
using System.Text.Json;

namespace CommonObj.Base;


public class ExceptionGLPI_ErrorCommon:Exception
{
    public HttpStatusCode StatusCode { get; }
    public string TraceName { get;}
    public new string Message { get; private set; }

    public ExceptionGLPI_ErrorCommon(string value,HttpStatusCode statusCode)
    {
        StatusCode = statusCode;
        var data = JsonSerializer.Deserialize<string[]>(value) ?? Array.Empty<string>();
        if (data != Array.Empty<string>())
        {
            TraceName = data.FirstOrDefault();
            Message = data.LastOrDefault();
        }
    }
}


