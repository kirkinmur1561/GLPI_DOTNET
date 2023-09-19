using CommonObj.Dashboard.Common;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Assets.LinkComputer
{
    public class NetworkName:Dashboard<NetworkName>
    {
        [JsonIgnore]
        public IEnumerable<IPAddress> IpAddress { get; set; }
    }
}