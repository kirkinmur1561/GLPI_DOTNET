using CommonObj.Base;
using CommonObj.Dashboard.Common;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Administration.User
{
    /// <summary>
    /// Property class: id,user_id,is_dynamic,email and links the rest is empty
    /// </summary>
    public class UserEmail: Dashboard<UserEmail>
    {
        public UserEmail()
        {
            
        }
        
        [JsonProperty(BaseJsonProperty.EMAIL)]
        public string Email { get; set; }
        
        [JsonProperty(BaseJsonProperty.IS_DEFAULT)]
        public bool? IsDefault { get; set; }
        
        
    }
}