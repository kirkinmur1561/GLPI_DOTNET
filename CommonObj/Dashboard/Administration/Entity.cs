using CommonObj.Base;
using CommonObj.Dashboard.Common;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Administration
{
    public class Entity : Dashboard<Entity>
    {
        public Entity(){}
        [JsonProperty(BaseJsonProperty.COMPLETENAME)]
        public string Completename { get; set; }
        
        [JsonProperty(BaseJsonProperty.LEVEL)]
        public int Level { get; set; }
        
        [JsonProperty(BaseJsonProperty.SONS_CACHE)]
        public object SonsCache { get; set; }
        
        [JsonProperty(BaseJsonProperty.ANCESTORS_CACHE)]
        public object AncestorsCache { get; set; }
        
        [JsonProperty(BaseJsonProperty.REGISTRATION_NUMBER)]
        public object RegistrationNumber { get; set; }
        
        [JsonProperty(BaseJsonProperty.ADDRESS)]
        public object Address { get; set; }
        
        [JsonProperty(BaseJsonProperty.POSTCODE)]
        public object Postcode { get; set; }
        
        [JsonProperty(BaseJsonProperty.TOWN)]
        public object Town { get; set; }
        
        [JsonProperty(BaseJsonProperty.STATE)]
        public object State { get; set; }
        
        [JsonProperty(BaseJsonProperty.COUNTRY)]
        public object Country { get; set; }
        
        [JsonProperty(BaseJsonProperty.WEBSITE)]
        public object Website { get; set; }
        
        [JsonProperty(BaseJsonProperty.PHONENUMBER)]
        public object Phonenumber { get; set; }
        
        [JsonProperty(BaseJsonProperty.FAX)]
        public object Fax { get; set; }
        
        [JsonProperty(BaseJsonProperty.EMAIL)]
        public object Email { get; set; }
        
        [JsonProperty(BaseJsonProperty.ADMIN_EMAIL)]
        public string AdminEmail { get; set; }
        
        [JsonProperty(BaseJsonProperty.ADMIN_EMAIL_NAME)]
        public string AdminEmailName { get; set; }
        
        [JsonProperty(BaseJsonProperty.REPLYTO_EMAIL)]
        public object ReplytoEmail { get; set; }
        
        [JsonProperty(BaseJsonProperty.REPLYTO_EMAIL_NAME)]
        public object ReplytoEmailName { get; set; }
        
        [JsonProperty(BaseJsonProperty.NOTIFICATION_SUBJECT_TAG)]
        public string NotificationSubjectTag { get; set; }
        
        [JsonProperty(BaseJsonProperty.LDAP_DN)]
        public string LdapDn { get; set; }
        
        [JsonProperty(BaseJsonProperty.TAG)]
        public object Tag { get; set; }
        
        [JsonProperty(BaseJsonProperty.AUTHLDAPS_ID)]
        public long? AuthldapsId { get; set; }
        
        [JsonProperty(BaseJsonProperty.MAIL_DOMAIN)]
        public string MailDomain { get; set; }
        
        [JsonProperty(BaseJsonProperty.ENTITY_LDAPFILTER)]
        public object EntityLdapfilter { get; set; }
        
        [JsonProperty(BaseJsonProperty.MAILING_SIGNATURE)]
        public string MailingSignature { get; set; }
        
        [JsonProperty(BaseJsonProperty.CARTRIDGES_ALERT_REPEAT)]
        public long? CartridgesAlertRepeat { get; set; }
        
        [JsonProperty(BaseJsonProperty.CONSUMABLES_ALERT_REPEAT)]
        public long? ConsumablesAlertRepeat { get; set; }
        
        [JsonProperty(BaseJsonProperty.USE_LICENSES_ALERT)]
        public long? UseLicensesAlert { get; set; }
        
        [JsonProperty(BaseJsonProperty.SEND_LICENSES_ALERT_BEFORE_DELAY)]
        public long? SendLicensesAlertBeforeDelay { get; set; }
        
        [JsonProperty(BaseJsonProperty.USE_CERTIFICATES_ALERT)]
        public long? UseCertificatesAlert { get; set; }
        
        [JsonProperty(BaseJsonProperty.SEND_CERTIFICATES_ALERT_BEFORE_DELAY)]
        public long? SendCertificatesAlertBeforeDelay { get; set; }
        
        [JsonProperty(BaseJsonProperty.CERTIFICATES_ALERT_REPEAT_INTERVAL)]
        public long? CertificatesAlertRepeatInterval { get; set; }
        
        [JsonProperty(BaseJsonProperty.USE_CONTRACTS_ALERT)]
        public long? UseContractsAlert { get; set; }
        
        [JsonProperty(BaseJsonProperty.SEND_CONTRACTS_ALERT_BEFORE_DELAY)]
        public long? SendContractsAlertBeforeDelay { get; set; }
        
        [JsonProperty(BaseJsonProperty.USE_INFOCOMS_ALERT)]
        public long? UseInfocomsAlert { get; set; }
        
        [JsonProperty(BaseJsonProperty.SEND_INFOCOMS_ALERT_BEFORE_DELAY)]
        public long? SendInfocomsAlertBeforeDelay { get; set; }
        
        [JsonProperty(BaseJsonProperty.USE_RESERVATIONS_ALERT)]
        public long? UseReservationsAlert { get; set; }
        
        [JsonProperty(BaseJsonProperty.USE_DOMAINS_ALERT)]
        public long? UseDomainsAlert { get; set; }
        
        [JsonProperty(BaseJsonProperty.SEND_DOMAINS_ALERT_CLOSE_EXPIRIES_DELAY)]
        public long? SendDomainsAlertCloseExpiriesDelay { get; set; }
        
        [JsonProperty(BaseJsonProperty.SEND_DOMAINS_ALERT_EXPIRED_DELAY)]
        public long? SendDomainsAlertExpiredDelay { get; set; }
        
        [JsonProperty(BaseJsonProperty.AUTOCLOSE_DELAY)]
        public long? AutocloseDelay { get; set; }
        
        [JsonProperty(BaseJsonProperty.AUTOPURGE_DELAY)]
        public long? AutopurgeDelay { get; set; }
        
        [JsonProperty(BaseJsonProperty.NOTCLOSED_DELAY)]
        public long? NotclosedDelay { get; set; }
        
        [JsonProperty(BaseJsonProperty.CALENDARS_ID)]
        public long? CalendarsId { get; set; }
        
        [JsonProperty(BaseJsonProperty.AUTO_ASSIGN_MODE)]
        public long? AutoAssignMode { get; set; }
        
        [JsonProperty(BaseJsonProperty.TICKETTYPE)]
        public int? Tickettype { get; set; }
        
        [JsonProperty(BaseJsonProperty.MAX_CLOSEDATE)]
        public object MaxClosedate { get; set; }
        
        [JsonProperty(BaseJsonProperty.INQUEST_CONFIG)]
        public long? InquestConfig { get; set; }
        
        [JsonProperty(BaseJsonProperty.INQUEST_RATE)]
        public long? InquestRate { get; set; }
        
        [JsonProperty(BaseJsonProperty.INQUEST_DELAY)]
        public long? InquestDelay { get; set; }
        
        [JsonProperty(BaseJsonProperty.INQUEST_URL)]
        public string InquestUrl { get; set; }
        
        [JsonProperty(BaseJsonProperty.AUTOFILL_WARRANTY_DATE)]
        public string AutofillWarrantyDate { get; set; }
        
        [JsonProperty(BaseJsonProperty.AUTOFILL_USE_DATE)]
        public string AutofillUseDate { get; set; }
        
        [JsonProperty(BaseJsonProperty.AUTOFILL_BUY_DATE)]
        public string AutofillBuyDate { get; set; }
        
        [JsonProperty(BaseJsonProperty.AUTOFILL_DELIVERY_DATE)]
        public string AutofillDeliveryDate { get; set; }
        
        [JsonProperty(BaseJsonProperty.AUTOFILL_ORDER_DATE)]
        public string AutofillOrderDate { get; set; }
        
        [JsonProperty(BaseJsonProperty.TICKETTEMPLATES_ID)]
        public long? TickettemplatesId { get; set; }
        
        [JsonProperty(BaseJsonProperty.CHANGETEMPLATES_ID)]
        public long? ChangetemplatesId { get; set; }
        
        [JsonProperty(BaseJsonProperty.PROBLEMTEMPLATES_ID)]
        public long? ProblemtemplatesId { get; set; }
        
        [JsonProperty(BaseJsonProperty.ENTITIES_ID_SOFTWARE)]
        public long? EntitiesIdSoftware { get; set; }
        
        [JsonProperty(BaseJsonProperty.DEFAULT_CONTRACT_ALERT)]
        public long? DefaultContractAlert { get; set; }
        
        [JsonProperty(BaseJsonProperty.DEFAULT_INFOCOM_ALERT)]
        public long? DefaultInfocomAlert { get; set; }
        
        [JsonProperty(BaseJsonProperty.DEFAULT_CARTRIDGES_ALARM_THRESHOLD)]
        public long? DefaultCartridgesAlarmThreshold { get; set; }
        
        [JsonProperty(BaseJsonProperty.DEFAULT_CONSUMABLES_ALARM_THRESHOLD)]
        public long? DefaultConsumablesAlarmThreshold { get; set; }
        
        [JsonProperty(BaseJsonProperty.DELAY_SEND_EMAILS)]
        public long? DelaySendEmails { get; set; }
        
        [JsonProperty(BaseJsonProperty.IS_NOTIF_ENABLE_DEFAULT)]
        public long? IsNotifEnableDefault { get; set; }
        
        [JsonProperty(BaseJsonProperty.INQUEST_DURATION)]
        public long? InquestDuration { get; set; }
        
        [JsonProperty(BaseJsonProperty.AUTOFILL_DECOMMISSION_DATE)]
        public string AutofillDecommissionDate { get; set; }
        
        [JsonProperty(BaseJsonProperty.SUPPLIERS_AS_PRIVATE)]
        public long? SuppliersAsPrivate { get; set; }
        
        [JsonProperty(BaseJsonProperty.ANONYMIZE_SUPPORT_AGENTS)]
        public long? AnonymizeSupportAgents { get; set; }
        
        [JsonProperty(BaseJsonProperty.CONTRACTS_ID_DEFAULT)]
        public long? ContractsIdDefault { get; set; }
        
        [JsonProperty(BaseJsonProperty.DISPLAY_USERS_INITIALS)]
        public long? DisplayUsersInitials { get; set; }
        
        [JsonProperty(BaseJsonProperty.ENABLE_CUSTOM_CSS)]
        public long? EnableCustomCss { get; set; }
        
        [JsonProperty(BaseJsonProperty.CUSTOM_CSS_CODE)]
        public long? CustomCssCode { get; set; }
        
        [JsonProperty(BaseJsonProperty.LATITUDE)]
        public object Latitude { get; set; }
        
        [JsonProperty(BaseJsonProperty.LONGITUDE)]
        public object Longitude { get; set; }
        
        [JsonProperty(BaseJsonProperty.ALTITUDE)]
        public object Altitude { get; set; }
        
        [JsonProperty(BaseJsonProperty.CALENDARS_STRATEGY)]
        public long? CalendarsStrategy { get; set; }
        
        [JsonProperty(BaseJsonProperty.CHANGETEMPLATES_STRATEGY)]
        public long? ChangetemplatesStrategy { get; set; }
        
        [JsonProperty(BaseJsonProperty.CONTRACTS_STRATEGY_DEFAULT)]
        public long? ContractsStrategyDefault { get; set; }
        
        [JsonProperty(BaseJsonProperty.ENTITIES_STRATEGY_SOFTWARE)]
        public long? EntitiesStrategySoftware { get; set; }
        
        [JsonProperty(BaseJsonProperty.PROBLEMTEMPLATES_STRATEGY)]
        public long? ProblemtemplatesStrategy { get; set; }
        
        [JsonProperty(BaseJsonProperty.TICKETTEMPLATES_STRATEGY)]
        public long? TickettemplatesStrategy { get; set; }
        
        [JsonProperty(BaseJsonProperty.TRANSFERS_STRATEGY)]
        public long? TransfersStrategy { get; set; }
        
        [JsonProperty(BaseJsonProperty.FROM_EMAIL)]
        public object FromEmail { get; set; }
        
        [JsonProperty(BaseJsonProperty.FROM_EMAIL_NAME)]
        public object FromEmailName { get; set; }
        
        [JsonProperty(BaseJsonProperty.NOREPLY_EMAIL)]
        public object NoreplyEmail { get; set; }
        
        [JsonProperty(BaseJsonProperty.NOREPLY_EMAIL_NAME)]
        public object NoreplyEmailName { get; set; }
        
        [JsonProperty(BaseJsonProperty.TRANSFERS_ID)]
        public long? TransfersId { get; set; }
        
        [JsonProperty(BaseJsonProperty.AGENT_BASE_URL)]
        public object AgentBaseUrl { get; set; }        

    }
}
