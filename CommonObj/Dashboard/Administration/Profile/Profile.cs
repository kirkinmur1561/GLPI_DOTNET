using CommonObj.Base;
using CommonObj.Client;
using CommonObj.Dashboard.Common;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Administration.Profile
{
    public class Profile : Dashboard<Profile>
    {
        [JsonProperty(BaseJsonProperty.INTERFACE)]
        public string Interface { get; set; }
        
        [JsonProperty(BaseJsonProperty.HELPDESK_HARDWARE)]
        public long? HelpdeskHardware { get; set; }
        
        [JsonProperty(BaseJsonProperty.HELPDESK_ITEM_TYPE)]
        public string[] HelpdeskItemType { get; set; }
        
        [JsonProperty(BaseJsonProperty.TICKET_STATUS)]
        public object StatusTicket { get; set; }
        
        [JsonProperty(BaseJsonProperty.PROBLEM_STATUS)]
        public object StatusProblem { get; set; }
        
        [JsonProperty(BaseJsonProperty.HANGE_STATUS)]
        public object StatusHange { get; set; }
        
        [JsonProperty(BaseJsonProperty.CREATE_TICKET_ON_LOGIN)]
        public bool? IsCreateTicketOnLogin { get; set; }
        
        [JsonProperty(BaseJsonProperty.TICKETTEMPLATES_ID)]
        public long? IdTicketTemplates { get; set; }
        
        [JsonProperty(BaseJsonProperty.CHANGETEMPLATES_ID)]
        public long? IdChangeTemplates { get; set; }
        
        [JsonProperty(BaseJsonProperty.PROBLEMTEMPLATES_ID)]
        public long? IdProblemTemplates { get; set; }

        [JsonProperty(BaseJsonProperty.MANAGED_DOMAINRECORDTYPES)]
        public object ManagedDomainRecordTypes { get; set; }
        
        [JsonProperty(BaseJsonProperty.APPLIANCE)]
        public long? Appliance { get; set; }
        
        [JsonProperty(BaseJsonProperty.BACKUP)]
        public long? Backup { get; set; }
        
        [JsonProperty(BaseJsonProperty.BOOKMARK_PUBLIC)]
        public long? BookmarkPublic { get; set; }
        
        [JsonProperty(BaseJsonProperty.BUDGET)]
        public long? Budget { get; set; }
        
        [JsonProperty(BaseJsonProperty.CABLE_MANAGEMENT)]
        public long? ManagementCable { get; set; }
        
        [JsonProperty(BaseJsonProperty.CALENDAR)]
        public long? Calendar { get; set; }
        
        [JsonProperty(BaseJsonProperty.CARTRIDGE)]
        public long? Cartridge { get; set; }
        
        [JsonProperty(BaseJsonProperty.CERTIFICATE)]
        public long? Certificate { get; set; }
        
        [JsonProperty(BaseJsonProperty.CHANGE)]
        public long? Change { get; set; }
        
        [JsonProperty(BaseJsonProperty.CHANGEVALIDATION)]
        public long? ChangeValidation { get; set; }
        
        [JsonProperty(BaseJsonProperty.CLUSTER)]
        public long? Cluster { get; set; }
        
        [JsonProperty(BaseJsonProperty.COMPUTER)]
        public long? Computer { get; set; }
        
        [JsonProperty(BaseJsonProperty.CONFIG)]
        public long? Config { get; set; }
        
        [JsonProperty(BaseJsonProperty.CONSUMABLE)]
        public long? Consumable { get; set; }
        
        [JsonProperty(BaseJsonProperty.CONTACT_ENTERPRISE)]
        public long? ContactEnterprise { get; set; }
        
        [JsonProperty(BaseJsonProperty.CONTRACT)]
        public long? Contract { get; set; }
        
        [JsonProperty(BaseJsonProperty.DASHBOARD)]
        public long? Dashboard { get; set; }
        
        [JsonProperty(BaseJsonProperty.DATABASE)]
        public long? DataBase { get; set; }
        
        [JsonProperty(BaseJsonProperty.DATACENTER)]
        public long? DataCenter { get; set; }
        
        [JsonProperty(BaseJsonProperty.DEVICE)]
        public long? Device { get; set; }
        
        [JsonProperty(BaseJsonProperty.DEVICESIMCARD_PINPUK)]
        public long? DevicesimcardPinpuk { get; set; }
        
        [JsonProperty(BaseJsonProperty.DOCUMENT)]
        public long? Document { get; set; }
        
        [JsonProperty(BaseJsonProperty.DOMAIN)]
        public long? Domain { get; set; }
        
        [JsonProperty(BaseJsonProperty.DROPDOWN)]
        public long? Dropdown { get; set; }
        
        [JsonProperty(BaseJsonProperty.ENTITY)]
        public long? Entity { get; set; }
        
        [JsonProperty(BaseJsonProperty.EXTERNALEVENT)]
        public long? ExternalEvent { get; set; }
        
        [JsonProperty(BaseJsonProperty.FOLLOWUP)]
        public long? Followup { get; set; }
        
        [JsonProperty(BaseJsonProperty.GLOBAL_VALIDATION)]
        public long? GlobalValidation { get; set; }
        
        [JsonProperty(BaseJsonProperty.GROUP)]
        public long? Group { get; set; }
        
        [JsonProperty(BaseJsonProperty.INFOCOM)]
        public long? Infocom { get; set; }
        
        [JsonProperty(BaseJsonProperty.INTERNET)]
        public long? Internet { get; set; }
        
        [JsonProperty(BaseJsonProperty.INVENTORY)]
        public long? Inventory { get; set; }
        
        [JsonProperty(BaseJsonProperty.ITILCATEGORY)]
        public long? ItilCategory { get; set; }
        
        [JsonProperty(BaseJsonProperty.ITILFOLLOWUPTEMPLATE)]
        public long? ItilFollowupTemplate { get; set; }
        
        [JsonProperty(BaseJsonProperty.ITILTEMPLATE)]
        public long? ItilTemplate { get; set; }
        
        [JsonProperty(BaseJsonProperty.KNOWBASE)]
        public long? KnowBase { get; set; }
        
        [JsonProperty(BaseJsonProperty.KNOWBASECATEGORY)]
        public long? KnowBaseCategory { get; set; }
        
        [JsonProperty(BaseJsonProperty.LICENSE)]
        public long? License { get; set; }
        
        [JsonProperty(BaseJsonProperty.LINE)]
        public long? Line { get; set; }
        
        [JsonProperty(BaseJsonProperty.LINEOPERATOR)]
        public long? LineOperator { get; set; }
        
        [JsonProperty(BaseJsonProperty.LINK)]
        public long? Link { get; set; }
        
        [JsonProperty(BaseJsonProperty.LOCATION)]
        public long? Location { get; set; }
        
        [JsonProperty(BaseJsonProperty.LOGS)]
        public long? Logs { get; set; }
        
        [JsonProperty(BaseJsonProperty.MONITOR)]
        public long? Monitor { get; set; }
        
        [JsonProperty(BaseJsonProperty.NETWORKING)]
        public long? Networking { get; set; }
        
        [JsonProperty(BaseJsonProperty.NOTIFICATION)]
        public long? Notification { get; set; }
        
        [JsonProperty(BaseJsonProperty.PASSWORD_UPDATE)]
        public long? PasswordUpdate { get; set; }
        
        [JsonProperty(BaseJsonProperty.PENDINGREASON)]
        public long? Pendingreason { get; set; }
        
        [JsonProperty(BaseJsonProperty.PERIPHERAL)]
        public long? Peripheral { get; set; }
        
        [JsonProperty(BaseJsonProperty.PERSONALIZATION)]
        public long? Personalization { get; set; }
        
        [JsonProperty(BaseJsonProperty.PHONE)]
        public long? Phone { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLANNING)]
        public long? Planning { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_ACCOUNTS)]
        public long? PluginAccounts { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_ACCOUNTS_HASH)]
        public long? PluginAccountsHash { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_ACCOUNTS_MY_GROUPS)]
        public long? PluginAccountsMyGroups { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_ACCOUNTS_OPEN_TICKET)]
        public long? PluginAccountsOpenTicket { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_ACCOUNTS_SEE_ALL_USERS)]
        public long? PluginAccountsSeeAllUsers { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_ADDRESSING)]
        public long? PluginAddressing { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_ADDRESSING_USE_PING_IN_EQUIPMENT)]
        public long? PluginAddressingUsePingInEquipment { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_ARCHIMAP_OPEN_TICKET)]
        public long? PluginArchimapOpenTicket { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_ARCHIRES)]
        public long? PluginArchires { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_DATABASES_OPEN_TICKET)]
        public long? PluginDatabasesOpenTicket { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_DATAINJECTION_MODEL)]
        public long? PluginDatainjectionModel { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_DATAINJECTION_USE)]
        public long? PluginDatainjectionUse { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_DOMAINS)]
        public long? PluginDomains { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_DOMAINS_DROPDOWN)]
        public long? PluginDomainsDropdown { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_DOMAINS_OPEN_TICKET)]
        public long? PluginDomainsOpenTicket { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_ENVIRONMENT)]
        public long? PluginEnvironment { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_ENVIRONMENT_ACCOUNTS)]
        public long? PluginEnvironmentAccounts { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_ENVIRONMENT_BADGES)]
        public long? PluginEnvironmentBadges { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_ENVIRONMENT_DATABASES)]
        public long? PluginEnvironmentDatabases { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_ENVIRONMENT_WEBAPPLICATIONS)]
        public long? PluginEnvironmentWebapplications { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_AGENT)]
        public long? PluginFusioninventoryAgent { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_BLACKLIST)]
        public long? PluginFusioninventoryBlacklist { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_COLLECT)]
        public long? PluginFusioninventoryCollect { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_CONFIGSECURITY)]
        public long? PluginFusioninventoryConfigsecurity { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_CONFIGURATION)]
        public long? PluginFusioninventoryConfiguration { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_CREDENTIAL)]
        public long? PluginFusioninventoryCredential { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_CREDENTIALIP)]
        public long? PluginFusioninventoryCredentialip { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_DEPLOYMIRROR)]
        public long? PluginFusioninventoryDeploymirror { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_ESX)]
        public long? PluginFusioninventoryEsx { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_GROUP)]
        public long? PluginFusioninventoryGroup { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_IGNOREDIMPORTDEVICE)]
        public long? PluginFusioninventoryIgnoredimportdevice { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_IMPORTXML)]
        public long? PluginFusioninventoryImportxml { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_IPRANGE)]
        public long? PluginFusioninventoryIprange { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_LOCK)]
        public long? PluginFusioninventoryLock { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_MENU)]
        public long? PluginFusioninventoryMenu { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_NETWORKEQUIPMENT)]
        public long? PluginFusioninventoryNetworkequipment { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_PACKAGE)]
        public long? PluginFusioninventoryPackage { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_PRINTER)]
        public long? PluginFusioninventoryPrinter { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_REMOTECONTROL)]
        public long? PluginFusioninventoryRemotecontrol { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_REPORTNETWORKEQUIPMENT)]
        public long? PluginFusioninventoryReportnetworkequipment { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_REPORTPRINTER)]
        public long? PluginFusioninventoryReportprinter { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_RULECOLLECT)]
        public long? PluginFusioninventoryRulecollect { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_RULEENTITY)]
        public long? PluginFusioninventoryRuleentity { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_RULEIMPORT)]
        public long? PluginFusioninventoryRuleimport { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_RULELOCATION)]
        public long? PluginFusioninventoryRulelocation { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_SELFPACKAGE)]
        public long? PluginFusioninventorySelfpackage { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_TASK)]
        public long? PluginFusioninventoryTask { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_UNMANAGED)]
        public long? PluginFusioninventoryUnmanaged { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_USERINTERACTIONTEMPLATE)]
        public long? PluginFusioninventoryUserinteractiontemplate { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_FUSIONINVENTORY_WOL)]
        public long? PluginFusioninventoryWol { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_GENERICOBJECT_DVRS)]
        public long? PluginGenericobjectDvrs { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_GENERICOBJECT_TYPES)]
        public long? PluginGenericobjectTypes { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_KARASTOCK_HISTORY)]
        public long? PluginKarastockHistory { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_KARASTOCK_ORDER)]
        public long? PluginKarastockOrder { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_KARASTOCK_STOCK)]
        public long? PluginKarastockStock { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_OCSINVENTORYNG)]
        public long? PluginOcsinventoryng { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_OCSINVENTORYNG_CLEAN)]
        public long? PluginOcsinventoryngClean { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_OCSINVENTORYNG_IMPORT)]
        public long? PluginOcsinventoryngImport { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_OCSINVENTORYNG_LINK)]
        public long? PluginOcsinventoryngLink { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_OCSINVENTORYNG_RULE)]
        public long? PluginOcsinventoryngRule { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_OCSINVENTORYNG_SYNC)]
        public long? PluginOcsinventoryngSync { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_OCSINVENTORYNG_VIEW)]
        public long? PluginOcsinventoryngView { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_ORDER_BILL)]
        public long? PluginOrderBill { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_ORDER_ORDER)]
        public long? PluginOrderOrder { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_ORDER_REFERENCE)]
        public long? PluginOrderReference { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_PDF)]
        public long? PluginPdf { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_PRINTERCOUNTERS)]
        public long? PluginPrintercounters { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_PRINTERCOUNTERS_ADD_LOWER_RECORDS)]
        public long? PluginPrintercountersAddLowerRecords { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_PRINTERCOUNTERS_SNMPSET)]
        public long? PluginPrintercountersSnmpset { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_PRINTERCOUNTERS_UPDATE_RECORDS)]
        public long? PluginPrintercountersUpdateRecords { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_PROCESSMAKER_CASE)]
        public long? PluginProcessmakerCase { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_PROCESSMAKER_CONFIG)]
        public long? PluginProcessmakerConfig { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_APPLICATIONSBYLOCATION)]
        public long? PluginReportsApplicationsbylocation { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_DOUBLONS)]
        public long? PluginReportsDoublons { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_EQUIPMENTBYGROUPS)]
        public long? PluginReportsEquipmentbygroups { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_EQUIPMENTBYLOCATION)]
        public long? PluginReportsEquipmentbylocation { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_GLOBALHISTO)]
        public long? PluginReportsGlobalhisto { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_HISTOHARD)]
        public long? PluginReportsHistohard { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_HISTOINST)]
        public long? PluginReportsHistoinst { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_INFOCOM)]
        public long? PluginReportsInfocom { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_ITEMINSTALL)]
        public long? PluginReportsIteminstall { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_LICENSES)]
        public long? PluginReportsLicenses { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_LICENSESEXPIRES)]
        public long? PluginReportsLicensesexpires { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_LISTEQUIPMENTBYLOCATION)]
        public long? PluginReportsListequipmentbylocation { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_LISTGROUPS)]
        public long? PluginReportsListgroups { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_LOCATION)]
        public long? PluginReportsLocation { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_ORDER_DELIVERYINFOS)]
        public long? PluginReportsOrderDeliveryinfos { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_ORDER_ORDERDELIVERY)]
        public long? PluginReportsOrderOrderdelivery { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_PCSBYENTITY)]
        public long? PluginReportsPcsbyentity { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_PRINTERS)]
        public long? PluginReportsPrinters { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_RULES)]
        public long? PluginReportsRules { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_SEARCHINFOCOM)]
        public long? PluginReportsSearchinfocom { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_SOFTNOTINSTALLED)]
        public long? PluginReportsSoftnotinstalled { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_SOFTVERSIONINSTALLATIONS)]
        public long? PluginReportsSoftversioninstallations { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_STATNIGHTTICKETSBYPRIORITY)]
        public long? PluginReportsStatnightticketsbypriority { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_STATTICKETSBYENTITY)]
        public long? PluginReportsStatticketsbyentity { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_STATTICKETSBYPRIORITY)]
        public long? PluginReportsStatticketsbypriority { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_STATUSERTASK)]
        public long? PluginReportsStatusertask { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_TRANSFERREDITEMS)]
        public long? PluginReportsTransferreditems { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_REPORTS_ZOMBIES)]
        public long? PluginReportsZombies { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_SATISFACTION)]
        public long? PluginSatisfaction { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_SHELLCOMMANDS)]
        public long? PluginShellcommands { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_TASKLISTS)]
        public long? PluginTasklists { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_TASKLISTS_CONFIG)]
        public long? PluginTasklistsConfig { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_TASKLISTS_SEE_ALL)]
        public long? PluginTasklistsSeeAll { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_TYPOLOGY)]
        public long? PluginTypology { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_VIP)]
        public long? PluginVip { get; set; }
        
        [JsonProperty(BaseJsonProperty.PLUGIN_WEBRESOURCES_RESOURCE)]
        public long? PluginWebresourcesResource { get; set; }
        
        [JsonProperty(BaseJsonProperty.PRINTER)]
        public long? Printer { get; set; }
        
        [JsonProperty(BaseJsonProperty.PROBLEM)]
        public long? Problem { get; set; }
        
        [JsonProperty(BaseJsonProperty.PROFILE)]
        public long? profile { get; set; }
        
        [JsonProperty(BaseJsonProperty.PROJECT)]
        public long? Project { get; set; }
        
        [JsonProperty(BaseJsonProperty.PROJECTTASK)]
        public long? Projecttask { get; set; }
        
        [JsonProperty(BaseJsonProperty.QUEUEDNOTIFICATION)]
        public long? Queuednotification { get; set; }
        
        [JsonProperty(BaseJsonProperty.RECURRENTCHANGE)]
        public long? Recurrentchange { get; set; }
        
        [JsonProperty(BaseJsonProperty.REMINDER_PUBLIC)]
        public long? ReminderPublic { get; set; }
        
        [JsonProperty(BaseJsonProperty.REPORTS)]
        public long? Reports { get; set; }
        
        [JsonProperty(BaseJsonProperty.RESERVATION)]
        public long? Reservation { get; set; }
        
        [JsonProperty(BaseJsonProperty.RSSFEED_PUBLIC)]
        public long? RssfeedPublic { get; set; }
        
        [JsonProperty(BaseJsonProperty.RULE_ASSET)]
        public long? RuleAsset { get; set; }
        
        [JsonProperty(BaseJsonProperty.RULE_DICTIONNARY_DROPDOWN)]
        public long? RuleDictionnaryDropdown { get; set; }
        
        [JsonProperty(BaseJsonProperty.RULE_DICTIONNARY_PRINTER)]
        public long? RuleDictionnaryPrinter { get; set; }
        
        [JsonProperty(BaseJsonProperty.RULE_DICTIONNARY_SOFTWARE)]
        public long? RuleDictionnarySoftware { get; set; }
        
        [JsonProperty(BaseJsonProperty.RULE_IMPORT)]
        public long? RuleImport { get; set; }
        
        [JsonProperty(BaseJsonProperty.RULE_LDAP)]
        public long? RuleLdap { get; set; }
        
        [JsonProperty(BaseJsonProperty.RULE_MAILCOLLECTOR)]
        public long? RuleMailcollector { get; set; }
        
        [JsonProperty(BaseJsonProperty.RULE_SOFTWARECATEGORIES)]
        public long? RuleSoftwarecategories { get; set; }
        
        [JsonProperty(BaseJsonProperty.RULE_TICKET)]
        public long? RuleTicket { get; set; }
        
        [JsonProperty(BaseJsonProperty.SEARCH_CONFIG)]
        public long? SearchConfig { get; set; }
        
        [JsonProperty(BaseJsonProperty.SHELLCOMMANDS)]
        public long? Shellcommands { get; set; }
        
        [JsonProperty(BaseJsonProperty.SHOW_GROUP_HARDWARE)]
        public long? ShowGroupHardware { get; set; }
        
        [JsonProperty(BaseJsonProperty.SLM)]
        public long? Slm { get; set; }
        
        [JsonProperty(BaseJsonProperty.SOFTWARE)]
        public long? Software { get; set; }
        
        [JsonProperty(BaseJsonProperty.SOLUTIONTEMPLATE)]
        public long? Solutiontemplate { get; set; }
        
        [JsonProperty(BaseJsonProperty.STATE)]
        public long? State { get; set; }
        
        [JsonProperty(BaseJsonProperty.STATISTIC)]
        public long? Statistic { get; set; }
        
        [JsonProperty(BaseJsonProperty.TASK)]
        public long? Task { get; set; }
        
        [JsonProperty(BaseJsonProperty.TASKCATEGORY)]
        public long? Taskcategory { get; set; }
        
        [JsonProperty(BaseJsonProperty.TICKET)]
        public long? Ticket { get; set; }
        
        [JsonProperty(BaseJsonProperty.TICKETCOST)]
        public long? Ticketcost { get; set; }
        
        [JsonProperty(BaseJsonProperty.TICKETRECURRENT)]
        public long? Ticketrecurrent { get; set; }
        
        [JsonProperty(BaseJsonProperty.TICKETVALIDATION)]
        public long? Ticketvalidation { get; set; }
        
        [JsonProperty(BaseJsonProperty.TRANSFER)]
        public long? Transfer { get; set; }
        
        [JsonProperty(BaseJsonProperty.TYPEDOC)]
        public long? Typedoc { get; set; }
        
        [JsonProperty(BaseJsonProperty.USER)]
        public long? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clt"></param>
        /// <param name="internalTimeout"></param>
        /// <param name="cancel"></param>
        /// <returns></returns>
        /// <exception cref="ExceptionGLPI_ErrorCommon"></exception>
        public static async Task<Profile?> GetAsync(IClient clt,TimeSpan internalTimeout = default,CancellationToken cancel = default)
        {                        
            clt.SetHeaderDefault();
            clt.http.Timeout = internalTimeout != default ? internalTimeout : clt.CommonTimeout;
            HttpResponseMessage response = await clt.http.GetAsync(BaseResource.GET_MY_PROFILES, cancel);

            if (!response.IsSuccessStatusCode)
                throw new ExceptionGLPI_ErrorCommon(await response.Content.ReadAsStringAsync(cancel),
                    response.StatusCode);                

            return JsonConvert.DeserializeObject<Profile>(await response.Content.ReadAsStringAsync(cancel));
        }
    }
}
