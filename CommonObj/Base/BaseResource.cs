using System.Net.Mime;

namespace CommonObj.Base;

public class BaseResource
{
    public const char SEPARATOR_URI = '/';
    public const char SEPARATOR_ARGUMENT = '?';
    public const char SEPARATOR_AND = '&';
    public const char COLLECT_IDENTIFIER = 's';
    public const string MIMO_APPLICATION_JSON = MediaTypeNames.Application.Json;
    public const string MIMO_APPLICATION_OCTET_STREAM = MediaTypeNames.Application.Octet;
    public const string MIMO_MULTIPART_FORM_DATA = "multipart/form-data";
    public const string HEADER_APP_TOKEN = "app_token";
    public const string HEADER_USER_TOKEN = "user_token";
    public const string HEADER_SESSION_TOKEN = "Session-Token";
    public const string HEADER_BASIC = "Basic";
    public const string ROUTE_INIT_SESSION = "initSession";    
    public const string ROUTE_KILL_SESSION = "killSession";
    public const string GET_ACTIVE_PROFILE = "getActiveProfile";
    public const string GET_MY_PROFILES = "getMyProfiles";
    public const string LIST_SEARCH_OPTIONS = "listSearchOptions";    
    public const string Search = "search";
    public static readonly string SearchRequest = $"search{SEPARATOR_URI}";
    public static readonly string ROUTE_INIT_SESSION_GET_FULL_SESSION =
        ROUTE_INIT_SESSION + SEPARATOR_ARGUMENT + "get_full_session=true";
}