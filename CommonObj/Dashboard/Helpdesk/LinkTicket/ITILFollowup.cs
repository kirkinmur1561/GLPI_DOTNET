using CommonObj.Base;
using CommonObj.Dashboard.Common;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Helpdesk.LinkTicket
{
    public class ITILFollowup
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        
        [JsonProperty(BaseJsonProperty.ITEMTYPE)]
        public string ItemType { get; set; }
        
        [JsonProperty(BaseJsonProperty.ITEMS_ID)]
        public long IdItems { get; set; }
        
        [JsonProperty(BaseJsonProperty.DATE)]
        public DateTime? Date { get; set; }
        
        [JsonProperty(BaseJsonProperty.USERS_ID)]
        public long IdUser { get; set; }
        
        [JsonProperty(BaseJsonProperty.USERS_ID_EDITOR)]
        public long IdUserEditor { get; set; }
        
        [JsonProperty(BaseJsonProperty.CONTENT)]
        public string Content { get; set; }
        
        [JsonProperty(BaseJsonProperty.IS_PRIVATE)]
        public bool IsPrivate { get; set; }
        
        [JsonProperty(BaseJsonProperty.REQUESTTYPES_ID)]
        public long IdRequestType { get; set; }
        
        [JsonProperty(BaseJsonProperty.DATE_MOD)]
        public DateTime? DateMod { get; set; }
        
        [JsonProperty(BaseJsonProperty.DATE_CREATION)]
        public DateTime? DateCreation { get; set; }
        
        [JsonProperty(BaseJsonProperty.TIMELINE_POSITION)]
        public int TimeLinePosition { get; set; }
        
        [JsonProperty(BaseJsonProperty.SOURCEITEMS_ID)]
        public long IdSourceItem { get; set; }
        
        [JsonProperty(BaseJsonProperty.SOURCEOF_ITEMS_ID)]
        public long IdSourceOfItem { get; set; }
        
        [JsonProperty(BaseJsonProperty.LINKS)]
        public List<Link> Links { get; set; }
    }
}
