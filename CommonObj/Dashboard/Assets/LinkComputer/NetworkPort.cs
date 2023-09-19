using CommonObj.Base;
using CommonObj.Dashboard.Common;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Assets.LinkComputer
{
    public class NetworkPort:Dashboard<NetworkPort>
    {        
        [JsonProperty(BaseJsonProperty.ITEMS_ID)]
        public long? IdItem {get; set;}
        
        [JsonProperty(BaseJsonProperty.ITEMTYPE)]
        public string TypeItem {get; set;}            
        
        /// <summary>
        /// Port number
        /// </summary>
        [JsonProperty(BaseJsonProperty.LOGICAL_NUMBER)]
        public long? LogicalNum {get; set;}        
        
        [JsonProperty(BaseJsonProperty.INSTANTIATION_TYPE)]
        public string TypeInstantiation {get; set;}
        
        [JsonProperty(BaseJsonProperty.MAC)]
        public string MAC_Address {get; set;}                
        
        [JsonProperty(BaseJsonProperty.IS_DYNAMIC)]
        public bool? IsDynamic {get; set;}         
        
        [JsonProperty(BaseJsonProperty.IFMTU)]
        public long? ifMtu {get; set;}
        
        [JsonProperty(BaseJsonProperty.IFSPEED)]
        public long? ifSpeed {get; set;}
        
        [JsonProperty(BaseJsonProperty.IFINTERNALSTATUS)]
        public long? ifInternalStatus {get; set;}
        
        [JsonProperty(BaseJsonProperty.IFCONNECTIONSTATUS)]
        public long? ifConnectionStatus {get; set;}
        
        [JsonProperty(BaseJsonProperty.IFLASTCHANGE)]
        public long? ifLastChange {get; set;}
        
        [JsonProperty(BaseJsonProperty.IFINBYTES)]
        public long? ifInBytes {get; set;}
        
        [JsonProperty(BaseJsonProperty.IFINERRORS)]
        public long? ifInErrors {get; set;}
        
        [JsonProperty(BaseJsonProperty.IFOUTBYTES)]
        public long? ifOutBytes {get; set;}
        
        [JsonProperty(BaseJsonProperty.IFOUTERRORS)]
        public long? ifOutErrors {get; set;}
        
        [JsonProperty(BaseJsonProperty.IFSTATUS)]
        public long? ifStatus {get; set;}
        
        [JsonProperty(BaseJsonProperty.IFDESCR)]
        public long? ifDescr {get; set;}
        
        [JsonProperty(BaseJsonProperty.IFALIAS)]
        public long? ifAlias {get; set;}
        
        [JsonProperty(BaseJsonProperty.PORTDUPLEX)]
        public object PortDuplex {get; set;}
        
        [JsonProperty(BaseJsonProperty.TRUNK)]
        public long? Trunk {get; set;}
        
        [JsonProperty(BaseJsonProperty.LASTUP)]
        public object LastUp {get; set;}        
        
        [JsonIgnore]
        public Computer Computer { get; set; }       

        [JsonIgnore]
        public List<NetworkName> ListNetworkNames { get; set; } = new();
    }
}