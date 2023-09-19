using CommonObj.Base;
using CommonObj.Client;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Administration.Profile
{
    public class ActiveProfile : IEquatable<ActiveProfile>
    {
        [JsonProperty(BaseJsonProperty.ID)]
        public string Id {get;set;}
        
        [JsonProperty(BaseJsonProperty.NAME)]
        public string Name {get;set;}
        
        [JsonProperty(BaseJsonProperty.INTERFACE)]
        public string Interface {get;set;}
        
        [JsonProperty(BaseJsonProperty.IS_DEFAULT)]
        public int IsDefault {get;set;}
        
        [JsonProperty(BaseJsonProperty.HELPDESK_HARDWARE)]
        public string HelpdeskHardware {get;set;}
        
        [JsonProperty(BaseJsonProperty.HELPDESK_ITEM_TYPE)]
        public List<string> HelpdeskItemType {get;set;}
        
        [JsonProperty(BaseJsonProperty.TICKET_STATUS)]
        public List<string> TicketStatus {get;set;}
        
        [JsonProperty(BaseJsonProperty.COMMENT)]
        public string Comment {get;set;}
        
        [JsonProperty(BaseJsonProperty.PROBLEM_STATUS)]
        public List<object> ProblemStatus {get;set;}

        [JsonProperty(BaseJsonProperty.GLPIACTIVE_ENTITY_NAME)]
        public string GlpiactiveEntityName { get; set; }

        [JsonProperty(BaseJsonProperty.DATE_MOD)] 
        public object DateMod { get; set; }

        [JsonProperty(BaseJsonProperty.CREATE_TICKET_ON_LOGIN)]
        public int CreateTicketOnLogin { get; set; }

        [JsonProperty(BaseJsonProperty.TICKET_TEMPLATES_ID)]
        public int TickettemplatesId {get;set;}
        
        [JsonProperty(BaseJsonProperty.CHANGE_TEMPLATES_ID)]
        public int ChangetemplatesId {get;set;}
        
        [JsonProperty(BaseJsonProperty.PROBLEM_TEMPLATES_ID)]
        public int ProblemtemplatesId {get;set;}
        
        [JsonProperty(BaseJsonProperty.CHANGE_STATUS)]
        public object ChangeStatus {get;set;}        

        [JsonProperty(BaseJsonProperty.ANAGED_DOMAINRECORDTYPES)]
        public List<int> AnagedDomainrecordtypes { get; set; }

        [JsonProperty(BaseJsonProperty.DATE_CREATION)]
        public string DateCreation {get;set;}
        
        [JsonProperty(BaseJsonProperty.APPLIANCE)]
        public int Appliance {get;set;}
        
        [JsonProperty(BaseJsonProperty.BACKUP)]
        public int Backup {get;set;}
        
        [JsonProperty(BaseJsonProperty.BOOKMARK_PUBLIC)]
        public int BookmarkPublic {get;set;}
        
        [JsonProperty(BaseJsonProperty.BUDGET)]
        public int Budget {get;set;}
        
        [JsonProperty(BaseJsonProperty.CALENDAR)]
        public int Calendar {get;set;}
        
        [JsonProperty(BaseJsonProperty.CARTRIDGE)]
        public int Cartridge {get;set;}
        
        [JsonProperty(BaseJsonProperty.CERTIFICATE)]
        public int Certificate {get;set;}
        
        [JsonProperty(BaseJsonProperty.CHANGE)]
        public int Change {get;set;}
        
        [JsonProperty(BaseJsonProperty.CHANGEVALIDATION)]
        public int Changevalidation {get;set;}
        
        [JsonProperty(BaseJsonProperty.CLUSTER)]
        public int Cluster {get;set;}
        
        [JsonProperty(BaseJsonProperty.COMPUTER)]
        public int Computer {get;set;}
        
        [JsonProperty(BaseJsonProperty.CONFIG)]
        public int Config {get;set;}
        
        [JsonProperty(BaseJsonProperty.CONSUMABLE)]
        public int Consumable {get;set;}
        
        [JsonProperty(BaseJsonProperty.CONTACT_ENTERPRISE)]
        public int ContactEnterprise {get;set;}
        
        [JsonProperty(BaseJsonProperty.CONTRACT)]
        public int Contract {get;set;}
        
        [JsonProperty(BaseJsonProperty.DASHBOARD)]
        public int Dashboard {get;set;}
        
        [JsonProperty(BaseJsonProperty.DATACENTER)]
        public int Datacenter {get;set;}
        
        [JsonProperty(BaseJsonProperty.DEVICE)]
        public int Device {get;set;}
        
        [JsonProperty(BaseJsonProperty.DEVICESIMCARD_PINPUK)]
        public int DeviceSimcardPinpuk {get;set;}
        
        [JsonProperty(BaseJsonProperty.DOCUMENT)]
        public int Document {get;set;}
        
        [JsonProperty(BaseJsonProperty.DOMAIN)]
        public int Domain {get;set;}
        
        [JsonProperty(BaseJsonProperty.DROPDOWN)]
        public int Dropdown {get;set;}
        
        [JsonProperty(BaseJsonProperty.ENTITY)]
        public int Entity {get;set;}
        
        [JsonProperty(BaseJsonProperty.EXTERNALEVENT)]
        public int ExternalEvent {get;set;}
        
        [JsonProperty(BaseJsonProperty.FOLLOWUP)]
        public int Followup {get;set;}
        
        [JsonProperty(BaseJsonProperty.GLOBAL_VALIDATION)]
        public int GlobalValidation {get;set;}
        
        [JsonProperty(BaseJsonProperty.GROUP)]
        public int Group {get;set;}
        
        [JsonProperty(BaseJsonProperty.INFOCOM)]
        public int Infocom {get;set;}
        
        [JsonProperty(BaseJsonProperty.INTERNET)]
        public int Internet {get;set;}
        
        [JsonProperty(BaseJsonProperty.ITILCATEGORY)]
        public int Itilcategory {get;set;}
        
        [JsonProperty(BaseJsonProperty.ITILTEMPLATE)]
        public int Itiltemplate {get;set;}
        
        [JsonProperty(BaseJsonProperty.KNOWBASE)]
        public int Knowbase {get;set;}
        
        [JsonProperty(BaseJsonProperty.KNOWBASECATEGORY)]
        public int Knowbasecategory {get;set;}
        
        [JsonProperty(BaseJsonProperty.LICENSE)]
        public int License {get;set;}
        
        [JsonProperty(BaseJsonProperty.LINE)]
        public int Line {get;set;}
        
        [JsonProperty(BaseJsonProperty.LINEOPERATOR)]
        public int Lineoperator {get;set;}
        
        [JsonProperty(BaseJsonProperty.LINK)]
        public int Link {get;set;}
        
        [JsonProperty(BaseJsonProperty.LOCATION)]
        public int Location {get;set;}
        
        [JsonProperty(BaseJsonProperty.LOGS)]
        public int Logs {get;set;}
        
        [JsonProperty(BaseJsonProperty.MONITOR)]
        public int Monitor {get;set;}
        
        [JsonProperty(BaseJsonProperty.NETPOINT)]
        public int Netpoint {get;set;}
        
        [JsonProperty(BaseJsonProperty.NETWORKING)]
        public int Networking {get;set;}
        
        [JsonProperty(BaseJsonProperty.NOTIFICATION)]
        public int Notification {get;set;}
        
        [JsonProperty(BaseJsonProperty.PASSWORD_UPDATE)]
        public int PasswordUpdate {get;set;}
        
        [JsonProperty(BaseJsonProperty.PERIPHERAL)]
        public int Peripheral {get;set;}
        
        [JsonProperty(BaseJsonProperty.PERSONALIZATION)]
        public int Personalization {get;set;}
        
        [JsonProperty(BaseJsonProperty.PHONE)]
        public int Phone {get;set;}
        
        [JsonProperty(BaseJsonProperty.PLANNING)]
        public int Planning {get;set;}
        
        [JsonProperty(BaseJsonProperty.PLUGIN_ACCOUNTS)]
        public int PluginAccounts {get;set;}
        
        [JsonProperty(BaseJsonProperty.PLUGIN_ACCOUNTS_HASH)]
        public int PluginAccountsHash {get;set;}        

        [JsonProperty(BaseJsonProperty.PLUGIN_ACCOUNTS_MY_GROUPS)]
        public int PluginAccountsMyGroups { get; set; }

        [JsonProperty(BaseJsonProperty.PLUGIN_ACCOUNTS_OPEN_TICKET)]
        public int PluginAccountsOpenTicket { get; set; }

        [JsonProperty(BaseJsonProperty.PLUGIN_ACCOUNTS_SEE_ALL_USERS)]
        public int PluginAccountsSeeAllUsers { get; set; }

        [JsonProperty(BaseJsonProperty.PLUGIN_ADDRESSING)] 
        public int PluginAddressing {get;set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_ADDRESSING_USE_PING_IN_EQUIPMENT)]
        public int PluginAddressingUsePingInEquipment {get;set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_ARCHIMAP)] 
        public int PluginArchimap {get;set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_ARCHIMAP_OPEN_TICKET)]
        public int PluginArchimapOpenTicket {get;set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_ARCHIRES)] 
        public int PluginArchires {get;set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_BARCODE_BARCODE)]
        public int PluginBarcodeBarcode {get;set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_BARCODE_CONFIG)]
        public int PluginBarcodeConfig {get;set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_DATABASES)] 
        public int PluginDatabases {get;set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_DATABASES_OPEN_TICKET)]
        public int PluginDatabasesOpenTicket {get;set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_DATAINJECTION_MODEL)]
        public int PluginDatainjectionModel {get;set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_DATAINJECTION_USE)]
        public int PluginDatainjectionUse {get;set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_DOMAINS)] 
        public int PluginDomains {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_DOMAINS_DROPDOWN)]
        public int PluginDomainsDropdown {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_DOMAINS_OPEN_TICKET)]
        public int PluginDomainsOpenTicket {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_ENVIRONMENT)] 
        public int PluginEnvironment {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_ENVIRONMENT_ACCOUNTS)]
        public int PluginEnvironmentAccounts {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_ENVIRONMENT_BADGES)]
        public int PluginEnvironmentBadges {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_ENVIRONMENT_DATABASES)]
        public int PluginEnvironmentDatabases {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_ENVIRONMENT_WEBAPPLICATIONS)]
        public int PluginEnvironmentWebapplications {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_AGENT)]
        public int PluginFusioninventoryAgent {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_BLACKLIST)]
        public int PluginFusioninventoryBlacklist {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_COLLECT)]
        public int PluginFusioninventoryCollect {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_CONFIGSECURITY)]
        public int PluginFusioninventoryConfigsecurity {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_CONFIGURATION)]
        public int PluginFusioninventoryConfiguration {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_CREDENTIAL)]
        public int PluginFusioninventoryCredential {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_CREDENTIALIP)]
        public int PluginFusioninventoryCredentialip {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_DEPLOYMIRROR)]
        public int PluginFusioninventoryDeploymirror {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_ESX)]
        public int PluginFusioninventoryEsx {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_GROUP)]
        public int PluginFusioninventoryGroup {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_IGNOREDIMPORTDEVICE)]
        public int PluginFusioninventoryIgnoredimportdevice {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_IMPORTXML)]
        public int PluginFusioninventoryImportxml {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_IPRANGE)]
        public int PluginFusioninventoryIprange {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_LOCK)]
        public int PluginFusioninventoryLock {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_MENU)]
        public int PluginFusioninventoryMenu {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_NETWORKEQUIPMENT)]
        public int PluginFusioninventoryNetworkequipment {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_PACKAGE)]
        public int PluginFusioninventoryPackage {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_PRINTER)]
        public int PluginFusioninventoryPrinter {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_REMOTECONTROL)]
        public int PluginFusioninventoryRemotecontrol {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_REPORTNETWORKEQUIPMENT)]
        public int PluginFusioninventoryReportnetworkequipment {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_REPORTPRINTER)]
        public int PluginFusioninventoryReportprinter {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_RULECOLLECT)]
        public int PluginFusioninventoryRulecollect {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_RULEENTITY)]
        public int PluginFusioninventoryRuleentity {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_RULEIMPORT)]
        public int PluginFusioninventoryRuleimport {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_RULELOCATION)]
        public int PluginFusioninventoryRulelocation {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_SELFPACKAGE)]
        public int PluginFusioninventorySelfpackage {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_TASK)]
        public int PluginFusioninventoryTask {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_UNMANAGED)]
        public int PluginFusioninventoryUnmanaged {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_USERINTERACTIONTEMPLATE)]
        public int PluginFusioninventoryUserinteractiontemplate {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_WOL)]
        public int PluginFusioninventoryWol {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_GENERICOBJECT_TYPES)]
        public int PluginGenericobjectTypes {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_KARASTOCK_HISTORY)]
        public int PluginKarastockHistory {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_KARASTOCK_ORDER)]
        public int PluginKarastockOrder {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_KARASTOCK_STOCK)]
        public int PluginKarastockStock {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_OCSINVENTORYNG)]
        public int PluginOcsinventoryng {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_OCSINVENTORYNG_CLEAN)]
        public int PluginOcsinventoryngClean {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_OCSINVENTORYNG_IMPORT)]
        public int PluginOcsinventoryngImport {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_OCSINVENTORYNG_LINK)]
        public int PluginOcsinventoryngLink {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_OCSINVENTORYNG_RULE)]
        public int PluginOcsinventoryngRule {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_OCSINVENTORYNG_SYNC)]
        public int PluginOcsinventoryngSync {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_OCSINVENTORYNG_VIEW)]
        public int PluginOcsinventoryngView {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_ORDER_BILL)]
        public int PluginOrderBill {get; set;}
        
        [JsonProperty(BaseJsonProperty.PLUGIN_ORDER_ORDER)] 
        public int PluginOrderOrder {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_ORDER_REFERENCE)]
        public int PluginOrderReference {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_PDF)]
        public int PluginPdf {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_PRINTERCOUNTERS)]
        public int PluginPrintercounters {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_PRINTERCOUNTERS_ADD_LOWER_RECORDS)]
        public int PluginPrintercountersAddLowerRecords {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_PRINTERCOUNTERS_SNMPSET)]
        public int PluginPrintercountersSnmpset {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_PRINTERCOUNTERS_UPDATE_RECORDS)]
        public int PluginPrintercountersUpdateRecords {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_PROCESSMAKER_CASE)]
        public int PluginProcessmakerCase {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_PROCESSMAKER_CONFIG)]
        public int PluginProcessmakerConfig {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_APPLICATIONSBYLOCATION)]
        public int PluginReportsApplicationsbylocation {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_DOUBLONS)]
        public int PluginReportsDoublons {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_EQUIPMENTBYGROUPS)]
        public int PluginReportsEquipmentbygroups {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_EQUIPMENTBYLOCATION)]
        public int PluginReportsEquipmentbylocation {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_GLOBALHISTO)]
        public int PluginReportsGlobalhisto {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_HISTOHARD)]
        public int PluginReportsHistohard {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_HISTOINST)]
        public int PluginReportsHistoinst {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_INFOCOM)]
        public int PluginReportsInfocom {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_ITEMINSTALL)]
        public int PluginReportsIteminstall {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_LICENSES)]
        public int PluginReportsLicenses {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_LICENSESEXPIRES)]
        public int PluginReportsLicensesexpires {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_LISTEQUIPMENTBYLOCATION)]
        public int PluginReportsListequipmentbylocation {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_LISTGROUPS)]
        public int PluginReportsListgroups {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_LOCATION)]
        public int PluginReportsLocation {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_ORDER_DELIVERYINFOS)]
        public int PluginReportsOrderDeliveryinfos {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_ORDER_ORDERDELIVERY)]
        public int PluginReportsOrderOrderdelivery {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_PCSBYENTITY)]
        public int PluginReportsPcsbyentity {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_PRINTERS)]
        public int PluginReportsPrinters {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_RULES)] 
        public int PluginReportsRules {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_SEARCHINFOCOM)]
        public int PluginReportsSearchinfocom {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_SOFTNOTINSTALLED)]
        public int PluginReportsSoftnotinstalled {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_SOFTVERSIONINSTALLATIONS)]
        public int PluginReportsSoftversioninstallations {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_STATNIGHTTICKETSBYPRIORITY)]
        public int PluginReportsStatnightticketsbypriority {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_STATTICKETSBYENTITY)]
        public int PluginReportsStatticketsbyentity {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_STATTICKETSBYPRIORITY)]
        public int PluginReportsStatticketsbypriority {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_STATUSERTAS)]
        public int PluginReportsStatusertas {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_TRANSFERREDITEMS)]
        public int PluginReportsTransferreditems {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_ZOMBIES)]
        public int PluginReportsZombies {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_SATISFACTION)] 
        public int PluginSatisfaction {get; set;}
        
        [JsonProperty(BaseJsonProperty.PLUGIN_SHELLCOMMANDS)] 
        public int PluginShellcommands {get; set;}
        
        [JsonProperty(BaseJsonProperty.PLUGIN_TASKLISTS)] 
        public int PluginTasklists {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_TASKLISTS_CONFIG)]
        public int PluginTasklistsConfig {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_TASKLISTS_SEE_ALL)]
        public int PluginTasklistsSeeAll {get; set;}

        [JsonProperty(BaseJsonProperty.PLUGIN_TYPOLOGY)] 
        public int PluginTypology {get; set;}
        
        [JsonProperty(BaseJsonProperty.PLUGIN_VIP)] 
        public int PluginVip {get; set;}        

        [JsonProperty(BaseJsonProperty.PLUGIN_WEBRESOURCES_RESOURCE)]
        public int PluginWebresourcesResource {get; set;}

        [JsonProperty(BaseJsonProperty.PRINTER)] 
        public int Printer {get; set;}
        
        [JsonProperty(BaseJsonProperty.PROBLEM)] 
        public int Problem {get; set;}
        
        [JsonProperty(BaseJsonProperty.PROFILE)] 
        public int Profile {get; set;}
        
        [JsonProperty(BaseJsonProperty.PROJECT)] 
        public int Project {get; set;}
        
        [JsonProperty(BaseJsonProperty.PROJECTTASK)] 
        public int Projecttask {get; set;}
        
        [JsonProperty(BaseJsonProperty.QUEUEDNOTIFICATION)] 
        public int Queuednotification {get; set;}
        
        [JsonProperty(BaseJsonProperty.REMINDER_PUBLIC)] 
        public int ReminderPublic {get; set;}
        
        [JsonProperty(BaseJsonProperty.REPORTS)] 
        public int Reports {get; set;}
        
        [JsonProperty(BaseJsonProperty.RESERVATION)] 
        public int Reservation {get; set;}
        
        [JsonProperty(BaseJsonProperty.RSSFEED_PUBLIC)] 
        public int RssfeedPublic {get; set;}
        
        [JsonProperty(BaseJsonProperty.RULE_ASSET)] 
        public int RuleAsset {get; set;}

        [JsonProperty(BaseJsonProperty.RULE_DICTIONNARY_DROPDOWN)]
        public int RuleDictionnaryDropdown {get; set;}

        [JsonProperty(BaseJsonProperty.RULE_DICTIONNARY_PRINTER)]
        public int RuleDictionnaryPrinter {get; set;}

        [JsonProperty(BaseJsonProperty.RULE_DICTIONNARY_SOFTWARE)]
        public int RuleDictionnarySoftware {get; set;}

        [JsonProperty(BaseJsonProperty.RULE_IMPORT)] 
        public int RuleImport {get; set;}
        
        [JsonProperty(BaseJsonProperty.RULE_LDAP)] 
        public int RuleLdap {get; set;}
        
        [JsonProperty(BaseJsonProperty.RULE_MAILCOLLECTOR)] 
        public int RuleMailcollector {get; set;}        

        [JsonProperty(BaseJsonProperty.RULE_SOFTWARECATEGORIES)]
        public int RuleSoftwarecategories {get; set;}

        [JsonProperty(BaseJsonProperty.RULE_TICKET)] 
        public int RuleTicket {get; set;}
        
        [JsonProperty(BaseJsonProperty.SEARCH_CONFIG)] 
        public int SearchConfig {get; set;}
        
        [JsonProperty(BaseJsonProperty.SHELLCOMMANDS)] 
        public int Shellcommands {get; set;}
        
        [JsonProperty(BaseJsonProperty.SHOW_GROUP_HARDWARE)] 
        public int ShowGroupHardware {get; set;}
        
        [JsonProperty(BaseJsonProperty.SLM)] 
        public int Slm {get; set;}
        
        [JsonProperty(BaseJsonProperty.SOFTWARE)] 
        public int Software {get; set;}
        
        [JsonProperty(BaseJsonProperty.SOLUTIONTEMPLATE)] 
        public int Solutiontemplate {get; set;}
        
        [JsonProperty(BaseJsonProperty.STATE)] 
        public int State {get; set;}
        
        [JsonProperty(BaseJsonProperty.STATISTIC)] 
        public int Statistic {get; set;}
        
        [JsonProperty(BaseJsonProperty.TASK)] 
        public int Task {get; set;}
        
        [JsonProperty(BaseJsonProperty.TASKCATEGORY)] 
        public int Taskcategory {get; set;}
        
        [JsonProperty(BaseJsonProperty.TICKET)] 
        public int Ticket {get; set;}
        
        [JsonProperty(BaseJsonProperty.TICKETCOST)] 
        public int Ticketcost {get; set;}
        
        [JsonProperty(BaseJsonProperty.TICKETRECURRENT)] 
        public int Ticketrecurrent {get; set;}
        
        [JsonProperty(BaseJsonProperty.TICKETVALIDATION)] 
        public int Ticketvalidation {get; set;}
        
        [JsonProperty(BaseJsonProperty.TRANSFER)] 
        public int Transfer {get; set;}
        
        [JsonProperty(BaseJsonProperty.TYPEDOC)] 
        public int Typedoc {get; set;}
        
        [JsonProperty(BaseJsonProperty.USER)] 
        public int User {get; set;}
        
        [JsonProperty(BaseJsonProperty.ENTITIES)] 
        public List<Entity> _entities { get; set; }
        

        public bool Equals(ActiveProfile other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == this.GetType() && Equals((ActiveProfile)obj);
        }

        public override int GetHashCode() => 
            (Id != null ? Id.GetHashCode() : 0);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clt"></param>
        /// <param name="internalTimeout"></param> 
        /// <param name="cancel"></param>
        /// <returns></returns>
        /// <exception cref="ExceptionGLPI_ErrorCommon"></exception>
        public static async Task<ActiveProfile?> GetAsync(
            IClient clt,
            TimeSpan internalTimeout = default,
            CancellationToken cancel = default)
        {
            clt.SetHeaderDefault();
            clt.http.Timeout = internalTimeout != default ? internalTimeout : clt.CommonTimeout;
            HttpResponseMessage response = await clt.http.GetAsync(BaseResource.GET_ACTIVE_PROFILE, cancel);

            string responseData = await response.Content.ReadAsStringAsync(cancel);


            if (!response.IsSuccessStatusCode)
                throw new ExceptionGLPI_ErrorCommon(responseData, response.StatusCode);


            return JsonConvert.DeserializeObject<ActiveProfile>(responseData);
        }
    }
}