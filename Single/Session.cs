using CommonObj.Client;
using Newtonsoft.Json;

namespace Single;

public class Session:ISession
{
    [JsonProperty("valid_id")]
    public string IdValid { get; set; }
    
    [JsonProperty("glpi_currenttime")]
    public DateTime? CurrentTimeString { get; set; }

    [JsonProperty("glpi_use_mode")]
    public int? UseMode { get; set; }

    [JsonProperty("glpiID")]
    public long? IdGlpi { get; set; }

    [JsonProperty("glpiis_ids_visible")]
    public string GlpiIsIdsVisible { get; set; }

    [JsonProperty("glpifriendlyname")]
    public string NameFull { get; set; }

    [JsonProperty("glpiname")]
    public string NameGlpi { get; set; }

    [JsonProperty("glpirealname")]
    public string NameReadl { get; set; }

    [JsonProperty("glpifirstname")]
    public string NameFirst { get; set; }

    [JsonProperty("glpidefault_entity")]
    public int? EntityGlpiDefault { get; set; }

    [JsonProperty("glpiextauth")]
    public int? AuthGlpiExt { get; set; }

    [JsonProperty("glpiauthtype")]
    public int? AuthGlpiType { get; set; }

    [JsonProperty("glpiroot")]
    public string GlpiRoot { get; set; }

    [JsonProperty("glpi_plannings")]
    public List<object> GlpiPlannings { get; set; }

    [JsonProperty("glpicrontimer")]
    public long? GlpiCronTimer { get; set; }

    [JsonProperty("glpi_tabs")]
    public List<object> GlpiTabs { get; set; }

    [JsonProperty("glpibackcreated")]
    public string GlpiBackCreated { get; set; }

    [JsonProperty("glpicsv_delimiter")]
    public string GlpiCsvDelimiter { get; set; }

    [JsonProperty("glpidate_format")]
    public string GlpiDateFormat { get; set; }

    [JsonProperty("glpidefault_requesttypes_id")]
    public string IdGlpiDefaultRequestTypes { get; set; }

    [JsonProperty("glpidisplay_count_on_home")]
    public string GlpiDisplayCountHome { get; set; }

    [JsonProperty("glpiduedatecritical_color")]
    public string GlpiDueDateCriticalColor { get; set; }

    [JsonProperty("glpiduedatecritical_less")]
    public string GlpiDueDateCriticalLess { get; set; }

    [JsonProperty("glpiduedatecritical_unit")]
    public string GlpiDueDateCriticalUnit { get; set; }

    [JsonProperty("glpiduedateok_color")]
    public string GlpiDueDateOkColor { get; set; }

    [JsonProperty("glpiduedatewarning_color")]
    public string GlpiDueDateWarningColor { get; set; }

    [JsonProperty("glpiduedatewarning_less")]
    public string GlpiDueDateWarningLess { get; set; }

    [JsonProperty("GlpiDueDateWarningUnit")]
    public string GlpiduedatewarningUnit { get; set; }

    [JsonProperty("glpifollowup_private")]
    public string GlpiFollowUpPrivate { get; set; }

    [JsonProperty("glpikeep_devices_when_purging_item")]
    public string GlpiKeepDevicesWhenPurgingItem { get; set; }

    [JsonProperty("glpilanguage")]
    public string GlpiLanguage { get; set; }

    [JsonProperty("glpilist_limit")]
    public string GlpiListLimit { get; set; }

    [JsonProperty("glpilock_autolock_mode")]
    public string GlpiLockAutoLockMode { get; set; }

    [JsonProperty("glpilock_directunlock_notification")]
    public string GlpiLockDirectUnlockNotification { get; set; }

    [JsonProperty("glpinames_format")]
    public string GlpiNamesFormat { get; set; }

    [JsonProperty("glpinotification_to_myself")]
    public string GlpiNotificationToMyself { get; set; }

    [JsonProperty("glpinumber_format")]
    public string GlpiNumberFormat { get; set; }

    [JsonProperty("glpipdffont")]
    public string GlpiPdfFont { get; set; }

    [JsonProperty("glpipriority_1")]
    public string GlpiPriority1 { get; set; }

    [JsonProperty("glpipriority_2")]
    public string GlpiPriority2 { get; set; }

    [JsonProperty("glpipriority_3")]
    public string GlpiPriority3 { get; set; }

    [JsonProperty("glpipriority_4")]
    public string GlpiPriority4 { get; set; }

    [JsonProperty("glpipriority_5")]
    public string GlpiPriority5 { get; set; }

    [JsonProperty("glpipriority_6")]
    public string GlpiPriority6 { get; set; }

    [JsonProperty("glpirefresh_views")]
    public string GlpiRefreshViews { get; set; }

    [JsonProperty("glpiset_default_tech")]
    public string GlpiSetDefaultTech { get; set; }

    [JsonProperty("glpiset_default_requester")]
    public string GlpiSetDefaultRequester { get; set; }

    [JsonProperty("glpishow_count_on_tabs")]
    public string GlpiShowCountTabs { get; set; }

