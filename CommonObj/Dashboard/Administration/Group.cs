using CommonObj.Base;
using CommonObj.Dashboard.Common;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Administration
{
    public class Group:Dashboard<Group>
    {
        
        [JsonProperty(BaseJsonProperty.LDAP_FIELD)]
        public object LDAPField { get; set; }
        
        [JsonProperty(BaseJsonProperty.LDAP_VALUE)]
        public object LDAPValue { get; set; }
        
        [JsonProperty(BaseJsonProperty.LDAP_GROUP_DN)]
        public object LDAPGroupDN { get; set; }       
        
        [JsonProperty(BaseJsonProperty.COMPLETENAME)]
        public string CompleteName { get; set; }
        
        [JsonProperty(BaseJsonProperty.LEVEL)]
        public int? Level { get; set; }
        
        [JsonProperty(BaseJsonProperty.ANCESTORS_CACHE)]
        public object CacheAncestors { get; set; }
        
        [JsonProperty(BaseJsonProperty.SONS_CACHE)]
        public object CacheSons { get; set; }
        
        [JsonProperty(BaseJsonProperty.IS_REQUESTER)]
        public bool? IsRequester { get; set; }
        
        [JsonProperty(BaseJsonProperty.IS_WATCHER)]
        public bool? IsWatcher { get; set; }
        
        [JsonProperty(BaseJsonProperty.IS_ASSIGN)]
        public bool? IsAssign { get; set; }
        
        [JsonProperty(BaseJsonProperty.IS_TASK)]
        public bool? IsTask { get; set; }
        
        [JsonProperty(BaseJsonProperty.IS_NOTIFY)]
        public bool? IsNotify { get; set; }
        
        [JsonProperty(BaseJsonProperty.IS_ITEMGROUP)]
        public bool? IsItemGroup { get; set; }
        
        [JsonProperty(BaseJsonProperty.IS_USERGROUP)]
        public bool? IsUserGroup { get; set; }
        
        [JsonProperty(BaseJsonProperty.IS_MANAGER)]
        public bool? IsManager { get; set; }
    }
}
