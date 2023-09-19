using CommonObj.Base;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Common.LinkCommon
{
    public class Entity:Dashboard<Entity>
    {       
        
        [JsonProperty(BaseJsonProperty.COMPLETENAME)]
        public string CompleteName {get; set;}       
        
        [JsonProperty(BaseJsonProperty.LEVEL)]
        public long? Level {get; set;}
        
        [JsonProperty(BaseJsonProperty.SONS_CACHE)]
        public object SonsCache {get; set;}
        
        [JsonProperty(BaseJsonProperty.ANCESTORS_CACHE)]
        public object AncestorsCache {get; set;}
        
        [JsonProperty(BaseJsonProperty.REGISTRATION_NUMBER)]
        public object RegistrationNumber {get; set;}
        
        [JsonProperty(BaseJsonProperty.ADDRESS)]
        public object Address {get; set;}
        
        [JsonProperty(BaseJsonProperty.POSTCODE)]
        public object Postcode {get; set;}
        
        [JsonProperty(BaseJsonProperty.TOWN)]
        public object Town {get; set;}
        
        [JsonProperty(BaseJsonProperty.STATE)]
        public object State {get; set;}
        
        [JsonProperty(BaseJsonProperty.COUNTRY)]
        public object Country {get; set;}
        
        [JsonProperty(BaseJsonProperty.WEBSITE)]
        public object Website {get; set;}
        
        [JsonProperty(BaseJsonProperty.PHONENUMBER)]
        public object PhoneNumber {get; set;}
        
        [JsonProperty(BaseJsonProperty.FAX)]
        public object Fax {get; set;}
        
        [JsonProperty(BaseJsonProperty.EMAIL)]
        public string Email {get; set;}
        
        [JsonProperty(BaseJsonProperty.ADMIN_EMAIL)]
        public string EmailAdmin {get; set;}
        
        [JsonProperty(BaseJsonProperty.ADMIN_EMAIL_NAME)]
        public string EmailAdminName {get; set;}
        
        [JsonProperty(BaseJsonProperty.REPLYTO_EMAIL)]
        public string EmailReply {get; set;}
        
        [JsonProperty(BaseJsonProperty.REPLYTO_EMAIL_NAME)]
        public string EmailReplyName {get; set;}
        
        [JsonProperty(BaseJsonProperty.NOTIFICATION_SUBJECT_TAG)]
        public string TagNotificationSubject {get; set;}
        
        [JsonProperty(BaseJsonProperty.LDAP_DN)]
        public string LDAP_DN {get; set;}
        
        [JsonProperty(BaseJsonProperty.TAG)]
        public string Tag {get; set;}
        
        [JsonProperty(BaseJsonProperty.AUTHLDAPS_ID)]
        public long? IdAuthLDAP {get; set;}
        
        [JsonProperty(BaseJsonProperty.MAIL_DOMAIN)]
        public string EmailDomain {get; set;}
        
        [JsonProperty(BaseJsonProperty.ENTITY_LDAPFILTER)]
        public string EntityLDAP_Filter {get; set;}
        
        [JsonProperty(BaseJsonProperty.MAILING_SIGNATURE)]
        public string EmailingSignature {get; set;}
        
        [JsonProperty(BaseJsonProperty.CARTRIDGES_ALERT_REPEAT)]
        public long? AlertRepeatCartridges {get; set;}
        
        [JsonProperty(BaseJsonProperty.CONSUMABLES_ALERT_REPEAT)]
        public long? AlertRepeatConsumables {get; set;}
        
        [JsonProperty(BaseJsonProperty.USE_LICENSES_ALERT)]
        public long? AlertUseLicenses {get; set;}
        
        [JsonProperty(BaseJsonProperty.SEND_LICENSES_ALERT_BEFORE_DELAY)]
        public long? AlertBeforeDelaySendLicenses {get; set;}
        
        [JsonProperty(BaseJsonProperty.USE_CERTIFICATES_ALERT)]
        public long? AlertUseCertificates {get; set;}
        
        [JsonProperty(BaseJsonProperty.SEND_CERTIFICATES_ALERT_BEFORE_DELAY)]
        public long? AlertBeforeDelaySendCertificates {get; set;}
        
        [JsonProperty(BaseJsonProperty.CERTIFICATES_ALERT_REPEAT_INTERVAL)]
        public long? AlertRepeatIntervalCertificates {get; set;}
        
        [JsonProperty(BaseJsonProperty.USE_CONTRACTS_ALERT)]
        public long? AlertUseContracts {get; set;}
        
        [JsonProperty(BaseJsonProperty.SEND_CONTRACTS_ALERT_BEFORE_DELAY)]
        public long? send_contracts_alert_before_delay {get; set;}
        
        [JsonProperty(BaseJsonProperty.USE_INFOCOMS_ALERT)]
        public long? use_infocoms_alert {get; set;}
        
        [JsonProperty(BaseJsonProperty.SEND_INFOCOMS_ALERT_BEFORE_DELAY)]
        public long? send_infocoms_alert_before_delay {get; set;}
        
        [JsonProperty(BaseJsonProperty.USE_RESERVATIONS_ALERT)]
        public long? use_reservations_alert {get; set;}
        
        [JsonProperty(BaseJsonProperty.USE_DOMAINS_ALERT)]
        public long? use_domains_alert {get; set;}
        
        [JsonProperty(BaseJsonProperty.SEND_DOMAINS_ALERT_CLOSE_EXPIRIES_DELAY)]
        public long? send_domains_alert_close_expiries_delay {get; set;}
        
        [JsonProperty(BaseJsonProperty.SEND_DOMAINS_ALERT_EXPIRED_DELAY)]
        public long? send_domains_alert_expired_delay {get; set;}
        
        [JsonProperty(BaseJsonProperty.AUTOCLOSE_DELAY)]
        public long? autoclose_delay {get; set;}
        
        [JsonProperty(BaseJsonProperty.AUTOPURGE_DELAY)]
        public long? autopurge_delay {get; set;}
        
        [JsonProperty(BaseJsonProperty.NOTCLOSED_DELAY)]
        public long? notclosed_delay {get; set;}
        
        [JsonProperty(BaseJsonProperty.CALENDARS_ID)]
        public long? calendars_id {get; set;}
        
        [JsonProperty(BaseJsonProperty.AUTO_ASSIGN_MODE)]
        public long? auto_assign_mode {get; set;}
        
        [JsonProperty(BaseJsonProperty.TICKETTYPE)]
        public long? tickettype {get; set;}
        
        [JsonProperty(BaseJsonProperty.MAX_CLOSEDATE)]
        public object max_closedate {get; set;}
        
        [JsonProperty(BaseJsonProperty.INQUEST_CONFIG)]
        public object inquest_config {get; set;}
        
        [JsonProperty(BaseJsonProperty.INQUEST_RATE)]
        public object inquest_rate {get; set;}
        
        [JsonProperty(BaseJsonProperty.INQUEST_DELAY)]
        public object inquest_delay {get; set;}
        
        [JsonProperty(BaseJsonProperty.INQUEST_URL)]
        public object inquest_URL {get; set;}
        
        [JsonProperty(BaseJsonProperty.AUTOFILL_WARRANTY_DATE)]
        public object autofill_warranty_date {get; set;}
        
        [JsonProperty(BaseJsonProperty.AUTOFILL_USE_DATE)]
        public object autofill_use_date {get; set;}
        
        [JsonProperty(BaseJsonProperty.AUTOFILL_BUY_DATE)]
        public object autofill_buy_date {get; set;}
        
        [JsonProperty(BaseJsonProperty.AUTOFILL_DELIVERY_DATE)]
        public object autofill_delivery_date {get; set;}
        
        [JsonProperty(BaseJsonProperty.AUTOFILL_ORDER_DATE)]
        public object autofill_order_date {get; set;}
        
        [JsonProperty(BaseJsonProperty.TICKETTEMPLATES_ID)]
        public object tickettemplates_id {get; set;}
        
        [JsonProperty(BaseJsonProperty.CHANGETEMPLATES_ID)]
        public object changetemplates_id {get; set;}
        
        [JsonProperty(BaseJsonProperty.PROBLEMTEMPLATES_ID)]
        public object problemtemplates_id {get; set;}
        
        [JsonProperty(BaseJsonProperty.ENTITIES_ID_SOFTWARE)]
        public object entities_id_software {get; set;}
        
        [JsonProperty(BaseJsonProperty.DEFAULT_CONTRACT_ALERT)]
        public object default_contract_alert {get; set;}
        
        [JsonProperty(BaseJsonProperty.DEFAULT_INFOCOM_ALERT)]
        public object default_infocom_alert {get; set;}
        
        [JsonProperty(BaseJsonProperty.DEFAULT_CARTRIDGES_ALARM_THRESHOLD)]
        public object default_cartridges_alarm_threshold {get; set;}
        
        [JsonProperty(BaseJsonProperty.DEFAULT_CONSUMABLES_ALARM_THRESHOLD)]
        public object default_consumables_alarm_threshold {get; set;}
        
        [JsonProperty(BaseJsonProperty.DELAY_SEND_EMAILS)]
        public object delay_send_emails {get; set;}
        
        [JsonProperty(BaseJsonProperty.IS_NOTIF_ENABLE_DEFAULT)]
        public object is_notif_enable_default {get; set;}
        
        [JsonProperty(BaseJsonProperty.INQUEST_DURATION)]
        public object inquest_duration {get; set;}
        
        [JsonProperty(BaseJsonProperty.DATE_MOD)]
        public object date_mod {get; set;}
        
        [JsonProperty(BaseJsonProperty.DATE_CREATION)]
        public object date_creation {get; set;}
        
        [JsonProperty(BaseJsonProperty.AUTOFILL_DECOMMISSION_DATE)]
        public object autofill_decommission_date {get; set;}
        
        [JsonProperty(BaseJsonProperty.SUPPLIERS_AS_PRIVATE)]
        public object suppliers_as_private {get; set;}
        
        [JsonProperty(BaseJsonProperty.ANONYMIZE_SUPPORT_AGENTS)]
        public object anonymize_support_agents {get; set;}
        
        [JsonProperty(BaseJsonProperty.CONTRACTS_ID_DEFAULT)]
        public object contracts_id_default {get; set;}
        
        [JsonProperty(BaseJsonProperty.DISPLAY_USERS_INITIALS)]
        public object display_users_initials {get; set;}
        
        [JsonProperty(BaseJsonProperty.ENABLE_CUSTOM_CSS)]
        public object enable_custom_css {get; set;}
        
        [JsonProperty(BaseJsonProperty.CUSTOM_CSS_CODE)]
        public object custom_css_code {get; set;}
        
        [JsonProperty(BaseJsonProperty.LATITUDE)]
        public object latitude {get; set;}
        
        [JsonProperty(BaseJsonProperty.LONGITUDE)]
        public object longitude {get; set;}
        
        [JsonProperty(BaseJsonProperty.ALTITUDE)]
        public object altitude {get; set;}
        
        [JsonProperty(BaseJsonProperty.CALENDARS_STRATEGY)]
        public object calendars_strategy {get; set;}
        
        [JsonProperty(BaseJsonProperty.CHANGETEMPLATES_STRATEGY)]
        public object changetemplates_strategy {get; set;}
        
        [JsonProperty(BaseJsonProperty.CONTRACTS_STRATEGY_DEFAULT)]
        public object contracts_strategy_default {get; set;}
        
        [JsonProperty(BaseJsonProperty.ENTITIES_STRATEGY_SOFTWARE)]
        public object entities_strategy_software {get; set;}
        
        [JsonProperty(BaseJsonProperty.PROBLEMTEMPLATES_STRATEGY)]
        public object problemtemplates_strategy {get; set;}
        
        [JsonProperty(BaseJsonProperty.TICKETTEMPLATES_STRATEGY)]
        public object tickettemplates_strategy {get; set;}
        
        [JsonProperty(BaseJsonProperty.TRANSFERS_STRATEGY)]
        public object transfers_strategy {get; set;}
        
        [JsonProperty(BaseJsonProperty.FROM_EMAIL)]
        public object from_email {get; set;}
        
        [JsonProperty(BaseJsonProperty.FROM_EMAIL_NAME)]
        public object from_email_name {get; set;}
        
        [JsonProperty(BaseJsonProperty.NOREPLY_EMAIL)]
        public object noreply_email {get; set;}
        
        [JsonProperty(BaseJsonProperty.NOREPLY_EMAIL_NAME)]
        public object noreply_email_name {get; set;}
        
        [JsonProperty(BaseJsonProperty.TRANSFERS_ID)]
        public object transfers_id {get; set;}
        
        [JsonProperty(BaseJsonProperty.AGENT_BASE_URL)]
        public object agent_base_url {get; set;}        
    }
}