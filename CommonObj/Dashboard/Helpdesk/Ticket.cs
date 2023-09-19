using CommonObj.Base;
using CommonObj.Dashboard.Administration;
using CommonObj.Dashboard.Administration.User;
using CommonObj.Dashboard.Common;
using CommonObj.Dashboard.Helpdesk.LinkTicket;
using Newtonsoft.Json;

namespace CommonObj.Dashboard.Helpdesk
{
    public class Ticket:Dashboard<Ticket>,IEquatable<Ticket>
    {

        /// <summary>
        /// Конструктор для создания заявки (min)
        /// </summary>
        /// <param name="idLocation"></param>
        /// <param name="idCategory"></param>
        /// <param name="idType"></param>   

        public Ticket(long idLocation,long idCategory,long idType)
        {
            IdLocation = idLocation;
            ItilCategoriesId = idCategory;
            Type = idType;              
        }

        public Ticket()
        {
            
        }

        /// <summary>
        /// Дата создания
        /// </summary>
        [JsonProperty(BaseJsonProperty.DATE)]
        public DateTime? Date { get; set; }

        /// <summary>1
        /// Дата закрытия
        /// </summary>
        [JsonProperty(BaseJsonProperty.CLOSEDATE)]
        public DateTime? CloseDate { get; set; }

        [JsonProperty(BaseJsonProperty.SOLVEDATE)]
        public DateTime? SolveDate { get; set; }

        /// <summary>
        /// Статус заявки
        /// </summary>
        [JsonProperty(BaseJsonProperty.STATUS)]
        public EStatus Status { get; set; }

        /// <summary>
        /// Крайний редактор
        /// </summary>
        [JsonProperty(BaseJsonProperty.USERS_ID_LASTUPDATER)]
        public long? UsersIdLastUpdater { get; set; }

        /// <summary>
        /// Исполнитель заявки
        /// </summary>
        [JsonProperty(BaseJsonProperty.USERS_ID_RECIPIENT)]
        public long? UsersIdRecipient { get; set; }


