using CommonObj.Base;
using CommonObj.Dashboard.Common;
using CommonObj.Dashboard.Common.LinkCommon;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Assets
{
    public abstract class WorkStation<TW> : Dashboard<TW> where TW : Dashboard<TW>
        {
        [JsonProperty(BaseJsonProperty.CONTACT)]
        public string Contact { get; set; }

        [JsonProperty(BaseJsonProperty.CONTACT_NUM)]
        public string ContactNum { get; set; }

        [JsonProperty(BaseJsonProperty.SERIAL)]
        public string Serial { get; set; }

        [JsonProperty(BaseJsonProperty.OTHERSERIAL)]
        public string OtherSerial { get; set; }

        [JsonProperty(BaseJsonProperty.STATES_ID)]
        public long? IdStates { get; set; }

        [JsonProperty(BaseJsonProperty.IS_DYNAMIC)]
        public bool? IsDynamic { get; set; }
        
        [JsonIgnore]
        public State State { get; set; }
        
        [JsonIgnore]
        public Network Network {get;set;}
    }
}
