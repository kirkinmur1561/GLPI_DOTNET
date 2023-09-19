using CommonObj.Base;
using CommonObj.Dashboard.Common;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Administration
{
    public class AuthLdap : Dashboard<AuthLdap>, IEquatable<AuthLdap>
    {
        public AuthLdap()
        {
        }

        [JsonProperty(BaseJsonProperty.HOST)]
        public string Host { get; set; }
        
        [JsonProperty(BaseJsonProperty.BASEDN)]
        public string Basedn { get; set; }
        
        [JsonProperty(BaseJsonProperty.ROOTDN)]
        public string Rootdn { get; set; }
        
        [JsonProperty(BaseJsonProperty.PORT)]
        public int Port { get; set; }
        
        [JsonProperty(BaseJsonProperty.CONDITION)]
        public string Condition { get; set; }
        
        [JsonProperty(BaseJsonProperty.LOGIN_FIELD)]
        public string LoginField { get; set; }
        
        [JsonProperty(BaseJsonProperty.SYNC_FIELD)]
        public string SyncField { get; set; }
        
        [JsonProperty(BaseJsonProperty.USE_TLS)]
        public int UseTls { get; set; }
        
        [JsonProperty(BaseJsonProperty.GROUP_FIELD)]
        public string GroupField { get; set; }
        
        [JsonProperty(BaseJsonProperty.GROUP_CONDITION)]
        public string GroupCondition { get; set; }
        
        [JsonProperty(BaseJsonProperty.GROUP_SEARCH_TYPE)]
        public int GroupSearchType { get; set; }
        
        [JsonProperty(BaseJsonProperty.GROUP_MEMBER_FIELD)]
        public string GroupMemberField { get; set; }
        
        [JsonProperty(BaseJsonProperty.EMAIL1_FIELD)]
        public string Email1Field { get; set; }
        
        [JsonProperty(BaseJsonProperty.REALNAME_FIELD)]
        public string RealnameField { get; set; }
        
        [JsonProperty(BaseJsonProperty.FIRSTNAME_FIELD)]
        public string FirstnameField { get; set; }
        
        [JsonProperty(BaseJsonProperty.PHONE_FIELD)]
        public string PhoneField { get; set; }
        
        [JsonProperty(BaseJsonProperty.PHONE2_FIELD)]
        public string Phone2Field { get; set; }
        
        [JsonProperty(BaseJsonProperty.MOBILE_FIELD)]
        public string MobileField { get; set; }
        
        [JsonProperty(BaseJsonProperty.COMMENT_FIELD)]
        public string CommentField { get; set; }
        
        [JsonProperty(BaseJsonProperty.USE_DN)]
        public int UseDn { get; set; }
        
        [JsonProperty(BaseJsonProperty.TIME_OFFSET)]
        public int TimeOffset { get; set; }
        
        [JsonProperty(BaseJsonProperty.DEREF_OPTION)]
        public int DerefOption { get; set; }
        
        [JsonProperty(BaseJsonProperty.TITLE_FIELD)]
        public string TitleField { get; set; }
        
        [JsonProperty(BaseJsonProperty.CATEGORY_FIELD)]
        public string CategoryField { get; set; }
        
        [JsonProperty(BaseJsonProperty.LANGUAGE_FIELD)]
        public object LanguageField { get; set; }
        
        [JsonProperty(BaseJsonProperty.ENTITY_FIELD)]
        public string EntityField { get; set; }
        
        [JsonProperty(BaseJsonProperty.ENTITY_CONDITION)]
        public string EntityCondition { get; set; }
        
        [JsonProperty(BaseJsonProperty.IS_ACTIVE)]
        public bool? IsActive { get; set; }
        
        [JsonProperty(BaseJsonProperty.REGISTRATION_NUMBER_FIELD)]
        public string RegistrationNumberField { get; set; }
        
        [JsonProperty(BaseJsonProperty.EMAIL2_FIELD)]
        public string Email2Field { get; set; }
        
        [JsonProperty(BaseJsonProperty.EMAIL3_FIELD)]
        public string Email3Field { get; set; }
        
        [JsonProperty(BaseJsonProperty.EMAIL4_FIELD)]
        public string Email4Field { get; set; }
        
        [JsonProperty(BaseJsonProperty.LOCATION_FIELD)]
        public string LocationField { get; set; }
        
        [JsonProperty(BaseJsonProperty.RESPONSIBLE_FIELD)]
        public string ResponsibleField { get; set; }
        
        [JsonProperty(BaseJsonProperty.PAGESIZE)]
        public long? Pagesize { get; set; }
        
        [JsonProperty(BaseJsonProperty.LDAP_MAXLIMIT)]
        public long? LdapMaxlimit { get; set; }
        
        [JsonProperty(BaseJsonProperty.CAN_SUPPORT_PAGESIZE)]
        public long? CanSupportPagesize { get; set; }
        
        [JsonProperty(BaseJsonProperty.PICTURE_FIELD)]
        public object PictureField { get; set; }
        
        [JsonProperty(BaseJsonProperty.INVENTORY_DOMAIN)]
        public object InventoryDomain { get; set; }
        
        [JsonProperty(BaseJsonProperty.TLS_CERTFILE)]
        public object TlsCertfile { get; set; }
        
        [JsonProperty(BaseJsonProperty.TLS_KEYFILE)]
        public object TlsKeyfile { get; set; }
        
        [JsonProperty(BaseJsonProperty.USE_BIND)]
        public int UseBind { get; set; }
        
        [JsonProperty(BaseJsonProperty.TIMEOUT)]
        public int Timeout { get; set; }
        

        public override bool Equals(object obj) => 
            Equals(obj as AuthLdap);

        public bool Equals(AuthLdap other) =>
            other != null &&
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
            Host == other.Host &&
            Basedn == other.Basedn &&
            Rootdn == other.Rootdn &&
            Port == other.Port &&
            Condition == other.Condition &&
            LoginField == other.LoginField &&
            SyncField == other.SyncField &&
            UseTls == other.UseTls &&
            GroupField == other.GroupField &&
            GroupCondition == other.GroupCondition &&
            GroupSearchType == other.GroupSearchType &&
            GroupMemberField == other.GroupMemberField &&
            Email1Field == other.Email1Field &&
            RealnameField == other.RealnameField &&
            FirstnameField == other.FirstnameField &&
            PhoneField == other.PhoneField &&
            Phone2Field == other.Phone2Field &&
            MobileField == other.MobileField &&
            CommentField == other.CommentField &&
            UseDn == other.UseDn &&
            TimeOffset == other.TimeOffset &&
            DerefOption == other.DerefOption &&
            TitleField == other.TitleField &&
            CategoryField == other.CategoryField &&
            EqualityComparer<object>.Default.Equals(LanguageField, other.LanguageField) &&
            EntityField == other.EntityField &&
            EntityCondition == other.EntityCondition &&
            IsActive == other.IsActive &&
            RegistrationNumberField == other.RegistrationNumberField &&
            Email2Field == other.Email2Field &&
            Email3Field == other.Email3Field &&
            Email4Field == other.Email4Field &&
            LocationField == other.LocationField &&
            ResponsibleField == other.ResponsibleField &&
            Pagesize == other.Pagesize &&
            LdapMaxlimit == other.LdapMaxlimit &&
            CanSupportPagesize == other.CanSupportPagesize &&
            EqualityComparer<object>.Default.Equals(PictureField, other.PictureField) &&
            EqualityComparer<object>.Default.Equals(InventoryDomain, other.InventoryDomain) &&
            EqualityComparer<object>.Default.Equals(TlsCertfile, other.TlsCertfile) &&
            EqualityComparer<object>.Default.Equals(TlsKeyfile, other.TlsKeyfile) &&
            UseBind == other.UseBind &&
            Timeout == other.Timeout;
        

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
            hash.Add(Host);
            hash.Add(Basedn);
            hash.Add(Rootdn);
            hash.Add(Port);
            hash.Add(Condition);
            hash.Add(LoginField);
            hash.Add(SyncField);
            hash.Add(UseTls);
            hash.Add(GroupField);
            hash.Add(GroupCondition);
            hash.Add(GroupSearchType);
            hash.Add(GroupMemberField);
            hash.Add(Email1Field);
            hash.Add(RealnameField);
            hash.Add(FirstnameField);
            hash.Add(PhoneField);
            hash.Add(Phone2Field);
            hash.Add(MobileField);
            hash.Add(CommentField);
            hash.Add(UseDn);
            hash.Add(TimeOffset);
            hash.Add(DerefOption);
            hash.Add(TitleField);
            hash.Add(CategoryField);
            hash.Add(LanguageField);
            hash.Add(EntityField);
            hash.Add(EntityCondition);
            hash.Add(IsActive);
            hash.Add(RegistrationNumberField);
            hash.Add(Email2Field);
            hash.Add(Email3Field);
            hash.Add(Email4Field);
            hash.Add(LocationField);
            hash.Add(ResponsibleField);
            hash.Add(Pagesize);
            hash.Add(LdapMaxlimit);
            hash.Add(CanSupportPagesize);
            hash.Add(PictureField);
            hash.Add(InventoryDomain);
            hash.Add(TlsCertfile);
            hash.Add(TlsKeyfile);
            hash.Add(UseBind);
            hash.Add(Timeout);
            return hash.ToHashCode();
        }

        public static bool operator ==(AuthLdap left, AuthLdap right) => 
            EqualityComparer<AuthLdap>.Default.Equals(left, right);

        public static bool operator !=(AuthLdap left, AuthLdap right) => 
            !(left == right);
    }
}