        [JsonProperty(BaseJsonProperty.REQUESTTYPES_ID)]
        public long? RequestTypesId { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        [JsonProperty(BaseJsonProperty.CONTENT)]
        public string Content { get; set; }

        [JsonProperty(BaseJsonProperty.URGENCY)]
        public long? Urgency { get; set; }

        [JsonProperty(BaseJsonProperty.IMPACT)]
        public long? Impact { get; set; }

        /// <summary>
        /// Приоритет заявки
        /// </summary>
        [JsonProperty(BaseJsonProperty.PRIORITY)]
        public long? Priority { get; set; }

        [JsonProperty(BaseJsonProperty.ITILCATEGORIES_ID)]
        public long? ItilCategoriesId { get; set; }

        [JsonProperty(BaseJsonProperty.TYPE)]
        public long? Type { get; set; }

        [JsonProperty(BaseJsonProperty.GLOBAL_VALIDATION)]
        public long? GlobalValidation { get; set; }

        [JsonProperty(BaseJsonProperty.SLAS_ID_TTR)]
        public long? SlAsIdTtr { get; set; }

        [JsonProperty(BaseJsonProperty.SLAS_ID_TTO)]
        public long? SlAsIdTto { get; set; }

        [JsonProperty(BaseJsonProperty.SLALEVELS_ID_TTR)]
        public long? SlaLevelsIdTtr { get; set; }

        [JsonProperty(BaseJsonProperty.TIME_TO_RESOLVE)]
        public DateTime? TimeToResolve { get; set; }

        [JsonProperty(BaseJsonProperty.TIME_TO_OWN)]
        public DateTime? TimeToOwn { get; set; }

        [JsonProperty(BaseJsonProperty.BEGIN_WAITING_DATE)]
        public DateTime? BeginWaitingDate { get; set; }

        [JsonProperty(BaseJsonProperty.SLA_WAITING_DURATION)]
        public long? SlaWaitingDuration { get; set; }

        [JsonProperty(BaseJsonProperty.OLA_WAITING_DURATION)]
        public long? OlaWaitingDuration { get; set; }

        [JsonProperty(BaseJsonProperty.OLAS_ID_TTO)]
        public long? OlasIdTto { get; set; }

        [JsonProperty(BaseJsonProperty.OLAS_ID_TTR)]
        public long? OlasIdTtr { get; set; }

        [JsonProperty(BaseJsonProperty.OLALEVELS_ID_TTR)]
        public long? OlaLevelsIdTtr { get; set; }

        [JsonProperty(BaseJsonProperty.OLA_TTR_BEGIN_DATE)]
        public DateTime? OlaTtrBeginDate { get; set; }

        [JsonProperty(BaseJsonProperty.INTERNAL_TIME_TO_RESOLVE)]
        public DateTime? InternalTimeToResolve { get; set; }

        [JsonProperty(BaseJsonProperty.INTERNAL_TIME_TO_OWN)]
        public DateTime? InternalTimeToOwn { get; set; }

        [JsonProperty(BaseJsonProperty.WAITING_DURATION)]
        public long? WaitingDuration { get; set; }

        [JsonProperty(BaseJsonProperty.CLOSE_DELAY_STAT)]
        public long? CloseDelayStat { get; set; }

        [JsonProperty(BaseJsonProperty.SOLVE_DELAY_STAT)]
        public long? SolveDelayStat { get; set; }

        [JsonProperty(BaseJsonProperty.TAKEINTOACCOUNT_DELAY_STAT)]
        public long? TakeIntoAccountDelayStat { get; set; }

        [JsonProperty(BaseJsonProperty.ACTIONTIME)]
        public long? ActionTime { get; set; }

        [JsonProperty(BaseJsonProperty.VALIDATION_PERCENT)]
        public long? ValidationPercent { get; set; }

        // /// <summary>
        // /// User recipient
        // /// </summary>
        // [JsonIgnore,NoLink]
        // public User UserRecipient { get;  set; }
        
        [JsonIgnore]
        public RequestType RequestType { get;  set; }
        
        [JsonIgnore]
        public ITILCategory ITILCategory { get; set; }        
        
        // [JsonIgnore]
        // public DocumentItem Document_Item { get; set; }
        
        [JsonIgnore]
        public List<TicketTask> TicketTasks { get;  set;}
        
        [JsonIgnore]
        public List<TicketValidation> TicketValidation { get;  set;}
        
        [JsonIgnore]
        public List<TicketCost> TicketCost { get;  set;}
        
        [JsonIgnore]
        public List<ProblemTicket> Problem_Ticket { get; set; }
        
        [JsonIgnore]
        public List<ChangeTicket> Change_Ticket { get;  set;}
        
        [JsonIgnore]
        public List<ItemTicket> Item_Ticket { get;  set;}
        
        /// <summary>
        /// Список сообщений, который оставил под статусом решенных
        /// </summary>
        [JsonIgnore]
        public List<ITILSolution> ITILSolution { get;  set;}
        
        [JsonIgnore]
        public List<ITILFollowup> ITILFollowup { get;  set;}
        
        [JsonIgnore]
        public List<TicketUser> Ticket_User { get;  set;}
        
        [JsonIgnore]
        public List<GroupTicket> Group_Ticket { get;  set;}
        
        [JsonIgnore]
        public List<SupplierTicket> Supplier_Ticket { get;  set;}
        

        // /// <summary>
        // /// Loader other property
        // /// </summary>
        // /// <param name="glpi"></param>
        // /// <param name="cancel"></param>
        // /// <exception cref="ExceptionCheck"></exception>
        // public async Task Load(Glpi glpi,CancellationToken cancel = default)
        // {
        //     if (Check(glpi)) throw new ExceptionCheck(glpi);
        //     if (UsersIdRecipient > 0)
        //         UserRecipient = await User.GetAsync(glpi, new Parameter() { id = UsersIdRecipient }, cancel);
        //
        //     var properties = GetType()
        //         .GetProperties()
        //         .Where(w =>
        //             w.CustomAttributes
        //                 .Select(s => s.AttributeType.Name)
        //                 .Contains(nameof(JsonIgnoreAttribute)) &&
        //                 w.Name != "UserRecipient" &&
        //                 (
        //                     w.PropertyType == typeof(long) &&
        //                     (long)w.GetValue(this) > 0) ||
        //                     w.GetValue(this) != null);
        //
        //     foreach (var property in properties)
        //     {
        //         Link linkProperty = Links.FirstOrDefault(f => f.Rel == property.Name);
        //         if(linkProperty == null) continue;
        //         string endPoint = string.Join("",
        //             linkProperty.Address.Segments.Except(glpi.Client.BaseAddress!.Segments));
        //         
        //         HttpResponseMessage response = null;
        //
        //
        //         ClientRequest request = new ClientRequest(async () => await glpi.Client.GetAsync(endPoint, cancel),
        //             a => response = a);
        //
        //         glpi.QueueRequest.Enqueue(request);
        //         
        //         while (response == null)
        //         {
        //             if(cancel.IsCancellationRequested) cancel.ThrowIfCancellationRequested();
        //         }
        //
        //         if (response.IsSuccessStatusCode) 
        //             property.SetValue(this,
        //                               JsonConvert.DeserializeObject(await response.Content.ReadAsStringAsync(cancel),
        //                                                             property.PropertyType));                    
        //     }
        // }

        public enum EStatus
        {
            New = 1,
            InWork = 2,
            InProgress = 3,
            Await = 4,
            Resolved = 5,
            Close = 6
        }
        
        public enum ESearchField
        {
            name = 1,
            id = 2,
            priority = 3,
            ITILCategory_completename = 7,
            Ticket_RequestType_name = 9,
            urgency = 10,
            impact = 11,
            status = 12,
            Ticket_Item_Ticket_items_id = 13,
            Ticket_type = 14,
            date = 15,
            closedate = 16,
            solvedate = 17,
            Ticket_time_to_resolve = 18,
            date_mod = 19,
            content = 21,
            actiontime = 45,
            Ticket_users_id_lastupdater_User_name = 64,
            Entity_completename = 80,
            is_late = 82,
            Ticket_Location_completename = 83,
            Ticket_Location_building = 84, //Last
            Ticket_Location_address = 101,
            Ticket_Location_postcode = 102,
            Ticket_Location_town = 103,
            Ticket_Location_state = 104,
            Ticket_Location_country = 105,
            Ticket_Item_Ticket_itemtype = 131,
            Ticket_Document_Item_Document_name = 142,
            Ticket_time_to_resolve_progress = 151,
            Ticket_time_to_own = 155,
            Ticket_time_to_own_progress = 158,
            Ticket_is_late_159 = 159,
            Ticket_internal_time_to_resolve = 180,
            Ticket_internal_time_to_resolve_progress = 181,
            Ticket_is_late_182 = 182,
            Ticket_internal_time_to_own = 185,
            Ticket_internal_time_to_own_progress = 186,
            Ticket_is_late = 187,
            Ticket_next_escalation_level = 188,
            Ticket_PendingReason_Item_PendingReason_name = 400
            
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public virtual string TranlateEStatus(EStatus status) => status switch
        {
            EStatus.New => "Новый",
            EStatus.InWork => "В работе (назначена)",
            EStatus.InProgress => "В работе (Запланирована)",
            EStatus.Await => "Ожидание",
            EStatus.Resolved => "Решена",
            EStatus.Close => "Закрыта",
            _ => throw new NotImplementedException(),
        };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public virtual EStatus ConverterEStatus(string text) => text switch
        {
            "Новый" => EStatus.New,
            "В работе (назначена)" => EStatus.InWork,
            "В работе (Запланирована)" => EStatus.InProgress,
            "Ожидание" => EStatus.Await,
            "Решена" => EStatus.Resolved,
            "Закрыта" => EStatus.Close,
            _ => throw new NotImplementedException(),
        };


        public bool Equals(Ticket other) =>
            other != null && GetHashCode() == other.GetHashCode();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="glpiClientram>
        /// <param name="cancel"></param>
        /// <returns></returns>
        /// <exception cref="ExceptionCheck"></exception>
        /// <exception cref="Exception"></exception>
        // public async Task<string> GetDocumentItem(IGlpiClient glpiClient,CancellationToken cancel = default)
        // {
        //     if (glpiClient.Checker()) throw new ExceptionCheck(glpiClient);
        //     Link link = Links.FirstOrDefault(f => f.Rel == "TicketValidation");
        //
        //     if (link == null) throw new System.Exception("Object Link is null");
        //     StringBuilder sb = new StringBuilder();
        //     foreach (var item in Links.Skip(5))
        //     {
        //         HttpResponseMessage response = null;
        //         ClientRequest clientRequest = new ClientRequest(async () => await glpiClient.Client.GetAsync($"{nameof(Ticket)}/{Id}/{item.Rel}", cancel), a => response = a);
        //         glpiClient.QueueRequest.Enqueue(clientRequest);
        //         while (response == null)
        //         {
        //             if (cancel.IsCancellationRequested) cancel.ThrowIfCancellationRequested();
        //         }
        //
        //         if (response.IsSuccessStatusCode) sb.Append(await response.Content.ReadAsStringAsync(cancel));
        //         else
        //             throw new System.Exception(
        //                 $"Status code:{response.StatusCode}\nContext:{response.Content.ReadAsStringAsync(cancel)}");
        //     }
        //
        //     return sb.ToString();            
        // }

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
            hash.Add(IdGroup);
            hash.Add(Date);
            hash.Add(CloseDate);
            hash.Add(SolveDate);
            hash.Add(Status);
            hash.Add(UsersIdLastUpdater);
            hash.Add(UsersIdRecipient);
            hash.Add(RequestTypesId);
            hash.Add(Content);
            hash.Add(Urgency);
            hash.Add(Impact);
            hash.Add(Priority);
            hash.Add(ItilCategoriesId);
            hash.Add(Type);
            hash.Add(GlobalValidation);
            hash.Add(SlAsIdTtr);
            hash.Add(SlAsIdTto);
            hash.Add(SlaLevelsIdTtr);
            hash.Add(TimeToResolve);
            hash.Add(TimeToOwn);
            hash.Add(BeginWaitingDate);
            hash.Add(SlaWaitingDuration);
            hash.Add(OlaWaitingDuration);
            hash.Add(OlasIdTto);
            hash.Add(OlasIdTtr);
            hash.Add(OlaLevelsIdTtr);
            hash.Add(OlaTtrBeginDate);
            hash.Add(InternalTimeToResolve);
            hash.Add(InternalTimeToOwn);
            hash.Add(WaitingDuration);
            hash.Add(CloseDelayStat);
            hash.Add(SolveDelayStat);
            hash.Add(TakeIntoAccountDelayStat);
            hash.Add(ActionTime);
            hash.Add(ValidationPercent);
            return hash.ToHashCode();
        }

        public override string ToString() =>
            Id.ToString();
    }
}
