using CommonObj.Base;
using CommonObj.Dashboard.Common;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Helpdesk.LinkTicket
{
    public abstract class CommonLinkTicket
    {
        [JsonProperty(BaseJsonProperty.ID)]
        public long Id { get; set; }
        
        [JsonProperty(BaseJsonProperty.TICKETS_ID)]
        public long IdTicket { get; set; }
        
        [JsonProperty(BaseJsonProperty.USERS_ID)]
        public long IdUser { get; set; }
        
        [JsonProperty(BaseJsonProperty.LINKS)]
        public List<Link> Links { get; set; }
    }
}