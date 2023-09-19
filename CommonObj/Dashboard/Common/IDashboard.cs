using CommonObj.Base;
using CommonObj.Dashboard.Administration;
using CommonObj.Dashboard.Administration.User;
using CommonObj.Dashboard.Assets.LinkComputer;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Common
{
    public interface IDashboard:IEquatable<IDashboard>
    {        
        [JsonProperty(BaseJsonProperty.ID)]
        long? Id { get; set; }

        [JsonProperty(BaseJsonProperty.ENTITIES_ID)]
        long? IdEntity { get; set; }

        [JsonProperty(BaseJsonProperty.IS_RECURSIVE)]
        bool? IsRecursive { get; set; }

        [JsonProperty(BaseJsonProperty.NAME)]
        string Name { get; set; }

        [JsonProperty(BaseJsonProperty.COMMENT)]
        string Comment { get; set; }

        [JsonProperty(BaseJsonProperty.LOCATIONS_ID)]
        long? IdLocation { get; set; }

        [JsonProperty(BaseJsonProperty.USERS_ID_TECH)]
        long? IdUsersTech { get; set; }

        [JsonProperty(BaseJsonProperty.GROUPS_ID_TECH)]
        long? IdGroupsTech { get; set; }

        [JsonProperty(BaseJsonProperty.MANUFACTURERS_ID)]
        long? IdManufacturer { get; set; }

        [JsonProperty(BaseJsonProperty.IS_DELETED)]
        bool? IsDeleted { get; set; }

        [JsonProperty(BaseJsonProperty.IS_TEMPLATE)]
        bool? IsTemplate { get; set; }

        [JsonProperty(BaseJsonProperty.TEMPLATE_NAME)]
        string TemplateName { get; set; }

        [JsonProperty(BaseJsonProperty.DATE_MOD)]
        DateTime? DateMod { get; set; }

        [JsonProperty(BaseJsonProperty.USERS_ID)]
        long? IdUser { get; set; }

        [JsonProperty(BaseJsonProperty.GROUPS_ID)]
        long? IdGroup { get; set; }

        [JsonProperty(BaseJsonProperty.TICKET_TCO)]
        double? TicketTco { get; set; }

        [JsonProperty(BaseJsonProperty.DATE_CREATION)]
        DateTime? DateCreation { get; set; }

        [JsonProperty(BaseJsonProperty.LINKS)]
        List<Link> Links { get; set; }
        
        [JsonIgnore]
        User User { get; set; }
        
        [JsonIgnore]
        Group Group { get; set; }
        
        [JsonIgnore]
        Manufacturer Manufacturer { get; set; }
        
        [JsonIgnore]
        Location Location { get; set; }
        
        [JsonIgnore]
        Entity Entity { get; set; }        
        
        /// <summary>
        /// 
        /// </summary>
        [JsonIgnore]
        IEnumerable<ModifiedObj> ChangeProperty { get; }

        ModifiedObj? Add(string variableName, object newValue);
        ModifiedObj? Add(string variableName, object initialValue, object newValue);

        /// <summary>
        /// del last history
        /// </summary>
        /// <param name="variableName"></param>
        /// <returns></returns>
        ModifiedObj? DelHistory(string variableName);
        
        void CancelChanges();
    }
}
