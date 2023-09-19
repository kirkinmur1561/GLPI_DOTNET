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
        
        [JsonProperty("email")]
        public string Email { get; set; }
        
        [JsonProperty("is_default")]
        public bool? IsDefault { get; set; }
        
        
    }
}