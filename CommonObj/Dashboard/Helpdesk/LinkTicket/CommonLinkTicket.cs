using CommonObj.Base;
using CommonObj.Dashboard.Administration.User;
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
        
        [JsonIgnore]
        public User User { get; set; }
        [JsonIgnore]
        public IList<User> Users { get; private set;} = new List<User>();
        
        [JsonIgnore]
        public Ticket Ticket { get; set; }
        [JsonIgnore]
        public IList<Ticket> Tickets { get; private set;} = new List<Ticket>();
        
        [JsonProperty(BaseJsonProperty.LINKS)]
        public List<Link> Links { get; set; }
    }
}