using Newtonsoft.Json;

namespace CommonObj.Dashboard.Helpdesk.LinkTicket
{
    public class TicketUser:CommonLinkTicket
    {        
        [JsonProperty("type")]
        public EType IdType { get; set; }
        [JsonProperty("use_notification")]
        public long IdUseNotification{ get; set; }
        [JsonProperty("alternative_email")]
        public string Email { get; set; }
        
        public enum EType
        {
            Requester = 1,
            Executor = 2
        }

    }
}
