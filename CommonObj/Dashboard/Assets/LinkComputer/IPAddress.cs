using CommonObj.Base;
using CommonObj.Dashboard.Common;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Assets.LinkComputer
{
    public class IPAddress:Dashboard<IPAddress>
    {
        public enum EipVersion
        {
            IpV4 = 4,
            IpV6 = 6
        }
        
        [JsonProperty(BaseJsonProperty.ITEMS_ID)]
        public long? IdItem {get; set;}
        
        [JsonProperty(BaseJsonProperty.ITEMTYPE)]
        public string TypeItem {get; set;}
        
        /// <summary>
        /// Версия IP
        /// </summary>
        [JsonProperty(BaseJsonProperty.VERSION)]
        public EipVersion Version {get; set;}
        
        [JsonProperty(BaseJsonProperty.NAME)]
        public string Address {get; set;}
        
        [JsonProperty(BaseJsonProperty.BINARY_0)]
        public long? Binary0 {get; set;}
        
        [JsonProperty(BaseJsonProperty.BINARY_1)]
        public long? Binary1 {get; set;}
        
        [JsonProperty(BaseJsonProperty.BINARY_2)]
        public long? Binary2 {get; set;}
        
        [JsonProperty(BaseJsonProperty.BINARY_3)]
        public long? Binary3 {get; set;}        
       
        [JsonProperty(BaseJsonProperty.MAINITEMS_ID)]
        public long? IdMainItem {get; set;}
        
        [JsonProperty(BaseJsonProperty.MAINITEMTYPE)]
        public string TypeMainItem {get; set;}       
    }
}