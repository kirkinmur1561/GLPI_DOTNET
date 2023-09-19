using CommonObj.Dashboard.Common;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Search
{
    enum ESearchId
    {
        Name = 1,
        Id = 2,
        id3 = 3,
        LocationId = 4,
        Id5 = 5,
        id6 = 6,
        TypeTicket = 7,
        id12 = 12,
        DataCreate = 19,
        DataMode = 15
    }
    public class ResponseSearch
    {
        [JsonProperty("totalcount")]
        public long TotalCount { get; set; }
        [JsonProperty("count")]
        public long Count { get; set; }
        [JsonProperty("sort")]
        public List<string> Sort { get; set; }
        [JsonProperty("order")]
        public List<string> Order { get; set; }

        [JsonProperty("content-range")]
        public string ContentRange { get; set; }
        [JsonProperty("data")]
        public List<Dictionary<int, object>> Data { get; set; }

        public ResponseSearch()
        {
            JsonConvert.DeserializeObject<IDashboard>("");
        }

        // public async Task<IEnumerable<T>> Get<T>(IGlpiClient clt) where T:Dashboard<T>
        // {
        //     List<T> list_t = new List<T>();
        //     IEnumerable<long> ids_t = Data
        //         .Where(w => w.FirstOrDefault().Key == 2)
        //         .Select(s => (long)s.Values.FirstOrDefault());
        //
        //     foreach (long id in ids_t)
        //     {
        //         list_t.Add(await Dashboard<T>.GetAsync(clt, new Parameter { id = id }));
        //     }
        //
        //     return list_t;
        //
        // }
    }
    
}
