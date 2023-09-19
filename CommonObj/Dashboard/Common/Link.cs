using CommonObj.Base;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Common
{
    public class Link : IEquatable<Link>
    {
        [JsonProperty(BaseJsonProperty.REL)]
        public string Rel { get; set; }


        [JsonProperty(BaseJsonProperty.HREF)]
        public Uri Address { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Link);
        }

        public bool Equals(Link other)
        {
            return other != null &&
                   Rel == other.Rel &&
                   Address == other.Address;
        }

        public override int GetHashCode() => 
            HashCode.Combine(Rel, Address);

        public static bool operator ==(Link left, Link right) => 
            EqualityComparer<Link>.Default.Equals(left, right);

        public static bool operator !=(Link left, Link right) => !(left == right);
    }
}
