using Newtonsoft.Json;

namespace CommonObj.Client;

public interface ISession:IEquatable<ISession>
{
    
    [JsonProperty("valid_id")]
    string IdValid { get; set; }

    [JsonProperty("glpi_currenttime")]
    DateTime? CurrentTimeString { get; set; }

    [JsonProperty("glpi_use_mode")]
    int? UseMode { get; set; }

    [JsonProperty("glpiID")]
    long? IdGlpi { get; set; }

    [JsonProperty("glpiis_ids_visible")]
    string GlpiIsIdsVisible { get; set; }

    [JsonProperty("glpifriendlyname")]
    string NameFull { get; set; }

    [JsonProperty("glpiname")]
    string NameGlpi { get; set; }

    [JsonProperty("glpirealname")]
    string NameReadl { get; set; }

    [JsonProperty("glpifirstname")]
    string NameFirst { get; set; }

    [JsonProperty("glpidefault_entity")]
    int? EntityGlpiDefault { get; set; }

    [JsonProperty("glpiextauth")]
    int? AuthGlpiExt { get; set; }

    [JsonProperty("glpiauthtype")]
    int? AuthGlpiType { get; set; }

    [JsonProperty("glpiroot")]
    string GlpiRoot { get; set; }

    [JsonProperty("glpi_plannings")]
    List<object> GlpiPlannings { get; set; }

    [JsonProperty("glpicrontimer")]
    long? GlpiCronTimer { get; set; }

    [JsonProperty("glpi_tabs")]
    List<object> GlpiTabs { get; set; }

    [JsonProperty("glpibackcreated")]
    string GlpiBackCreated { get; set; }

    [JsonProperty("glpicsv_delimiter")]
    string GlpiCsvDelimiter { get; set; }

    [JsonProperty("glpidate_format")]
    string GlpiDateFormat { get; set; }

    [JsonProperty("glpidefault_requesttypes_id")]
    string IdGlpiDefaultRequestTypes { get; set; }

    [JsonProperty("glpidisplay_count_on_home")]
    string GlpiDisplayCountHome { get; set; }

    [JsonProperty("glpiduedatecritical_color")]
    string GlpiDueDateCriticalColor { get; set; }

    [JsonProperty("glpiduedatecritical_less")]
    string GlpiDueDateCriticalLess { get; set; }

    [JsonProperty("glpiduedatecritical_unit")]
    string GlpiDueDateCriticalUnit { get; set; }

    [JsonProperty("glpiduedateok_color")]
    string GlpiDueDateOkColor { get; set; }

    [JsonProperty("glpiduedatewarning_color")]
    string GlpiDueDateWarningColor { get; set; }

    [JsonProperty("glpiduedatewarning_less")]
    string GlpiDueDateWarningLess { get; set; }

    [JsonProperty("GlpiDueDateWarningUnit")]
    string GlpiduedatewarningUnit { get; set; }

    [JsonProperty("glpifollowup_private")]
    string GlpiFollowUpPrivate { get; set; }

    [JsonProperty("glpikeep_devices_when_purging_item")]
    string GlpiKeepDevicesWhenPurgingItem { get; set; }

    [JsonProperty("glpilanguage")]
    string GlpiLanguage { get; set; }

    [JsonProperty("glpilist_limit")]
    string GlpiListLimit { get; set; }

    [JsonProperty("glpilock_autolock_mode")]
    string GlpiLockAutoLockMode { get; set; }

    [JsonProperty("glpilock_directunlock_notification")]
    string GlpiLockDirectUnlockNotification { get; set; }

    [JsonProperty("glpinames_format")]
    string GlpiNamesFormat { get; set; }

    [JsonProperty("glpinotification_to_myself")]
    string GlpiNotificationToMyself { get; set; }

    [JsonProperty("glpinumber_format")]
    string GlpiNumberFormat { get; set; }

    [JsonProperty("glpipdffont")]
    string GlpiPdfFont { get; set; }

    [JsonProperty("glpipriority_1")]
    string GlpiPriority1 { get; set; }

    [JsonProperty("glpipriority_2")]
    string GlpiPriority2 { get; set; }

    [JsonProperty("glpipriority_3")]
    string GlpiPriority3 { get; set; }

    [JsonProperty("glpipriority_4")]
    string GlpiPriority4 { get; set; }

    [JsonProperty("glpipriority_5")]
    string GlpiPriority5 { get; set; }

    [JsonProperty("glpipriority_6")]
    string GlpiPriority6 { get; set; }

    [JsonProperty("glpirefresh_views")]
    string GlpiRefreshViews { get; set; }

    [JsonProperty("glpiset_default_tech")]
    string GlpiSetDefaultTech { get; set; }

    [JsonProperty("glpiset_default_requester")]
    string GlpiSetDefaultRequester { get; set; }

    [JsonProperty("glpishow_count_on_tabs")]
    string GlpiShowCountTabs { get; set; }

    [JsonProperty("glpishow_jobs_at_login")]
    string GlpiShowJobsLogin { get; set; }

    [JsonProperty("glpitask_private")]
    string GlpiTaskPrivate { get; set; }

    [JsonProperty("glpitask_state")]
    string GlpiTaskState { get; set; }

    [JsonProperty("glpiuse_flat_dropdowntree")]
    string GlpiUseFlatDropdownTree { get; set; }

    [JsonProperty("glpilayout")]
    string GlpiLayout { get; set; }

    [JsonProperty("glpipalette")]
    string GlpiPalette { get; set; }

    [JsonProperty("glpihighcontrast_css")]
    string GlpiHighContrastCss { get; set; }

    [JsonProperty("glpidefault_dashboard_central")]
    string GlpiDefaultDashboardCentral { get; set; }

    [JsonProperty("glpidefault_dashboard_assets")]
    string GlpiDefaultDashboardAssets { get; set; }

    [JsonProperty("glpidefault_dashboard_helpdesk")]
    string GlpiDefaultDashboardHelpdesk { get; set; }

    [JsonProperty("glpidefault_dashboard_mini_ticket")]
    string GlpiDefaultDashboardMiniTicket { get; set; }

    [JsonProperty("glpi_dropdowntranslations")]
    List<object> GlpiDropdownTranslations { get; set; }

    [JsonProperty("glpipluralnumber")]
    int? GlpiPluralNumber { get; set; }
}