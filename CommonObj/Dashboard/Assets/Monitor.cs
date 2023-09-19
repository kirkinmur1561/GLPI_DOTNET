using CommonObj.Base;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Assets
{
    public class Monitor : WorkStation<Monitor>, IEquatable<Monitor>
    {
        [JsonProperty(BaseJsonProperty.SIZE)]
        public double? Size { get; set; }

        [JsonProperty(BaseJsonProperty.HAVE_MICRO)]
        public bool? HaveMicro { get; set; }

        [JsonProperty(BaseJsonProperty.HAVE_SPEAKER)]
        public bool? HaveSpeaker { get; set; }

        [JsonProperty(BaseJsonProperty.HAVE_SUBD)]
        public bool? HaveSubD { get; set; }

        [JsonProperty(BaseJsonProperty.HAVE_BNC)]
        public bool? HaveBNC { get; set; }

        [JsonProperty(BaseJsonProperty.HAVE_DVI)]
        public bool? HaveDVI { get; set; }

        [JsonProperty(BaseJsonProperty.HAVE_PIVOT)]
        public bool? HavePivot { get; set; }

        [JsonProperty(BaseJsonProperty.HAVE_HDMI)]
        public bool? HaveHDMI { get; set; }

        [JsonProperty(BaseJsonProperty.HAVE_DISPLAYPORT)]
        public bool? HaveDisplayPort { get; set; }

        [JsonProperty(BaseJsonProperty.MONITORTYPES_ID)]
        public long? IdMonitorTypes { get; set; }

        [JsonProperty(BaseJsonProperty.MONITORMODELS_ID)]
        public long? IdMonitorModels { get; set; }

        [JsonProperty(BaseJsonProperty.IS_GLOBAL)]
        public bool? IsGlobal { get; set; }


        public override bool Equals(object obj)
        {
            return Equals(obj as Monitor);
        }

        public bool Equals(Monitor other)
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
                   Contact == other.Contact &&
                   ContactNum == other.ContactNum &&
                   Serial == other.Serial &&
                   OtherSerial == other.OtherSerial &&
                   IdStates == other.IdStates &&
                   IsDynamic == other.IsDynamic &&
                   Size == other.Size &&
                   HaveMicro == other.HaveMicro &&
                   HaveSpeaker == other.HaveSpeaker &&
                   HaveSubD == other.HaveSubD &&
                   HaveBNC == other.HaveBNC &&
                   HaveDVI == other.HaveDVI &&
                   HavePivot == other.HavePivot &&
                   HaveHDMI == other.HaveHDMI &&
                   HaveDisplayPort == other.HaveDisplayPort &&
                   IdMonitorTypes == other.IdMonitorTypes &&
                   IdMonitorModels == other.IdMonitorModels &&
                   IsGlobal == other.IsGlobal;
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

            hash.Add(Contact);
            hash.Add(ContactNum);
            hash.Add(Serial);
            hash.Add(OtherSerial);
            hash.Add(IdStates);
            hash.Add(IsDynamic);
            hash.Add(Size);
            hash.Add(HaveMicro);
            hash.Add(HaveSpeaker);
            hash.Add(HaveSubD);
            hash.Add(HaveBNC);
            hash.Add(HaveDVI);
            hash.Add(HavePivot);
            hash.Add(HaveHDMI);
            hash.Add(HaveDisplayPort);
            hash.Add(IdMonitorTypes);
            hash.Add(IdMonitorModels);
            hash.Add(IsGlobal);
            return hash.ToHashCode();
        }

        public static bool operator ==(Monitor left, Monitor right)
        {
            return EqualityComparer<Monitor>.Default.Equals(left, right);
        }

        public static bool operator !=(Monitor left, Monitor right)
        {
            return !(left == right);
        }
    }
}
