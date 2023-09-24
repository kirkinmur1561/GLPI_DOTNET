using CommonObj.Base;
using CommonObj.Dashboard.Common;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Helpdesk.Agreements;

public abstract class AgreementLevel:Dashboard<AgreementLevel>
{
    [JsonProperty(BaseJsonProperty.OLAS_ID)]
    public long? OlaId { get; set; }
    
    [JsonProperty(BaseJsonProperty.EXECUTION_TIME)]
    public long? ExecutionTime { get; set; }
    
    [JsonProperty(BaseJsonProperty.IS_ACTIVE)]
    public bool? IsActive { get; set; }

    [JsonProperty(BaseJsonProperty.MATCH)]
    public string Match { get; set; }
    
    [JsonProperty(BaseJsonProperty.UUID)]
    public string UUId { get; set; }  
}