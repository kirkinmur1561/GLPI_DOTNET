using CommonObj.Base;
using CommonObj.Dashboard.Common;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Administration
{
    /// <summary>
    /// /*унаследованы все поля*/
    /// </summary>
    public class Calendar:Dashboard<Calendar>
    {
        [JsonProperty(BaseJsonProperty.CACHE_DURATION)]
        public int[] CacheDuration { get; set; }
    }
}
