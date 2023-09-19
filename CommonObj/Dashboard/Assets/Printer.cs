using CommonObj.Base;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Assets
{

    public class Printer : WorkStation<Printer>, IEquatable<Printer>
    {
        [JsonProperty(BaseJsonProperty.HAVE_SERIAL)]
        public bool? HaveSerial { get; set; }

        [JsonProperty(BaseJsonProperty.HAVE_PARALLEL)]
        public bool? HaveParallelPort { get; set; }

        [JsonProperty(BaseJsonProperty.HAVE_USB)]
        public bool? HaveUSB { get; set; }

        [JsonProperty(BaseJsonProperty.HAVE_WIFI)]
        public bool? HaveWiFi { get; set; }

        [JsonProperty(BaseJsonProperty.HAVE_ETHERNET)]
        public bool? HaveRJ45 { get; set; }

        [JsonProperty(BaseJsonProperty.MEMORY_SIZE)]
        public double? MemorySize { get; set; }

        [JsonProperty(BaseJsonProperty.NETWORKS_ID)]
        public long? IdNetworks { get; set; }

        [JsonProperty(BaseJsonProperty.PRINTERTYPES_ID)]
        public long? IdPrinterTypes { get; set; }

        [JsonProperty(BaseJsonProperty.PRINTERMODELS_ID)]
        public long? IdPrinterModels { get; set; }

        [JsonProperty(BaseJsonProperty.INIT_PAGES_COUNTER)]
        public long? InitPagesCounter { get; set; }

        [JsonProperty(BaseJsonProperty.LAST_PAGES_COUNTER)]
        public long? LastPagesCounter { get; set; }


        public override bool Equals(object obj)
        {
            return Equals(obj as Printer);
        }

        public bool Equals(Printer other)
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
                   HaveSerial == other.HaveSerial &&
                   HaveParallelPort == other.HaveParallelPort &&
                   HaveUSB == other.HaveUSB &&
                   HaveWiFi == other.HaveWiFi &&
                   HaveRJ45 == other.HaveRJ45 &&
                   MemorySize == other.MemorySize &&
                   IdNetworks == other.IdNetworks &&
                   IdPrinterTypes == other.IdPrinterTypes &&
                   IdPrinterModels == other.IdPrinterModels &&
                   InitPagesCounter == other.InitPagesCounter &&
                   LastPagesCounter == other.LastPagesCounter;
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
            hash.Add(HaveSerial);
            hash.Add(HaveParallelPort);
            hash.Add(HaveUSB);
            hash.Add(HaveWiFi);
            hash.Add(HaveRJ45);
            hash.Add(MemorySize);
            hash.Add(IdNetworks);
            hash.Add(IdPrinterTypes);
            hash.Add(IdPrinterModels);
            hash.Add(InitPagesCounter);
            hash.Add(LastPagesCounter);
            return hash.ToHashCode();
        }

        public static bool operator ==(Printer left, Printer right)
        {
            return EqualityComparer<Printer>.Default.Equals(left, right);
        }

        public static bool operator !=(Printer left, Printer right)
        {
            return !(left == right);
        }
    }
}