    [JsonProperty("glpishow_jobs_at_login")]
    public string GlpiShowJobsLogin { get; set; }

    [JsonProperty("glpitask_private")]
    public string GlpiTaskPrivate { get; set; }

    [JsonProperty("glpitask_state")]
    public string GlpiTaskState { get; set; }

    [JsonProperty("glpiuse_flat_dropdowntree")]
    public string GlpiUseFlatDropdownTree { get; set; }

    [JsonProperty("glpilayout")]
    public string GlpiLayout { get; set; }

    [JsonProperty("glpipalette")]
    public string GlpiPalette { get; set; }

    [JsonProperty("glpihighcontrast_css")]
    public string GlpiHighContrastCss { get; set; }

    [JsonProperty("glpidefault_dashboard_central")]
    public string GlpiDefaultDashboardCentral { get; set; }

    [JsonProperty("glpidefault_dashboard_assets")]
    public string GlpiDefaultDashboardAssets { get; set; }

    [JsonProperty("glpidefault_dashboard_helpdesk")]
    public string GlpiDefaultDashboardHelpdesk { get; set; }

    [JsonProperty("glpidefault_dashboard_mini_ticket")]
    public string GlpiDefaultDashboardMiniTicket { get; set; }

    [JsonProperty("glpi_dropdowntranslations")]
    public List<object> GlpiDropdownTranslations { get; set; }

    [JsonProperty("glpipluralnumber")]
    public int? GlpiPluralNumber { get; set; }
    
    public override string ToString() =>
        string.Join("\n", GetType().GetProperties().Select(s => 
        {
            var t = s.PropertyType;
            string v;
            if (t.IsGenericType) 
            {
                IList<Object> val = s.GetValue(this) as IList<object> ?? new List<Object>();
                v = string.Join(", ", val);
            } 
            else v = s.GetValue(this)?.ToString() ?? "*NULL*";
            return $"{t.Name} {s.Name} = {v}";
            
        }));
    
    public bool Equals(ISession other) =>
        IdValid == other.IdValid &&
        Nullable.Equals(CurrentTimeString,
            other.CurrentTimeString) &&
        UseMode == other.UseMode &&
        IdGlpi == other.IdGlpi &&
        GlpiIsIdsVisible == other.GlpiIsIdsVisible &&
        NameFull == other.NameFull &&
        NameGlpi == other.NameGlpi &&
        NameReadl == other.NameReadl &&
        NameFirst == other.NameFirst &&
        EntityGlpiDefault == other.EntityGlpiDefault &&
        AuthGlpiExt == other.AuthGlpiExt &&
        AuthGlpiType == other.AuthGlpiType &&
        GlpiRoot == other.GlpiRoot &&
        GlpiPlannings.Equals(other.GlpiPlannings) &&
        GlpiCronTimer == other.GlpiCronTimer &&
        GlpiTabs.Equals(other.GlpiTabs) &&
        GlpiBackCreated == other.GlpiBackCreated &&
        GlpiCsvDelimiter == other.GlpiCsvDelimiter &&
        GlpiDateFormat == other.GlpiDateFormat &&
        IdGlpiDefaultRequestTypes == other.IdGlpiDefaultRequestTypes &&
        GlpiDisplayCountHome == other.GlpiDisplayCountHome &&
        GlpiDueDateCriticalColor == other.GlpiDueDateCriticalColor &&
        GlpiDueDateCriticalLess == other.GlpiDueDateCriticalLess &&
        GlpiDueDateCriticalUnit == other.GlpiDueDateCriticalUnit &&
        GlpiDueDateOkColor == other.GlpiDueDateOkColor &&
        GlpiDueDateWarningColor == other.GlpiDueDateWarningColor &&
        GlpiDueDateWarningLess == other.GlpiDueDateWarningLess &&
        GlpiduedatewarningUnit == other.GlpiduedatewarningUnit &&
        GlpiFollowUpPrivate == other.GlpiFollowUpPrivate &&
        GlpiKeepDevicesWhenPurgingItem == other.GlpiKeepDevicesWhenPurgingItem &&
        GlpiLanguage == other.GlpiLanguage &&
        GlpiListLimit == other.GlpiListLimit &&
        GlpiLockAutoLockMode == other.GlpiLockAutoLockMode &&
        GlpiLockDirectUnlockNotification == other.GlpiLockDirectUnlockNotification &&
        GlpiNamesFormat == other.GlpiNamesFormat &&
        GlpiNotificationToMyself == other.GlpiNotificationToMyself &&
        GlpiNumberFormat == other.GlpiNumberFormat &&
        GlpiPdfFont == other.GlpiPdfFont &&
        GlpiPriority1 == other.GlpiPriority1 &&
        GlpiPriority2 == other.GlpiPriority2 &&
        GlpiPriority3 == other.GlpiPriority3 &&
        GlpiPriority4 == other.GlpiPriority4 &&
        GlpiPriority5 == other.GlpiPriority5 &&
        GlpiPriority6 == other.GlpiPriority6 &&
        GlpiRefreshViews == other.GlpiRefreshViews &&
        GlpiSetDefaultTech == other.GlpiSetDefaultTech &&
        GlpiSetDefaultRequester == other.GlpiSetDefaultRequester &&
        GlpiShowCountTabs == other.GlpiShowCountTabs &&
        GlpiShowJobsLogin == other.GlpiShowJobsLogin &&
        GlpiTaskPrivate == other.GlpiTaskPrivate &&
        GlpiTaskState == other.GlpiTaskState &&
        GlpiUseFlatDropdownTree == other.GlpiUseFlatDropdownTree &&
        GlpiLayout == other.GlpiLayout &&
        GlpiPalette == other.GlpiPalette &&
        GlpiHighContrastCss == other.GlpiHighContrastCss &&
        GlpiDefaultDashboardCentral == other.GlpiDefaultDashboardCentral &&
        GlpiDefaultDashboardAssets == other.GlpiDefaultDashboardAssets &&
        GlpiDefaultDashboardHelpdesk == other.GlpiDefaultDashboardHelpdesk &&
        GlpiDefaultDashboardMiniTicket == other.GlpiDefaultDashboardMiniTicket &&
        GlpiDropdownTranslations.Equals(other.GlpiDropdownTranslations) &&
        GlpiPluralNumber == other.GlpiPluralNumber;

