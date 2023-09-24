using CommonObj.Base;
using CommonObj.Dashboard.Common;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Helpdesk.Agreements;

public abstract class Agreement:Dashboard<Agreement>
{
    [JsonProperty(BaseJsonProperty.TYPE)]
    public long? TypeId { get; set; }

    [JsonProperty(BaseJsonProperty.NUMBER_TIME)]
    public long? NumberTime { get; set; }

    [JsonProperty(BaseJsonProperty.CALENDARS_ID)]
    public long? CalendarId { get; set; }

    [JsonProperty(BaseJsonProperty.DEFINITION_TIME)]
    public string DefinitionTime { get; set; }
    
    [JsonProperty(BaseJsonProperty.END_OF_WORKING_DAY)]
    public int? EndWorkingDay { get; set; }

    [JsonProperty(BaseJsonProperty.SLM_ID)]
    public long? SlmId { get; set; }
    
    [JsonProperty(BaseJsonProperty.USE_TICKET_CALENDAR)]
    public int? UseTicketCalendar { get; set; }
    public Agreement()
    {
        
    }
}