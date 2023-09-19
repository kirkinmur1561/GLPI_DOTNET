using CommonObj.Base;
using CommonObj.Client;
using CommonObj.Dashboard.Common;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Administration.Profile
{
    public class Profile : Dashboard<Profile>
    {

        [JsonProperty("interface")]
        public string Interface { get; set; }
        
        [JsonProperty("helpdesk_hardware")]
        public long? HelpdeskHardware { get; set; }
        
        [JsonProperty("helpdesk_item_type")]
        public string[] HelpdeskItemType { get; set; }
        
        [JsonProperty("ticket_status")]
        public object StatusTicket { get; set; }
        
        [JsonProperty("problem_status")]
        public object StatusProblem { get; set; }
        
        [JsonProperty("hange_status")]
        public object StatusHange { get; set; }
        
        [JsonProperty("create_ticket_on_login")]
        public bool? IsCreateTicketOnLogin { get; set; }
        
        [JsonProperty("tickettemplates_id")]
        public long? IdTicketTemplates { get; set; }
        
        [JsonProperty("changetemplates_id")]
        public long? IdChangeTemplates { get; set; }
        
        [JsonProperty("problemtemplates_id")]
        public long? IdProblemTemplates { get; set; }

        [JsonProperty("managed_domainrecordtypes")]
        public object ManagedDomainRecordTypes { get; set; }
        
        [JsonProperty("appliance")]
        public long? Appliance { get; set; }
        
        [JsonProperty("backup")]
        public long? Backup { get; set; }
        
        [JsonProperty("bookmark_public")]
        public long? BookmarkPublic { get; set; }
        
        [JsonProperty("budget")]
        public long? Budget { get; set; }
        
        [JsonProperty("cable_management")]
        public long? ManagementCable { get; set; }
        
        [JsonProperty("calendar")]
        public long? Calendar { get; set; }
        
        [JsonProperty("cartridge")]
        public long? Cartridge { get; set; }
        
        [JsonProperty("certificate")]
        public long? Certificate { get; set; }
        
        [JsonProperty("change")]
        public long? Change { get; set; }
        
        [JsonProperty("changevalidation")]
        public long? ChangeValidation { get; set; }
        
        [JsonProperty("cluster")]
        public long? Cluster { get; set; }
        
        [JsonProperty("computer")]
        public long? Computer { get; set; }
        
        [JsonProperty("config")]
        public long? Config { get; set; }
        
        [JsonProperty("consumable")]
        public long? Consumable { get; set; }
        
        [JsonProperty("contact_enterprise")]
        public long? ContactEnterprise { get; set; }
        
        [JsonProperty("contract")]
        public long? Contract { get; set; }
        
        [JsonProperty("dashboard")]
        public long? Dashboard { get; set; }
        
        [JsonProperty("database")]
        public long? DataBase { get; set; }
        
        [JsonProperty("datacenter")]
        public long? DataCenter { get; set; }
        
        [JsonProperty("device")]
        public long? Device { get; set; }
        
        [JsonProperty("devicesimcard_pinpuk")]
        public long? DevicesimcardPinpuk { get; set; }
        
        [JsonProperty("document")]
        public long? Document { get; set; }
        
        [JsonProperty("domain")]
        public long? Domain { get; set; }
        
        [JsonProperty("dropdown")]
        public long? Dropdown { get; set; }
        
        [JsonProperty("entity")]
        public long? Entity { get; set; }
        
        [JsonProperty("externalevent")]
        public long? ExternalEvent { get; set; }
        
        [JsonProperty("followup")]
        public long? Followup { get; set; }
        
        [JsonProperty("global_validation")]
        public long? GlobalValidation { get; set; }
        
        [JsonProperty("group")]
        public long? Group { get; set; }
        
        [JsonProperty("infocom")]
        public long? Infocom { get; set; }
        
        [JsonProperty("internet")]
        public long? Internet { get; set; }
        
        [JsonProperty("inventory")]
        public long? Inventory { get; set; }
        
        [JsonProperty("itilcategory")]
        public long? ItilCategory { get; set; }
        
        [JsonProperty("itilfollowuptemplate")]
        public long? ItilFollowupTemplate { get; set; }
        
        [JsonProperty("itiltemplate")]
        public long? ItilTemplate { get; set; }
        
        [JsonProperty("knowbase")]
        public long? KnowBase { get; set; }
        
        [JsonProperty("knowbasecategory")]
        public long? KnowBaseCategory { get; set; }
        
        [JsonProperty("license")]
        public long? License { get; set; }
        
        [JsonProperty("line")]
        public long? Line { get; set; }
        
        [JsonProperty("lineoperator")]
        public long? LineOperator { get; set; }
        
        [JsonProperty("link")]
        public long? Link { get; set; }
        
        [JsonProperty("location")]
        public long? Location { get; set; }
        
        [JsonProperty("logs")]
        public long? Logs { get; set; }
        
        [JsonProperty("monitor")]
        public long? Monitor { get; set; }
        
        [JsonProperty("networking")]
        public long? Networking { get; set; }
        
        [JsonProperty("notification")]
        public long? Notification { get; set; }
        
        [JsonProperty("password_update")]
        public long? PasswordUpdate { get; set; }
        
        [JsonProperty("pendingreason")]
        public long? Pendingreason { get; set; }
        
        [JsonProperty("peripheral")]
        public long? Peripheral { get; set; }
        
        [JsonProperty("personalization")]
        public long? Personalization { get; set; }
        
        [JsonProperty("phone")]
        public long? Phone { get; set; }
        
        [JsonProperty("planning")]
        public long? Planning { get; set; }
        
        [JsonProperty("plugin_accounts")]
        public long? PluginAccounts { get; set; }
        
        [JsonProperty("plugin_accounts_hash")]
        public long? PluginAccountsHash { get; set; }
        
        [JsonProperty("plugin_accounts_my_groups")]
        public long? PluginAccountsMyGroups { get; set; }
        
        [JsonProperty("plugin_accounts_open_ticket")]
        public long? PluginAccountsOpenTicket { get; set; }
        
        [JsonProperty("plugin_accounts_see_all_users")]
        public long? PluginAccountsSeeAllUsers { get; set; }
        
        [JsonProperty("plugin_addressing")]
        public long? PluginAddressing { get; set; }
        
        [JsonProperty("plugin_addressing_use_ping_in_equipment")]
        public long? PluginAddressingUsePingInEquipment { get; set; }
        
        [JsonProperty("plugin_archimap_open_ticket")]
        public long? PluginArchimapOpenTicket { get; set; }
        
        [JsonProperty("plugin_archires")]
        public long? PluginArchires { get; set; }
        
        [JsonProperty("plugin_databases_open_ticket")]
        public long? PluginDatabasesOpenTicket { get; set; }
        
        [JsonProperty("plugin_datainjection_model")]
        public long? PluginDatainjectionModel { get; set; }
        
        [JsonProperty("plugin_datainjection_use")]
        public long? PluginDatainjectionUse { get; set; }
        
        [JsonProperty("plugin_domains")]
        public long? PluginDomains { get; set; }
        
        [JsonProperty("plugin_domains_dropdown")]
        public long? PluginDomainsDropdown { get; set; }
        
        [JsonProperty("plugin_domains_open_ticket")]
        public long? PluginDomainsOpenTicket { get; set; }
        
        [JsonProperty("plugin_environment")]
        public long? PluginEnvironment { get; set; }
        
        [JsonProperty("plugin_environment_accounts")]
        public long? PluginEnvironmentAccounts { get; set; }
        
        [JsonProperty("plugin_environment_badges")]
        public long? PluginEnvironmentBadges { get; set; }
        
        [JsonProperty("plugin_environment_databases")]
        public long? PluginEnvironmentDatabases { get; set; }
        
        [JsonProperty("plugin_environment_webapplications")]
        public long? PluginEnvironmentWebapplications { get; set; }
        
        [JsonProperty("plugin_fusioninventory_agent")]
        public long? PluginFusioninventoryAgent { get; set; }
        
        [JsonProperty("plugin_fusioninventory_blacklist")]
        public long? PluginFusioninventoryBlacklist { get; set; }
        
        [JsonProperty("plugin_fusioninventory_collect")]
        public long? PluginFusioninventoryCollect { get; set; }
        
        [JsonProperty("plugin_fusioninventory_configsecurity")]
        public long? PluginFusioninventoryConfigsecurity { get; set; }
        
        [JsonProperty("plugin_fusioninventory_configuration")]
        public long? PluginFusioninventoryConfiguration { get; set; }
        
        [JsonProperty("plugin_fusioninventory_credential")]
        public long? PluginFusioninventoryCredential { get; set; }
        
        [JsonProperty("plugin_fusioninventory_credentialip")]
        public long? PluginFusioninventoryCredentialip { get; set; }
        
        [JsonProperty("plugin_fusioninventory_deploymirror")]
        public long? PluginFusioninventoryDeploymirror { get; set; }
        
        [JsonProperty("plugin_fusioninventory_esx")]
        public long? PluginFusioninventoryEsx { get; set; }
        
        [JsonProperty("plugin_fusioninventory_group")]
        public long? PluginFusioninventoryGroup { get; set; }
        
        [JsonProperty("plugin_fusioninventory_ignoredimportdevice")]
        public long? PluginFusioninventoryIgnoredimportdevice { get; set; }
        
        [JsonProperty("plugin_fusioninventory_importxml")]
        public long? PluginFusioninventoryImportxml { get; set; }
        
        [JsonProperty("plugin_fusioninventory_iprange")]
        public long? PluginFusioninventoryIprange { get; set; }
        
        [JsonProperty("plugin_fusioninventory_lock")]
        public long? PluginFusioninventoryLock { get; set; }
        
        [JsonProperty("plugin_fusioninventory_menu")]
        public long? PluginFusioninventoryMenu { get; set; }
        
        [JsonProperty("plugin_fusioninventory_networkequipment")]
        public long? PluginFusioninventoryNetworkequipment { get; set; }
        
        [JsonProperty("plugin_fusioninventory_package")]
        public long? PluginFusioninventoryPackage { get; set; }
        
        [JsonProperty("plugin_fusioninventory_printer")]
        public long? PluginFusioninventoryPrinter { get; set; }
        
        [JsonProperty("plugin_fusioninventory_remotecontrol")]
        public long? PluginFusioninventoryRemotecontrol { get; set; }
        
        [JsonProperty("plugin_fusioninventory_reportnetworkequipment")]
        public long? PluginFusioninventoryReportnetworkequipment { get; set; }
        
        [JsonProperty("plugin_fusioninventory_reportprinter")]
        public long? PluginFusioninventoryReportprinter { get; set; }
        
        [JsonProperty("plugin_fusioninventory_rulecollect")]
        public long? PluginFusioninventoryRulecollect { get; set; }
        
        [JsonProperty("plugin_fusioninventory_ruleentity")]
        public long? PluginFusioninventoryRuleentity { get; set; }
        
        [JsonProperty("plugin_fusioninventory_ruleimport")]
        public long? PluginFusioninventoryRuleimport { get; set; }
        
        [JsonProperty("plugin_fusioninventory_rulelocation")]
        public long? PluginFusioninventoryRulelocation { get; set; }
        
        [JsonProperty("plugin_fusioninventory_selfpackage")]
        public long? PluginFusioninventorySelfpackage { get; set; }
        
        [JsonProperty("plugin_fusioninventory_task")]
        public long? PluginFusioninventoryTask { get; set; }
        
        [JsonProperty("plugin_fusioninventory_unmanaged")]
        public long? PluginFusioninventoryUnmanaged { get; set; }
        
        [JsonProperty("plugin_fusioninventory_userinteractiontemplate")]
        public long? PluginFusioninventoryUserinteractiontemplate { get; set; }
        
        [JsonProperty("plugin_fusioninventory_wol")]
        public long? PluginFusioninventoryWol { get; set; }
        
        [JsonProperty("plugin_genericobject_dvrs")]
        public long? PluginGenericobjectDvrs { get; set; }
        
        [JsonProperty("plugin_genericobject_types")]
        public long? PluginGenericobjectTypes { get; set; }
        
        [JsonProperty("plugin_karastock_history")]
        public long? PluginKarastockHistory { get; set; }
        
        [JsonProperty("plugin_karastock_order")]
        public long? PluginKarastockOrder { get; set; }
        
        [JsonProperty("plugin_karastock_stock")]
        public long? PluginKarastockStock { get; set; }
        
        [JsonProperty("plugin_ocsinventoryng")]
        public long? PluginOcsinventoryng { get; set; }
        
        [JsonProperty("plugin_ocsinventoryng_clean")]
        public long? PluginOcsinventoryngClean { get; set; }
        
        [JsonProperty("plugin_ocsinventoryng_import")]
        public long? PluginOcsinventoryngImport { get; set; }
        
        [JsonProperty("plugin_ocsinventoryng_link")]
        public long? PluginOcsinventoryngLink { get; set; }
        
        [JsonProperty("plugin_ocsinventoryng_rule")]
        public long? PluginOcsinventoryngRule { get; set; }
        
        [JsonProperty("plugin_ocsinventoryng_sync")]
        public long? PluginOcsinventoryngSync { get; set; }
        
        [JsonProperty("plugin_ocsinventoryng_view")]
        public long? PluginOcsinventoryngView { get; set; }
        
        [JsonProperty("plugin_order_bill")]
        public long? PluginOrderBill { get; set; }
        
        [JsonProperty("plugin_order_order")]
        public long? PluginOrderOrder { get; set; }
        
        [JsonProperty("plugin_order_reference")]
        public long? PluginOrderReference { get; set; }
        
        [JsonProperty("plugin_pdf")]
        public long? PluginPdf { get; set; }
        
        [JsonProperty("plugin_printercounters")]
        public long? PluginPrintercounters { get; set; }
        
        [JsonProperty("plugin_printercounters_add_lower_records")]
        public long? PluginPrintercountersAddLowerRecords { get; set; }
        
        [JsonProperty("plugin_printercounters_snmpset")]
        public long? PluginPrintercountersSnmpset { get; set; }
        
        [JsonProperty("plugin_printercounters_update_records")]
        public long? PluginPrintercountersUpdateRecords { get; set; }
        
        [JsonProperty("plugin_processmaker_case")]
        public long? PluginProcessmakerCase { get; set; }
        
        [JsonProperty("plugin_processmaker_config")]
        public long? PluginProcessmakerConfig { get; set; }
        
        [JsonProperty("plugin_reports_applicationsbylocation")]
        public long? PluginReportsApplicationsbylocation { get; set; }
        
        [JsonProperty("plugin_reports_doublons")]
        public long? PluginReportsDoublons { get; set; }
        
        [JsonProperty("plugin_reports_equipmentbygroups")]
        public long? PluginReportsEquipmentbygroups { get; set; }
        
        [JsonProperty("plugin_reports_equipmentbylocation")]
        public long? PluginReportsEquipmentbylocation { get; set; }
        
        [JsonProperty("plugin_reports_globalhisto")]
        public long? PluginReportsGlobalhisto { get; set; }
        
        [JsonProperty("plugin_reports_histohard")]
        public long? PluginReportsHistohard { get; set; }
        
        [JsonProperty("plugin_reports_histoinst")]
        public long? PluginReportsHistoinst { get; set; }
        
        [JsonProperty("plugin_reports_infocom")]
        public long? PluginReportsInfocom { get; set; }
        
        [JsonProperty("plugin_reports_iteminstall")]
        public long? PluginReportsIteminstall { get; set; }
        
        [JsonProperty("plugin_reports_licenses")]
        public long? PluginReportsLicenses { get; set; }
        
        [JsonProperty("plugin_reports_licensesexpires")]
        public long? PluginReportsLicensesexpires { get; set; }
        
        [JsonProperty("plugin_reports_listequipmentbylocation")]
        public long? PluginReportsListequipmentbylocation { get; set; }
        
        [JsonProperty("plugin_reports_listgroups")]
        public long? PluginReportsListgroups { get; set; }
        
        [JsonProperty("plugin_reports_location")]
        public long? PluginReportsLocation { get; set; }
        
        [JsonProperty("plugin_reports_order_deliveryinfos")]
        public long? PluginReportsOrderDeliveryinfos { get; set; }
        
        [JsonProperty("plugin_reports_order_orderdelivery")]
        public long? PluginReportsOrderOrderdelivery { get; set; }
        
        [JsonProperty("plugin_reports_pcsbyentity")]
        public long? PluginReportsPcsbyentity { get; set; }
        
        [JsonProperty("plugin_reports_printers")]
        public long? PluginReportsPrinters { get; set; }
        
        [JsonProperty("plugin_reports_rules")]
        public long? PluginReportsRules { get; set; }
        
        [JsonProperty("plugin_reports_searchinfocom")]
        public long? PluginReportsSearchinfocom { get; set; }
        
        [JsonProperty("plugin_reports_softnotinstalled")]
        public long? PluginReportsSoftnotinstalled { get; set; }
        
        [JsonProperty("plugin_reports_softversioninstallations")]
        public long? PluginReportsSoftversioninstallations { get; set; }
        
        [JsonProperty("plugin_reports_statnightticketsbypriority")]
        public long? PluginReportsStatnightticketsbypriority { get; set; }
        
        [JsonProperty("plugin_reports_statticketsbyentity")]
        public long? PluginReportsStatticketsbyentity { get; set; }
        
        [JsonProperty("plugin_reports_statticketsbypriority")]
        public long? PluginReportsStatticketsbypriority { get; set; }
        
        [JsonProperty("plugin_reports_statusertask")]
        public long? PluginReportsStatusertask { get; set; }
        
        [JsonProperty("plugin_reports_transferreditems")]
        public long? PluginReportsTransferreditems { get; set; }
        
        [JsonProperty("plugin_reports_zombies")]
        public long? PluginReportsZombies { get; set; }
        
        [JsonProperty("plugin_satisfaction")]
        public long? PluginSatisfaction { get; set; }
        
        [JsonProperty("plugin_shellcommands")]
        public long? PluginShellcommands { get; set; }
        
        [JsonProperty("plugin_tasklists")]
        public long? PluginTasklists { get; set; }
        
        [JsonProperty("plugin_tasklists_config")]
        public long? PluginTasklistsConfig { get; set; }
        
        [JsonProperty("plugin_tasklists_see_all")]
        public long? PluginTasklistsSeeAll { get; set; }
        
        [JsonProperty("plugin_typology")]
        public long? PluginTypology { get; set; }
        
        [JsonProperty("plugin_vip")]
        public long? PluginVip { get; set; }
        
        [JsonProperty("plugin_webresources_resource")]
        public long? PluginWebresourcesResource { get; set; }
        
        [JsonProperty("printer")]
        public long? Printer { get; set; }
        
        [JsonProperty("problem")]
        public long? Problem { get; set; }
        
        [JsonProperty("profile")]
        public long? profile { get; set; }
        
        [JsonProperty("project")]
        public long? Project { get; set; }
        
        [JsonProperty("projecttask")]
        public long? Projecttask { get; set; }
        
        [JsonProperty("queuednotification")]
        public long? Queuednotification { get; set; }
        
        [JsonProperty("recurrentchange")]
        public long? Recurrentchange { get; set; }
        
        [JsonProperty("reminder_public")]
        public long? ReminderPublic { get; set; }
        
        [JsonProperty("reports")]
        public long? Reports { get; set; }
        
        [JsonProperty("reservation")]
        public long? Reservation { get; set; }
        
        [JsonProperty("rssfeed_public")]
        public long? RssfeedPublic { get; set; }
        
        [JsonProperty("rule_asset")]
        public long? RuleAsset { get; set; }
        
        [JsonProperty("rule_dictionnary_dropdown")]
        public long? RuleDictionnaryDropdown { get; set; }
        
        [JsonProperty("rule_dictionnary_printer")]
        public long? RuleDictionnaryPrinter { get; set; }
        
        [JsonProperty("rule_dictionnary_software")]
        public long? RuleDictionnarySoftware { get; set; }
        
        [JsonProperty("rule_import")]
        public long? RuleImport { get; set; }
        
        [JsonProperty("rule_ldap")]
        public long? RuleLdap { get; set; }
        
        [JsonProperty("rule_mailcollector")]
        public long? RuleMailcollector { get; set; }
        
        [JsonProperty("rule_softwarecategories")]
        public long? RuleSoftwarecategories { get; set; }
        
        [JsonProperty("rule_ticket")]
        public long? RuleTicket { get; set; }
        
        [JsonProperty("search_config")]
        public long? SearchConfig { get; set; }
        
        [JsonProperty("shellcommands")]
        public long? Shellcommands { get; set; }
        
        [JsonProperty("show_group_hardware")]
        public long? ShowGroupHardware { get; set; }
        
        [JsonProperty("slm")]
        public long? Slm { get; set; }
        
        [JsonProperty("software")]
        public long? Software { get; set; }
        
        [JsonProperty("solutiontemplate")]
        public long? Solutiontemplate { get; set; }
        
        [JsonProperty("state")]
        public long? State { get; set; }
        
        [JsonProperty("statistic")]
        public long? Statistic { get; set; }
        
        [JsonProperty("task")]
        public long? Task { get; set; }
        
        [JsonProperty("taskcategory")]
        public long? Taskcategory { get; set; }
        
        [JsonProperty("ticket")]
        public long? Ticket { get; set; }
        
        [JsonProperty("ticketcost")]
        public long? Ticketcost { get; set; }
        
        [JsonProperty("ticketrecurrent")]
        public long? Ticketrecurrent { get; set; }
        
        [JsonProperty("ticketvalidation")]
        public long? Ticketvalidation { get; set; }
        
        [JsonProperty("transfer")]
        public long? Transfer { get; set; }
        
        [JsonProperty("typedoc")]
        public long? Typedoc { get; set; }
        
        [JsonProperty("user")]
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
