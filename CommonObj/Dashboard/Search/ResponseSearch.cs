using Newtonsoft.Json;

namespace CommonObj.Dashboard.Search
{
    public class ResponseSearch
    {
        [JsonProperty("totalcount")] public long TotalCount { get; set; }
        [JsonProperty("count")] public long Count { get; set; }
        [JsonProperty("sort")] public List<string> Sort { get; set; }
        [JsonProperty("order")] public List<string> Order { get; set; }

        [JsonProperty("content-range")] public string ContentRange { get; set; }
        [JsonProperty("data")] public IEnumerable<IDictionary<int, object>> Data { get; set; }
        
        
    }
}