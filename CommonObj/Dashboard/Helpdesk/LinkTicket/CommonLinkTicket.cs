using CommonObj.Dashboard.Common;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Helpdesk.LinkTicket
{
    public abstract class CommonLinkTicket
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("tickets_id")]
        public long IdTicket { get; set; }
        [JsonProperty("users_id")]
        public long IdUser { get; set; }
        [JsonProperty("links")]
        public List<Link> Links { get; set; }
    }
}