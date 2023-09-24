using System.Collections.ObjectModel;
using CommonObj.Base;
using CommonObj.Client;
using CommonObj.Dashboard.Common;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Administration.User
{
    public class User:Dashboard<User>
    {
        public User()
        {
            
        }

        [JsonProperty(BaseJsonProperty.PASSWORD_LAST_UPDATE)]
        public string PasswordLastUpdate { get; set; }
        
        
        /// <summary>
        /// Первый телефон
        /// </summary>
        [JsonProperty(BaseJsonProperty.PHONE)]
        public string Phone { get; set; }
        
        
        /// <summary>
        /// Второй телефон
        /// </summary>
        [JsonProperty(BaseJsonProperty.PHONE2)]
        public string Phone2 { get; set; }
        
        
        /// <summary>
        /// Мобильный телефон
        /// </summary>
        [JsonProperty(BaseJsonProperty.MOBILE)]
        public string Mobile { get; set; }
        
        
        /// <summary>
        /// Фамилия
        /// </summary>
        [JsonProperty(BaseJsonProperty.REALNAME)]
        public string Realname { get; set; }
        
        
        /// <summary>
        /// Имя + Отчество
        /// </summary>
        [JsonProperty(BaseJsonProperty.FIRSTNAME)]
        public string Firstname { get; set; }
        
        
        [JsonProperty(BaseJsonProperty.LANGUAGE)]
        public string LuseModeanguage{get;set;}
        
        [JsonProperty(BaseJsonProperty.USE_MODE)]
        public int UseMode{get;set;}
        
        [JsonProperty(BaseJsonProperty.LIST_LIMIT)]
        public object ListLimit{get;set;}
        
        
        /// <summary>
        /// Активен ли пользователь
        /// </summary>
        [JsonProperty(BaseJsonProperty.IS_ACTIVE)]
        public bool? IsActive{get;set;}
        
        
        [JsonProperty(BaseJsonProperty.AUTHS_ID)]
        public long? AuthsId{get;set;}
        
        [JsonProperty(BaseJsonProperty.AUTHTYPEL)]
        public int Authtypel{get;set;}
        
        [JsonProperty(BaseJsonProperty.LAST_LOGI)]
        public DateTime? LastLogi{get;set;}
        
        [JsonProperty(BaseJsonProperty.DATE_SYNC)]
        public DateTime? DateSync{get;set;}
        
        
        /// <summary>
        /// Id Профиль по умолчанию
        /// </summary>
        [JsonProperty(BaseJsonProperty.PROFILES_ID)]
        public long? IdProfiles{get;set;}
        
        
        /// <summary>
        /// Id Должности
        /// </summary>
        [JsonProperty(BaseJsonProperty.USERTITLES_ID)]
        public long? IdUsertitles{get;set;}
        
        
        /// <summary>
        /// Id Категории
        /// </summary>
        [JsonProperty(BaseJsonProperty.USERCATEGORIES_ID)]
        public long IdUsercategories{get;set;}
        
        
        [JsonProperty(BaseJsonProperty.DATE_FORMAT)]
        public object DateFormat{get;set;}
        
        [JsonProperty(BaseJsonProperty.NUMBER_FORMAT)]
        public object NumberFormat{get;set;}
        
        [JsonProperty(BaseJsonProperty.NAMES_FORMAT)]
        public object NamesFormat{get;set;}
        
        [JsonProperty(BaseJsonProperty.CSV_DELIMITER)]
        public object CsvDelimiter{get;set;}
        
        [JsonProperty(BaseJsonProperty.IS_IDS_VISIBLE)]
        public bool? IsIdsVisible{get;set;}
        
        [JsonProperty(BaseJsonProperty.USE_FLAT_DROPDOWNTREE)]
        public object UseFlatDropdowntree{get;set;}
        
        [JsonProperty(BaseJsonProperty.SHOW_JOBS_AT_LOGIN)]
        public object ShowJobsAtLogin{get;set;}
        
        [JsonProperty(BaseJsonProperty.PRIORITY_1)]
        public object Priority1{get;set;}
        
        [JsonProperty(BaseJsonProperty.PRIORITY_2)]
        public object Priority2{get;set;}
        
        [JsonProperty(BaseJsonProperty.PRIORITY_3)]
        public object Priority3{get;set;}
        
        [JsonProperty(BaseJsonProperty.PRIORITY_4)]
        public object Priority4{get;set;}
        
        [JsonProperty(BaseJsonProperty.PRIORITY_5)]
        public object Priority5{get;set;}
        
        [JsonProperty(BaseJsonProperty.PRIORITY_6)]
        public object Priority6{get;set;}
        
        [JsonProperty(BaseJsonProperty.FOLLOWUP_PRIVATE)]
        public object FollowupPrivate{get;set;}
        
        [JsonProperty(BaseJsonProperty.TASK_PRIVATE)]
        public object TaskPrivate{get;set;}
        
        [JsonProperty(BaseJsonProperty.DEFAULT_REQUESTTYPES_ID)]
        public long? IdDefaultRequesttypes{get;set;}
        
        [JsonProperty(BaseJsonProperty.PASSWORD_FORGET_TOKEN)]
        public DateTime? PasswordForgetToken{get;set;}
        
        [JsonProperty(BaseJsonProperty.PASSWORD_FORGET_TOKEN_DATE)]
        public DateTime? PasswordForgetTokenDate{get;set;}
        
        [JsonProperty(BaseJsonProperty.USER_DN)]
        public string UserDn{get;set;}
        
        
        /// <summary>
        /// Административный номер
        /// </summary>
        [JsonProperty(BaseJsonProperty.REGISTRATION_NUMBER)]
        public object RegistrationNumber{get;set;}
        
        
        [JsonProperty(BaseJsonProperty.SHOW_COUNT_ON_TABS)]
        public object ShowCountOnTabs{get;set;}
        
        [JsonProperty(BaseJsonProperty.REFRESH_VIEWS)]
        public object RefreshViews{get;set;}
        
        [JsonProperty(BaseJsonProperty.SET_DEFAULT_TECH)]
        public object SetDefaultTech{get;set;}
        
        [JsonProperty(BaseJsonProperty.PERSONAL_TOKEN_DATE)]
        public DateTime? PersonalTokenDate{get;set;}
        
        [JsonProperty(BaseJsonProperty.API_TOKEN_DATE)]
        public DateTime? ApiTokenDate{get;set;}
        
        [JsonProperty(BaseJsonProperty.COOKIE_TOKEN_DATE)]
        public DateTime? CookieTokenDate{get;set;}
        
        [JsonProperty(BaseJsonProperty.DISPLAY_COUNT_ON_HOME)]
        public object DisplayCountOnHome{get;set;}
        
        [JsonProperty(BaseJsonProperty.NOTIFICATION_TO_MYSELF)]
        public object NotificationToMyself{get;set;}
        
        [JsonProperty(BaseJsonProperty.DUEDATEOK_COLOR)]
        public object DuedateokColor{get;set;}
        
        [JsonProperty(BaseJsonProperty.DUEDATEWARNING_COLOR)]
        public object DuedatewarningColor{get;set;}
        
        [JsonProperty(BaseJsonProperty.DUEDATECRITICAL_COLOR)]
        public object DuedatecriticalColor{get;set;}
        
        [JsonProperty(BaseJsonProperty.DUEDATEWARNING_LESS)]
        public object DuedatewarningLess{get;set;}
        
        [JsonProperty(BaseJsonProperty.DUEDATECRITICAL_LESS)]
        public object DuedatecriticalLess{get;set;}
        
        [JsonProperty(BaseJsonProperty.DUEDATEWARNING_UNIT)]
        public object DuedatewarningUnit{get;set;}
        
        [JsonProperty(BaseJsonProperty.DUEDATECRITICAL_UNIT)]
        public object DuedatecriticalUnit{get;set;}
        
        [JsonProperty(BaseJsonProperty.DISPLAY_OPTIONS)]
        public object DisplayOptions{get;set;}
        
        [JsonProperty(BaseJsonProperty.IS_DELETED_LDAP)]
        public bool? IsDeletedLdap{get;set;}
        
        [JsonProperty(BaseJsonProperty.PDFFONT)]
        public object PdFfont{get;set;}
        
        [JsonProperty(BaseJsonProperty.PICTURE)]
        public object Picture{get;set;}
        
        [JsonProperty(BaseJsonProperty.BEGIN_DATE)]
        public DateTime? BeginDate{get;set;}
        
        [JsonProperty(BaseJsonProperty.END_DATE)]
        public DateTime? EndDate{get;set;}
        
        [JsonProperty(BaseJsonProperty.KEEP_DEVICES_WHEN_PURGING_ITEM)]
        public object KeepDevicesWhenPurgingItem{get;set;}
        
        [JsonProperty(BaseJsonProperty.PRIVATEBOOKMARKORDER)]
        public object Privatebookmarkorder{get;set;}
        
        [JsonProperty(BaseJsonProperty.BACKCREATED)]
        public object Backcreated{get;set;}
        
        [JsonProperty(BaseJsonProperty.TASK_STATE)]
        public object TaskState{get;set;}
        
        [JsonProperty(BaseJsonProperty.PALETTE)]
        public object Palette{get;set;}
        
        [JsonProperty(BaseJsonProperty.PAGE_LAYOUT)]
        public object PageLayout{get;set;}
        
        [JsonProperty(BaseJsonProperty.FOLD_MENU)]
        public object FoldMenu{get;set;}
        
        [JsonProperty(BaseJsonProperty.FOLD_SEARCH)]
        public object FoldSearch{get;set;}
        
        [JsonProperty(BaseJsonProperty.SAVEDSEARCHES_PINNED)]
        public object SavedsearchesPinned{get;set;}
        
        [JsonProperty(BaseJsonProperty.TIMELINE_ORDER)]
        public object TimelineOrder{get;set;}
        
        [JsonProperty(BaseJsonProperty.ITIL_LAYOUT)]
        public object ItilLayout{get;set;}
        
        [JsonProperty(BaseJsonProperty.RICHTEXT_LAYOUT)]
        public object RichtextLayout{get;set;}
        
        [JsonProperty(BaseJsonProperty.SET_DEFAULT_REQUESTER)]
        public object SetDefaultRequester{get;set;}
        
        [JsonProperty(BaseJsonProperty.LOCK_AUTOLOCK_MODE)]
        public object LockAutolockMode{get;set;}
        
        [JsonProperty(BaseJsonProperty.LOCK_DIRECTUNLOCK_NOTIFICATION)]
        public object LockDirectunlockNotification{get;set;}
        
        [JsonProperty(BaseJsonProperty.HIGHCONTRAST_CSS)]
        public object HighcontrastCss{get;set;}
        
        [JsonProperty(BaseJsonProperty.PLANNINGS)]
        public object Plannings{get;set;}
        
        [JsonProperty(BaseJsonProperty.SYNC_FIELD)]
        public string SyncField{get;set;}
        
        [JsonProperty(BaseJsonProperty.USERS_ID_SUPERVISOR)]
        public long? IdUserSupervisor{get;set;}
        
        /// <summary>
        /// Часовой пояс
        /// </summary>
        [JsonProperty(BaseJsonProperty.TIMEZONE)]
        public string Timezone{get;set;}
        
        [JsonProperty(BaseJsonProperty.DEFAULT_DASHBOARD_CENTRAL)]
        public object DefaultDashboardCentral{get;set;}
        
        [JsonProperty(BaseJsonProperty.DEFAULT_DASHBOARD_ASSETS)]
        public object DefaultDashboardAssets{get;set;}
        
        [JsonProperty(BaseJsonProperty.DEFAULT_DASHBOARD_HELPDESK)]
        public object DefaultDashboardHelpdesk{get;set;}
        
        [JsonProperty(BaseJsonProperty.DEFAULT_DASHBOARD_MINI_TICKET)]
        public object DefaultDashboardMiniTicket{get;set;}
        
        [JsonProperty(BaseJsonProperty.DEFAULT_CENTRAL_TAB)]
        public object DefaultCentralTab{get;set;}
        
        [JsonProperty(BaseJsonProperty.NICKNAME)]
        public string Nickname{get;set;}        
        
        [JsonIgnore]
        public UserTitle UserTitle { get; set; }
        [JsonIgnore]
        public IList<UserTitle> UserTitles { get; private set; } = new List<UserTitle>();
        
        
        [JsonIgnore]
        public AuthLdap AuthLdap { get; set; }
        [JsonIgnore]
        public IList<AuthLdap> AuthLdaps { get; private set; } = new List<AuthLdap>();
        
        [JsonIgnore]
        public UserCategory UserCategory { get; set; }
        [JsonIgnore]
        public IList<UserCategory> UserCategorys { get; private set; }
               
        [JsonIgnore]
        public Profile.Profile Profile { get; set; }
        [JsonIgnore] 
        public IList<Profile.Profile> Profiles { get; private set; } = new List<Profile.Profile>();

        [JsonIgnore]
        public List<UserEmail> Emails { get; set; } = new();

        /// <summary>
        /// Загрузка почты для пользователя
        /// </summary>
        /// <param name="clt"></param>
        /// <param name="internalTimeout"></param>
        /// <param name="cancel"></param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="Exception"></exception>
        /// <exception cref="ExceptionGLPI_ErrorCommon"></exception>
        public async Task LoadEmails(IClient clt, TimeSpan internalTimeout = default, CancellationToken cancel = default)
        {
            if (Id is null or <= 0)
                throw new ArgumentException("Id must be specified and be greater than 0");
            clt.SetHeaderDefault();           
            clt.http.Timeout = internalTimeout != default ? internalTimeout : clt.CommonTimeout;
            HttpResponseMessage response =
                await clt.http.GetAsync(string.Join("/", nameof(User), Id , nameof(UserEmail)), cancel);            
            
            string data = await response.Content.ReadAsStringAsync(cancel);
            if (response.IsSuccessStatusCode)
            {
                try
                {
                    Emails.Clear();
                    Emails.AddRange(JsonConvert.DeserializeObject<IEnumerable<UserEmail>>(data) ??
                                    Array.Empty<UserEmail>());
                }
                catch (Exception e)
                {

                    throw new Exception(e.Message);
                }
            }
            else throw new ExceptionGLPI_ErrorCommon(data, response.StatusCode);
        }
       

        //[JsonIgnore]
        //public Document_Item Document_Item { get; set; }       

        /// <summary>
        /// Получить изображение пользователя
        /// </summary>
        /// <exception cref="Exception"></exception>
        // public async Task GetPicture(IGlpiClient glpiClient, CancellationToken cancel = default,int? timeOutRequest = 200)
        // {
        //     if (glpiClient.Checker()) throw new ExceptionCheck(glpiClient);
        //     if (Id == null) throw new System.Exception("Id is null");
        //
        //     HttpResponseMessage response = null;
        //     ClientRequest clientRequest = new ClientRequest(async () => await glpiClient.Client.GetAsync($"User/{Id}/Picture", cancel), a => response = a);
        //
        //     glpiClient.QueueRequest.Enqueue(clientRequest);
        //
        //     if (timeOutRequest != null)
        //     {
        //         int timeOut = timeOutRequest > 0 ? (int)timeOutRequest : 200;
        //         while (response == null)
        //         {
        //             await Task.Delay(timeOut, cancel);
        //             if (cancel.IsCancellationRequested)
        //             {
        //                 cancel.ThrowIfCancellationRequested();
        //             }
        //         }
        //     }
        //     else
        //     {
        //         while (response == null)
        //         {                    
        //             if (cancel.IsCancellationRequested)
        //             {
        //                 cancel.ThrowIfCancellationRequested();
        //             }
        //         }
        //     }
        //
        //     if (response.IsSuccessStatusCode) return;
        //     throw new System.Exception($"status code:{response.StatusCode} content:{await response.Content.ReadAsStringAsync(cancel)}");
        // }
        //
        //
        // /// <summary>
        // /// Получить изображение пользователя
        // /// </summary>
        // /// <exception cref="Exception"></exception>
        // public async Task GetPicture(IGlpiClient glpiMulti, IGlpiClient glpiClient, CancellationToken cancel = default,int? timeOutRequest = 200)
        // {
        //     if(glpiMulti.Checker()) throw new ExceptionCheck(glpiClient);
        //     if (glpiClient.Checker()) throw new ExceptionCheck(glpiClient);
        //     if (Id == null) throw new System.Exception("Id is null");
        //
        //     HttpResponseMessage response = null;
        //     MultiRequest multiRequest =
        //         new MultiRequest(async () => await glpiClient.Client.GetAsync($"User/{Id}/Picture", cancel),
        //             a => response = a, glpiClient);
        //
        //     glpiMulti.QueueRequest.Enqueue(multiRequest);
        //
        //     if (timeOutRequest != null)
        //     {
        //         int timeOut = timeOutRequest > 0 ? (int)timeOutRequest : 200;
        //         while (response == null)
        //         {
        //             await Task.Delay(timeOut, cancel);
        //             if (cancel.IsCancellationRequested)
        //             {
        //                 cancel.ThrowIfCancellationRequested();
        //             }
        //         }
        //     }
        //     else
        //     {
        //         while (response == null)
        //         {                    
        //             if (cancel.IsCancellationRequested)
        //             {
        //                 cancel.ThrowIfCancellationRequested();
        //             }
        //         }
        //     }            
        //
        //     if (response.IsSuccessStatusCode) return;
        //     throw new System.Exception($"status code:{response.StatusCode} content:{await response.Content.ReadAsStringAsync(cancel)}");
        // }

    }
}