    protected bool Equals(Session other) => 
        Equals(other as ISession);

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == this.GetType() && Equals((Session) obj);
    }

    public override int GetHashCode()
    {
        var hashCode = new HashCode();
        hashCode.Add(IdValid);
        hashCode.Add(CurrentTimeString);
        hashCode.Add(UseMode);
        hashCode.Add(IdGlpi);
        hashCode.Add(GlpiIsIdsVisible);
        hashCode.Add(NameFull);
        hashCode.Add(NameGlpi);
        hashCode.Add(NameReadl);
        hashCode.Add(NameFirst);
        hashCode.Add(EntityGlpiDefault);
        hashCode.Add(AuthGlpiExt);
        hashCode.Add(AuthGlpiType);
        hashCode.Add(GlpiRoot);
        hashCode.Add(GlpiPlannings);
        hashCode.Add(GlpiCronTimer);
        hashCode.Add(GlpiTabs);
        hashCode.Add(GlpiBackCreated);
        hashCode.Add(GlpiCsvDelimiter);
        hashCode.Add(GlpiDateFormat);
        hashCode.Add(IdGlpiDefaultRequestTypes);
        hashCode.Add(GlpiDisplayCountHome);
        hashCode.Add(GlpiDueDateCriticalColor);
        hashCode.Add(GlpiDueDateCriticalLess);
        hashCode.Add(GlpiDueDateCriticalUnit);
        hashCode.Add(GlpiDueDateOkColor);
        hashCode.Add(GlpiDueDateWarningColor);
        hashCode.Add(GlpiDueDateWarningLess);
        hashCode.Add(GlpiduedatewarningUnit);
        hashCode.Add(GlpiFollowUpPrivate);
        hashCode.Add(GlpiKeepDevicesWhenPurgingItem);
        hashCode.Add(GlpiLanguage);
        hashCode.Add(GlpiListLimit);
        hashCode.Add(GlpiLockAutoLockMode);
        hashCode.Add(GlpiLockDirectUnlockNotification);
        hashCode.Add(GlpiNamesFormat);
        hashCode.Add(GlpiNotificationToMyself);
        hashCode.Add(GlpiNumberFormat);
        hashCode.Add(GlpiPdfFont);
        hashCode.Add(GlpiPriority1);
        hashCode.Add(GlpiPriority2);
        hashCode.Add(GlpiPriority3);
        hashCode.Add(GlpiPriority4);
        hashCode.Add(GlpiPriority5);
        hashCode.Add(GlpiPriority6);
        hashCode.Add(GlpiRefreshViews);
        hashCode.Add(GlpiSetDefaultTech);
        hashCode.Add(GlpiSetDefaultRequester);
        hashCode.Add(GlpiShowCountTabs);
        hashCode.Add(GlpiShowJobsLogin);
        hashCode.Add(GlpiTaskPrivate);
        hashCode.Add(GlpiTaskState);
        hashCode.Add(GlpiUseFlatDropdownTree);
        hashCode.Add(GlpiLayout);
        hashCode.Add(GlpiPalette);
        hashCode.Add(GlpiHighContrastCss);
        hashCode.Add(GlpiDefaultDashboardCentral);
        hashCode.Add(GlpiDefaultDashboardAssets);
        hashCode.Add(GlpiDefaultDashboardHelpdesk);
        hashCode.Add(GlpiDefaultDashboardMiniTicket);
        hashCode.Add(GlpiDropdownTranslations);
        hashCode.Add(GlpiPluralNumber);
        return hashCode.ToHashCode();
    }

    public static bool operator ==(Session? left, Session? right) => 
        Equals(left, right);

    public static bool operator !=(Session? left, Session? right) => 
        !Equals(left, right);
}