using CommonObj.Base;
using CommonObj.Dashboard.Assets.LinkComputer;
using CommonObj.Dashboard.Helpdesk.LinkTicket;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Assets
{

    public class Computer : WorkStation<Computer>, IEquatable<Computer>
    {
        [JsonProperty(BaseJsonProperty.AUTOUPDATESYSTEMS_ID)]
        public long? IdAutoUpdateSystems { get; set; }

        [JsonProperty(BaseJsonProperty.NETWORKS_ID)]
        public long? IdNetworks { get; set; }

        [JsonProperty(BaseJsonProperty.COMPUTERMODELS_ID)]
        public long? IdComputerModels { get; set; }

        [JsonProperty(BaseJsonProperty.COMPUTERTYPES_ID)]
        public long? IdComputerTypes { get; set; }

        [JsonProperty(BaseJsonProperty.UUID)]
        public string UUId { get; set; }       

        [JsonIgnore]
        public IList<ItemTicket> Item_Ticket { get; private set;} = new List<ItemTicket>();
        
        [JsonIgnore]
        public IList<Item_Project> Item_Project { get; private set;} = new List<Item_Project>();
        
        [JsonIgnore]
        public IList<NetworkPort> NetworkPort { get; private set;} = new List<NetworkPort>();
        
        [JsonIgnore]
        public IList<Item_DeviceMotherboard> Item_DeviceMotherboard { get; private set;} = new List<Item_DeviceMotherboard>();
        
        [JsonIgnore]
        public IList<Item_DeviceFirmware> Item_DeviceFirmware { get; private set;} = new List<Item_DeviceFirmware>();
        
        [JsonIgnore]
        public IList<Item_DeviceProcessor> Item_DeviceProcessor { get; private set;} = new List<Item_DeviceProcessor>();
        
        [JsonIgnore]
        public IList<Item_DeviceMemory> Item_DeviceMemory { get; private set;} = new List<Item_DeviceMemory>();
        
        [JsonIgnore]
        public IList<Item_DeviceHardDrive> Item_DeviceHardDrive { get; private set;} = new List<Item_DeviceHardDrive>();
        
        [JsonIgnore]
        public IList<Item_DeviceNetworkCard> Item_DeviceNetworkCard { get; private set;} = new List<Item_DeviceNetworkCard>();
        
        [JsonIgnore]
        public IList<Item_DeviceDrive> Item_DeviceDrive { get; private set;} = new List<Item_DeviceDrive>();
        
        [JsonIgnore]
        public IList<Item_DeviceBattery> Item_DeviceBattery { get; private set;} = new List<Item_DeviceBattery>();
        
        [JsonIgnore]
        public IList<Item_DeviceGraphicCard> Item_DeviceGraphicCard { get; private set;} = new List<Item_DeviceGraphicCard>();
        
        [JsonIgnore]
        public IList<Item_DeviceSoundCard> Item_DeviceSoundCard { get; private set;} = new List<Item_DeviceSoundCard>();
        
        [JsonIgnore]
        public IList<Item_DeviceControl> Item_DeviceControl { get; private set;} = new List<Item_DeviceControl>();
        
        [JsonIgnore]
        public IList<Item_DevicePci> Item_DevicePci { get; private set;} = new List<Item_DevicePci>();
        
        [JsonIgnore]
        public IList<Item_DeviceCase> Item_DeviceCase { get; private set;} = new List<Item_DeviceCase>();
        
        [JsonIgnore]
        public IList<Item_DevicePowerSupply> Item_DevicePowerSupply { get; private set;} = new List<Item_DevicePowerSupply>();
        
        [JsonIgnore]
        public IList<Item_DeviceGeneric> Item_DeviceGeneric { get; private set;} = new List<Item_DeviceGeneric>();
        
        [JsonIgnore]
        public IList<Item_DeviceSimcard> Item_DeviceSimcard { get; private set;} = new List<Item_DeviceSimcard>();
        
        [JsonIgnore]
        public IList<Item_DeviceSensor> Item_DeviceSensor { get; private set;} = new List<Item_DeviceSensor>();
        
        [JsonIgnore]
        public IList<Item_DeviceCamera> Item_DeviceCamera { get; private set;} = new List<Item_DeviceCamera>();

        [JsonIgnore] 
        public IList<Contract_Item> Contract_Item {  get; private  set; } = new List<Contract_Item>();        
        
        [JsonIgnore]
        public AutoUpdateSystem AutoUpdateSystem { get; set;}
        [JsonIgnore]
        public IList<ItemTicket> AutoUpdateSystems { get; private set;} = new List<ItemTicket>();
        
        [JsonIgnore]
        public ComputerModel ComputerModel { get; set;}
        [JsonIgnore]
        public IList<Item_Project> ComputerModels { get; private set;} = new List<Item_Project>();
        
        [JsonIgnore]
        public ComputerType ComputerType { get; set;}
        [JsonIgnore]
        public IList<NetworkPort> ComputerTypes { get; private set;} = new List<NetworkPort>();
                 
        
        [JsonIgnore]
        public ReservationItem ReservationItem { get; set;}
        [JsonIgnore]
        public IList<Item_DeviceMotherboard> ReservationItems { get; private set;} = new List<Item_DeviceMotherboard>();
        
        [JsonIgnore]
        public Infocom Infocom { get; set;}
        [JsonIgnore]
        public IList<Item_DeviceFirmware> Infocoms { get; private set;} = new List<Item_DeviceFirmware>();
                   

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Computer) obj);
        }

        public static bool operator ==(Computer left, Computer right) =>
            EqualityComparer<Computer>.Default.Equals(left, right);

        public static bool operator !=(Computer left, Computer right) =>
            !(left == right);

        public bool Equals(Computer other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return IdAutoUpdateSystems == other.IdAutoUpdateSystems && IdNetworks == other.IdNetworks &&
                   IdComputerModels == other.IdComputerModels && IdComputerTypes == other.IdComputerTypes &&
                   UUId == other.UUId && Equals(Entity, other.Entity) && Equals(Item_Ticket, other.Item_Ticket) &&
                   Equals(Item_Project, other.Item_Project) && Equals(NetworkPort, other.NetworkPort) &&
                   Equals(Item_DeviceMotherboard, other.Item_DeviceMotherboard) &&
                   Equals(Item_DeviceFirmware, other.Item_DeviceFirmware) &&
                   Equals(Item_DeviceProcessor, other.Item_DeviceProcessor) &&
                   Equals(Item_DeviceMemory, other.Item_DeviceMemory) &&
                   Equals(Item_DeviceHardDrive, other.Item_DeviceHardDrive) &&
                   Equals(Item_DeviceNetworkCard, other.Item_DeviceNetworkCard) &&
                   Equals(Item_DeviceDrive, other.Item_DeviceDrive) &&
                   Equals(Item_DeviceBattery, other.Item_DeviceBattery) &&
                   Equals(Item_DeviceGraphicCard, other.Item_DeviceGraphicCard) &&
                   Equals(Item_DeviceSoundCard, other.Item_DeviceSoundCard) &&
                   Equals(Item_DeviceControl, other.Item_DeviceControl) &&
                   Equals(Item_DevicePci, other.Item_DevicePci) && Equals(Item_DeviceCase, other.Item_DeviceCase) &&
                   Equals(Item_DevicePowerSupply, other.Item_DevicePowerSupply) &&
                   Equals(Item_DeviceGeneric, other.Item_DeviceGeneric) &&
                   Equals(Item_DeviceSimcard, other.Item_DeviceSimcard) &&
                   Equals(Item_DeviceSensor, other.Item_DeviceSensor) &&
                   Equals(Item_DeviceCamera, other.Item_DeviceCamera) && Equals(Contract_Item, other.Contract_Item) &&
                   Equals(AutoUpdateSystem, other.AutoUpdateSystem) && Equals(ComputerModel, other.ComputerModel) &&
                   Equals(ComputerType, other.ComputerType) && Equals(Manufacturer, other.Manufacturer) &&
                   Equals(User, other.User) && Equals(ReservationItem, other.ReservationItem) &&
                   Equals(Infocom, other.Infocom) && Equals(Group, other.Group) && Equals(Location, other.Location);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = IdAutoUpdateSystems.GetHashCode();
                hashCode = (hashCode * 397) ^ IdNetworks.GetHashCode();
                hashCode = (hashCode * 397) ^ IdComputerModels.GetHashCode();
                hashCode = (hashCode * 397) ^ IdComputerTypes.GetHashCode();
                hashCode = (hashCode * 397) ^ (UUId != null ? UUId.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Entity != null ? Entity.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Item_Ticket != null ? Item_Ticket.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Item_Project != null ? Item_Project.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (NetworkPort != null ? NetworkPort.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Item_DeviceMotherboard != null ? Item_DeviceMotherboard.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Item_DeviceFirmware != null ? Item_DeviceFirmware.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Item_DeviceProcessor != null ? Item_DeviceProcessor.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Item_DeviceMemory != null ? Item_DeviceMemory.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Item_DeviceHardDrive != null ? Item_DeviceHardDrive.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Item_DeviceNetworkCard != null ? Item_DeviceNetworkCard.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Item_DeviceDrive != null ? Item_DeviceDrive.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Item_DeviceBattery != null ? Item_DeviceBattery.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Item_DeviceGraphicCard != null ? Item_DeviceGraphicCard.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Item_DeviceSoundCard != null ? Item_DeviceSoundCard.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Item_DeviceControl != null ? Item_DeviceControl.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Item_DevicePci != null ? Item_DevicePci.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Item_DeviceCase != null ? Item_DeviceCase.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Item_DevicePowerSupply != null ? Item_DevicePowerSupply.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Item_DeviceGeneric != null ? Item_DeviceGeneric.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Item_DeviceSimcard != null ? Item_DeviceSimcard.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Item_DeviceSensor != null ? Item_DeviceSensor.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Item_DeviceCamera != null ? Item_DeviceCamera.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Contract_Item != null ? Contract_Item.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (AutoUpdateSystem != null ? AutoUpdateSystem.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (ComputerModel != null ? ComputerModel.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (ComputerType != null ? ComputerType.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Manufacturer != null ? Manufacturer.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (User != null ? User.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (ReservationItem != null ? ReservationItem.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Infocom != null ? Infocom.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Group != null ? Group.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Location != null ? Location.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}
