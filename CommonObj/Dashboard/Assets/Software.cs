﻿using CommonObj.Dashboard.Common;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Assets
{
    public class Software : Dashboard<Software>, IEquatable<Software>
    {
        [JsonProperty("is_update")]
        public bool? IsUpdate { get; set; }

        [JsonProperty("softwares_id")]
        public long? IdSoftwares { get; set; }

        [JsonProperty("is_helpdesk_visible")]
        public bool? IsHelpdeskVisible { get; set; }

        [JsonProperty("softwarecategories_id")]
        public long? IdSoftwareCategories { get; set; }

        [JsonProperty("is_valid")]
        public bool? IsValid { get; set; }


        public override bool Equals(object obj)
        {
            return Equals(obj as Software);
        }

        public bool Equals(Software other)
        {
            return other != null &&
                   Id == other.Id &&
                   IdEntity == other.IdEntity &&
                   IsRecursive == other.IsRecursive &&
                   Name == other.Name &&
                   Comment == other.Comment &&
                   IdLocation == other.IdLocation &&
                   IdUsersTech == other.IdUsersTech &&
                   IdGroupsTech == other.IdGroupsTech &&
                   IdManufacturer == other.IdManufacturer &&
                   IsDeleted == other.IsDeleted &&
                   IsTemplate == other.IsTemplate &&
                   TemplateName == other.TemplateName &&
                   DateMod == other.DateMod &&
                   IdUser == other.IdUser &&
                   IdGroup == other.IdGroup &&
                   TicketTco == other.TicketTco &&
                   DateCreation == other.DateCreation &&
                   IsUpdate == other.IsUpdate &&
                   IdSoftwares == other.IdSoftwares &&
                   IsHelpdeskVisible == other.IsHelpdeskVisible &&
                   IdSoftwareCategories == other.IdSoftwareCategories &&
                   IsValid == other.IsValid;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(IdEntity);
            hash.Add(IsRecursive);
            hash.Add(Name);
            hash.Add(Comment);
            hash.Add(IdLocation);
            hash.Add(IdUsersTech);
            hash.Add(IdGroupsTech);
            hash.Add(IdManufacturer);
            hash.Add(IsDeleted);
            hash.Add(IsTemplate);
            hash.Add(TemplateName);
            hash.Add(DateMod);
            hash.Add(IdUser);
            hash.Add(IdGroup);
            hash.Add(TicketTco);
            hash.Add(DateCreation);
            hash.Add(IsUpdate);
            hash.Add(IdSoftwares);
            hash.Add(IsHelpdeskVisible);
            hash.Add(IdSoftwareCategories);
            hash.Add(IsValid);
            return hash.ToHashCode();
        }

        public static bool operator ==(Software left, Software right)
        {
            return EqualityComparer<Software>.Default.Equals(left, right);
        }

        public static bool operator !=(Software left, Software right)
        {
            return !(left == right);
        }
    }
}
