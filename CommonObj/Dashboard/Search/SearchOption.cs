using Newtonsoft.Json;

namespace CommonObj.Dashboard.Search
{
    public class SearchOption
    {
        [JsonIgnore]
        public string Subject { get; set; }
        
        [JsonIgnore]
        public string Category { get; set; }

        [JsonIgnore]
        public int IdField { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("table")]
        public string Table { get; set; }
        
        [JsonProperty("field")]
        public string Field { get; set; }
        
        [JsonProperty("datatype")]
        public string Datatype { get; set; }
        
        [JsonProperty("uid")]
        public string UId { get; set; }
        
        [JsonProperty("nosearch")]
        public bool? NoSearch { get; set; }
        
        [JsonProperty("nodisplay")]
        public bool? NoDisplay { get; set; }
        
        [JsonProperty("available_searchtypes")]
        public IEnumerable<Criteria.ESearchType> AvailableSearchtypes { get; set; }
        

        /// <summary>
        /// Метод перевода Json в объект IEnumerable<SearchOption>
        /// </summary>
        /// <param name="data">ListSearchOptions from obj Dashboard</param>
        /// <returns>Return IEnumerable&lt;SearchOption&gt;</returns>
        public static IEnumerable<SearchOption> Parse(Dictionary<string, object> data)
        {
            List<SearchOption> sos = new List<SearchOption>();
            SearchOption so = null;
            foreach (var obj in data)
            {
                int id = 0;
                if (int.TryParse(obj.Key,out id))
                {
                    if (so == null) continue;
                    so.IdField = id;
                    SearchOption _so = JsonConvert.DeserializeObject<SearchOption>(obj.Value.ToString());
                        
                    so.Name = _so?.Name ?? string.Empty;
                    so.Table = _so?.Table ?? string.Empty;
                    so.Field = _so?.Field ?? string.Empty;
                    so.Datatype = _so?.Datatype ?? string.Empty;
                    so.UId = _so?.UId ?? string.Empty;
                    so.NoSearch = _so?.NoSearch;
                    so.NoDisplay = _so?.NoDisplay;
                    so.AvailableSearchtypes = _so?.AvailableSearchtypes ?? Enumerable.Empty<Criteria.ESearchType>();

                    sos.Add(so);

                    so = new SearchOption()
                    {
                        Subject = sos.Last().Subject,
                        Category = sos.Last().Category
                    };
                }
                else
                {
                    string _subject = string.Empty;
                    try
                    {
                        _subject = JsonConvert
                            .DeserializeObject<Dictionary<string, string>>(obj.Value.ToString() ?? string.Empty)
                            ?.FirstOrDefault().Value ?? string.Empty;
                    }
                    catch
                    {
                        _subject = string.Empty;
                        // ignored
                    }


                    so = new SearchOption
                    {
                        Subject = _subject,
                        Category = obj.Key
                    };
                }
            }

            return sos;
        }        
    }
}
