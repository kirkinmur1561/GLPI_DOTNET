using CommonObj.Base;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Helpdesk.LinkTicket
{
    public class TicketValidation:CommonLinkTicket
    {       
        [JsonProperty(BaseJsonProperty.ENTITIES_ID)]
        public long IdEntity { get; set; }
        
        [JsonProperty(BaseJsonProperty.USERS_ID_VALIDATE)]
        public long IdUserValidate{ get; set; }
        
        [JsonProperty(BaseJsonProperty.COMMENT_SUBMISSION)]
        public string CommentSubmission { get; set; }
        
        [JsonProperty(BaseJsonProperty.COMMENT_VALIDATION)]
        public string CommentValidation { get; set; }
        
        [JsonProperty(BaseJsonProperty.STATUS)]
        public int? Status { get; set; }
        
        [JsonProperty(BaseJsonProperty.SUBMISSION_DATE)]
        public DateTime? DateSubmission { get; set; } 
        
        [JsonProperty(BaseJsonProperty.VALIDATION_DATE)]
        public DateTime? DateValidation { get; set; }
        
        [JsonProperty(BaseJsonProperty.TIMELINE_POSITION)]
        public int? TimelinePosition { get; set; }    
        
    }
}
