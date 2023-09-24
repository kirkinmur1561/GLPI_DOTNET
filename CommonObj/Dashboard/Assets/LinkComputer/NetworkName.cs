using CommonObj.Dashboard.Common;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Assets.LinkComputer
{
    public class NetworkName:Dashboard<NetworkName>
    {
        [JsonIgnore]
        public IList<IPAddress> IpAddress { get; private set; } = new List<IPAddress>();
    }
}