﻿using CommonObj.Dashboard.Common;
using CommonObj.Dashboard.Common.LinkCommon;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Assets
{
    public abstract class WorkStation<TW> : Dashboard<TW> where TW : Dashboard<TW>
        {
        [JsonProperty("contact")]
        public string Contact { get; set; }

        [JsonProperty("contact_num")]
        public string ContactNum { get; set; }

        [JsonProperty("serial")]
        public string Serial { get; set; }

        [JsonProperty("otherserial")]
        public string OtherSerial { get; set; }

        [JsonProperty("states_id")]
        public long? IdStates { get; set; }

        [JsonProperty("is_dynamic")]
        public bool? IsDynamic { get; set; }
        
        [JsonIgnore]
        public State State { get; set; }
        
        [JsonIgnore]
        public Network Network {get;set;}
    }
}
