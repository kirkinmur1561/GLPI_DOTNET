using CommonObj.Base;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Helpdesk.LinkTicket
{
    public class ITILSolution:CommonLinkTicket
    {       
        [JsonProperty(BaseJsonProperty.ITEMTYPE)]
        public string ItemType { get; set; }
        
        [JsonProperty(BaseJsonProperty.ITEMS_ID)]
        public long IdItems { get; set; }
        
        [JsonProperty(BaseJsonProperty.SOLUTIONTYPES_ID)]
        public long IdSolutionType { get; set; }
        
        [JsonProperty(BaseJsonProperty.SOLUTIONTYPE_NAME)]
        public string NameSolutionType { get; set; }
        
        [JsonProperty(BaseJsonProperty.CONTENT)]
        public string Content { get; set; }
        
        [JsonProperty(BaseJsonProperty.DATE_CREATION)]
        public DateTime? DateCreation { get; set; }
        
        [JsonProperty(BaseJsonProperty.DATE_MOD)]
        public DateTime? DateMod { get; set; }
        
        [JsonProperty(BaseJsonProperty.DATE_APPROVAL)]
        public DateTime? DateApproval { get; set; }    
        
        [JsonProperty(BaseJsonProperty.USER_NAME)]
        public string NameUser { get; set; }
        
        [JsonProperty(BaseJsonProperty.USERS_ID_EDITOR)]
        public long IdUserEditor { get; set; }
        
        [JsonProperty(BaseJsonProperty.USERS_ID_APPROVAL)]
        public long IdUserApproval { get; set; }
        
        [JsonProperty(BaseJsonProperty.USER_NAME_APPROVAL)]
        public string NameUserApproval { get; set; }
        
        [JsonProperty(BaseJsonProperty.STATUS)]
        public int? Status { get; set; }
        
        [JsonProperty("itilfollowups_id")]
        public long? IdItilFollowUp { get; set; }
        
        [JsonIgnore]
        public ITILFollowup ItilFollowup { get; set; }

        [JsonIgnore]
        public IList<ITILFollowup> ItilFollowups { get; private set; } = new List<ITILFollowup>();
    }
}
