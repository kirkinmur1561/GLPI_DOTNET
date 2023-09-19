using CommonObj.Base;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Helpdesk.LinkTicket
{
    public class TicketUser:CommonLinkTicket
    {        
        [JsonProperty(BaseJsonProperty.TYPE)]
        public EType IdType { get; set; }
        
        [JsonProperty(BaseJsonProperty.USE_NOTIFICATION)]
        public long IdUseNotification{ get; set; }
        
        [JsonProperty(BaseJsonProperty.ALTERNATIVE_EMAIL)]
        public string Email { get; set; }
        
        
        public enum EType
        {
            Requester = 1,
            Executor = 2
        }

    }
}
