using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using CommonObj.Base;
using CommonObj.Client;
using CommonObj.Dashboard.Administration;
using CommonObj.Dashboard.Administration.User;
using CommonObj.Dashboard.Assets.LinkComputer;
using CommonObj.Dashboard.Search;
using Newtonsoft.Json;
using static CommonObj.Base.BaseResource;
using Range = CommonObj.Dashboard.Search.Range;
using SearchOption = CommonObj.Dashboard.Search.SearchOption;

namespace CommonObj.Dashboard.Common
{
    public abstract class Dashboard<TD>:IDashboard,IComparable<TD> where TD: class, IDashboard
    {
        [JsonProperty(BaseJsonProperty.ID)]
        public long? Id { get; set; }

        [JsonProperty(BaseJsonProperty.ENTITIES_ID)]
        public long? IdEntity
        {
            get => _idEntity;
            set
            {
                if (value == _idEntity) return;
                _idEntity = value;
                Change();
            }
        }

        private long? _idEntity;

        [JsonProperty(BaseJsonProperty.IS_RECURSIVE)]
        public bool? IsRecursive
        {
            get => _isRecursive;
            set
            {
                if (value == _isRecursive) return;
                _isRecursive = value;
                Change();
            }
        }

        private bool? _isRecursive;

        [JsonProperty(BaseJsonProperty.NAME)]
        public string Name
        {
            get => _name;
            set
            {
                if (value == _name) return;
                _name = value;
                Change();
            }
        }

        private string _name;

        [JsonProperty(BaseJsonProperty.COMMENT)]
        public string Comment
        {
            get => _comment;
            set
            {
                if (value == _comment) return;
                _comment = value;
                Change();
            }
        }

        private string _comment;
        
        [JsonProperty(BaseJsonProperty.LOCATIONS_ID)]
        public long? IdLocation
        {
            get => _idLocation;
            set
            {
                if (value == _idLocation) return;
                _idLocation = value;
                Change();
            }
        }

        private long? _idLocation;


        [JsonProperty(BaseJsonProperty.USERS_ID_TECH)]
        public long? IdUsersTech
        {
            get =>_idUsersTech;
            set
            {
                if (value == _idUsersTech) return;
                _idUsersTech = value;
                Change();
            }
        }

        private long? _idUsersTech;

        [JsonProperty(BaseJsonProperty.GROUPS_ID_TECH)]
        public long? IdGroupsTech
        {
            get=>_idGroupsTech;
            set
            {
                if (value == _idGroupsTech) return;
                _idGroupsTech = value;
                Change();
            }
        }

        private long? _idGroupsTech;

        [JsonProperty(BaseJsonProperty.MANUFACTURERS_ID)]
        public long? IdManufacturer
        {
            get => _idManufacturer;
            set
            {
                if (value == _idManufacturer) return;
                _idManufacturer = value;
                Change();
            }
         }
        
        private long? _idManufacturer;

        [JsonProperty(BaseJsonProperty.IS_DELETED)]
        public bool? IsDeleted
        {
            get => _isDeleted;
            set
            {
                if (value == _isDeleted) return;
                _isDeleted = value;
                Change();
            }
         }
        
        private bool? _isDeleted;

        [JsonProperty(BaseJsonProperty.IS_TEMPLATE)]
        public bool? IsTemplate 
        { 
            get =>_isTemplate;
            set
            {
                if (value == _isTemplate) return;
                _isTemplate = value;
                Change();
            }
         }
        
        private bool? _isTemplate;

        [JsonProperty(BaseJsonProperty.TEMPLATE_NAME)]
        public string TemplateName
        {
            get => _templateName;
            set
            {
                if (value == _templateName) return;
                _templateName = value;
                Change();
            }
         }
        
        private string _templateName;

        [JsonProperty(BaseJsonProperty.DATE_MOD)]
        public DateTime? DateMod
        {
            get => _dateMod;
            set
            {
                if (value == _dateMod) return;
                _dateMod = value;
                Change();
            }
         }
        
        private DateTime? _dateMod;

        [JsonProperty(BaseJsonProperty.USERS_ID)]
        public long? IdUser
        {
            get => _idUser;
            set
            {
                if (value == _idUser) return;
                _idUser = value;
                Change();
            }
         }
        
        private long? _idUser;

        [JsonProperty(BaseJsonProperty.GROUPS_ID)]
        public long? IdGroup
        {
            get => _idGroup;
            set
            {
                if (value == _idGroup) return;
                _idGroup = value;
                Change();
            }
         }
        
        private long? _idGroup;

        [JsonProperty(BaseJsonProperty.TICKET_TCO)]
        public double? TicketTco
        {
            get => _ticketTco;
            set
            {
                if (value == _ticketTco) return;
                _ticketTco = value;
                Change();
            }
         }
        
        private double? _ticketTco;

        [JsonProperty(BaseJsonProperty.DATE_CREATION)]
        public DateTime? DateCreation
        {
            get => _dateCreation;
            set
            {
                if (value == _dateCreation) return;
                _dateCreation = value;
                Change();
            }
         }
        
        private DateTime? _dateCreation;

        [JsonProperty(BaseJsonProperty.LINKS)]
        public List<Link> Links { get; set; }

        [JsonIgnore]
        public User User { get; set; }
        [JsonIgnore]
        public IList<User> Users { get; private set; } = new List<User>();
        
        [JsonIgnore]
        public Group Group { get; set; }
        [JsonIgnore]
        public IList<Group> Groups { get; private set; }        
                
        public Manufacturer Manufacturer { get; set; }
        public IList<Manufacturer> Manufacturers { get; private set; }
        
        [JsonIgnore]
        public Location Location { get; set; }
        [JsonIgnore]
        public IList<Location> Locations { get; private set; }
        
        [JsonIgnore]
        public Entity Entity { get; set; }
        [JsonIgnore]
        public IList<Entity> Entitys { get; private set; } = new List<Entity>();

        [JsonIgnore]
        public IEnumerable<ModifiedObj> ChangeProperty { get; }
        [JsonIgnore]
        private IList<ModifiedObj?> _modifiedObjs = new List<ModifiedObj?>();
        
        public ModifiedObj? Add(string variableName, object newValue)
        {
            var findValue = _modifiedObjs.FirstOrDefault(f => f.VariableName == variableName);
            if (findValue == null) return null;
            findValue.History.Add(newValue);
            return findValue;
        }

        public ModifiedObj? Add(string variableName, object initialValue, object newValue)
        {
            if (_modifiedObjs.Select(s => s.VariableName).Contains(variableName)) return null;
            ModifiedObj modifiedObj = new ModifiedObj(variableName, initialValue);
            modifiedObj.History.Add(newValue);
            _modifiedObjs.Add(modifiedObj);
            return modifiedObj;

        }

        public ModifiedObj? DelHistory(string variableName)
        {
            var findValue = _modifiedObjs.FirstOrDefault(f => f.VariableName == variableName);
            if (findValue == null) return null;
            findValue.History.RemoveAt(findValue.History.Count - 1);
            return findValue;
        }

        public void CancelChanges()
        {
            foreach (ModifiedObj obj in _modifiedObjs.Where(w => !string.IsNullOrWhiteSpace(w.VariableName))) 
                GetType().GetProperty(obj.VariableName).SetValue(this, obj.InitialValue);
            _modifiedObjs.Clear();
        }


        public void Change([CallerMemberName] string str = "")
        {
            // PropertyInfo pr = GetType().GetProperty(str);
            // if(pr == null) return;
            //
            // string propertyName = pr.GetCustomAttribute<JsonPropertyAttribute>()?.PropertyName;
            // if (string.IsNullOrEmpty(propertyName)) 
            //     throw new System.Exception("Свойство должено содержать атрибут Newton.Json" +
            //                                " JsonPropertyAttribute и поле name не должно быть пустым");
            // object value = pr.GetValue(this);
            //
            // if (ChangeProperty.ContainsKey(propertyName)) ChangeProperty[propertyName] = value ?? "";
            // else ChangeProperty.Add(propertyName, value ?? "");
        }

        //#region Single

        public static async Task<IEnumerable<SearchOption>> ListSearchOptionsAsync(
            IClient clt,
            CancellationToken cancel = default)
        {             
            clt.SetHeaderDefault();
            
            HttpResponseMessage response =
                await clt.http.GetAsync(string.Join("/", value: new[] { LIST_SEARCH_OPTIONS, typeof(TD).Name }), cancel);            

            string responseData = await response.Content.ReadAsStringAsync(cancel);

            return response.IsSuccessStatusCode
                ? SearchOption.Parse(JsonConvert.DeserializeObject<Dictionary<string, object>>(responseData)?? new Dictionary<string, object>())
                : throw new ExceptionGLPI_ErrorCommon(responseData, response.StatusCode);
        }
        
        /// <summary>
        /// Получить объект D в формате JSON
        /// </summary>
        /// <param name="clt">подключенный объект к GLPI</param>
        /// <param name="parameter">Параметры запроса</param>
        /// <param name="cancel">Принудительная остановка процесса</param>
        /// <returns></returns>
        /// <exception cref="ExceptionGLPI_ErrorCommon"></exception>
        public static async Task<string> GetJsonAsync(
            IClient clt,
            Parameter parameter,
            CancellationToken cancel = default)
        {            
            clt.SetHeaderDefault();           

            HttpResponseMessage response = await clt.http.GetAsync(string.Join(string.Empty, typeof(TD).Name, parameter), cancel);
            
            string responseData = await response.Content.ReadAsStringAsync(cancel);

            return response.IsSuccessStatusCode
                ? responseData
                : throw new ExceptionGLPI_ErrorCommon(responseData, response.StatusCode);
        }
        
        /// <summary>
        /// Получить объект типа TD
        /// </summary>
        /// <param name="clt">Основное подключение к glpi</param>
        /// <param name="parameter">Параметры поиска</param>
        /// <param name="cancel">Принудительная остановка процесса</param>
        /// <exception cref="Exception"></exception>
        public static async Task<TD?> GetAsync(
            IClient clt,
            Parameter parameter,
            CancellationToken cancel = default)
        {
                     
            clt.SetHeaderDefault();            
            
            if (parameter?.id is null or < 0) throw new System.Exception("Error parameter. Id eq = null or < 0");
            return JsonConvert.DeserializeObject<TD>(await GetJsonAsync(clt, parameter, cancel));
        }        
        
        /// <summary>
        /// Получить список объектов D
        /// </summary>
        /// <param name="clt">Основное подключение к glpi</param>
        /// <param name="cancel">Принудительная остановка процесса</param>
        /// <returns></returns>
        /// <exception cref="ExceptionGLPI_ErrorCommon"></exception>
        public static async Task<IEnumerable<TD>?> GetEnumerableAsync(
            IClient clt,
            CancellationToken cancel = default)
        {
            clt.SetHeaderDefault();

            HttpResponseMessage responsEnd = await clt.http.GetAsync(string.Join(string.Empty, typeof(TD).Name,
                new Parameter { order = Parameter.EOrder.DESC }), cancel);

            string endListType = await responsEnd.Content.ReadAsStringAsync(cancel);

            IEnumerable<TD>? end = responsEnd.IsSuccessStatusCode
                ? JsonConvert.DeserializeObject<List<TD>>(endListType)
                : throw new ExceptionGLPI_ErrorCommon(endListType, responsEnd.StatusCode);

            HttpResponseMessage responseStart = await clt.http.GetAsync(string.Join(string.Empty, typeof(TD).Name,
                new Parameter { range = new Range(0, !end.Any() ? 50 : end?.Reverse()?.Last()?.Id ?? 50) }), cancel);
        
            string startListType = await responseStart.Content.ReadAsStringAsync(cancel);
            
            return responseStart.IsSuccessStatusCode
                ? JsonConvert.DeserializeObject<List<TD>>(startListType)
                : throw new ExceptionGLPI_ErrorCommon(startListType, responseStart.StatusCode);        
        }

        public static async Task<string> LoadFromUri(IClient clt, string endPoint, CancellationToken cancel = default)
        {
            clt.SetHeaderDefault();

            HttpResponseMessage responsEnd = await clt.http.GetAsync(endPoint, cancel);
            return await responsEnd.Content.ReadAsStringAsync(cancel);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="clt"></param>
        /// <param name="loadLink"></param>
        /// <param name="links"></param>
        /// <param name="cancel"></param>
        /// <returns></returns>
        public async Task LoadLinks(
            IClient clt,
            ELoadLink loadLink,
            Func<IEnumerable<Link>,IEnumerable<Link>> links,
            CancellationToken cancel = default)
        {
            if (Links.Count == 0) return;
            IEnumerable<Link> lks;//список адресов, которые будут загружены
            if (loadLink == ELoadLink.BlackList)
                lks = Links.Except(links.Invoke(Links));
            lks = links.Invoke(Links);

            clt.SetHeaderDefault();

            HttpResponseMessage response;
            string data;
            
            foreach (var lk in lks.GroupBy(gb=>gb.Rel))//групперованные списки (по име)
            {                
                /*Поиск класса для записи.
                 Сюда будет записанн только та ссылка
                 у которой есть свой id в переменной Id{PropertyName}*/
                var singleVal = GetType().GetProperty(lk.Key);
                
                /*Поиск cписка в которые будут записаны те объекты
                 у которых Id != Id{PropertyName}*/
                var collectVal = GetType().GetProperty(string.Join(string.Empty, lk.Key, COLLECT_IDENTIFIER));
                
                if (singleVal == null && collectVal == null) continue;

                var objects = (IList) collectVal.GetValue(this, null);
                
                foreach (Link link in lk)
                {
                    response = await clt.http.GetAsync(clt.ExceptUri(link.Address), cancel);
                    data = await response.Content.ReadAsStringAsync(cancel);
                    if (response.IsSuccessStatusCode)
                    {
                        if (singleVal == null) singleVal = GetType().GetProperty(lk.Key, BindingFlags.NonPublic);
                        var loadCollectVal = JsonConvert.DeserializeObject(data, singleVal.PropertyType);
                        
                        /*Поиск свойства в котором есть Id{PropertyName}*/
                        var valId = GetType().GetProperty(string.Join(string.Empty, BaseJsonProperty.Id, lk.Key));
                        if (valId == null)
                            objects.Add(loadCollectVal);
                        else
                        {
                            long? thisValId = (long?) valId.GetValue(this);
                            long? loadValId = ((IDashboard) loadCollectVal).Id;

                            if (thisValId.Equals(loadValId))
                                singleVal.SetValue(this, loadCollectVal);
                            else objects.Add(loadCollectVal);
                        }
                    }                            
                    else throw new ExceptionGLPI_ErrorCommon(data, response.StatusCode);
                }                              
            }
        }

        // /// <summary>
        // /// Загружает объекты с атрибутом BaseEntity
        // /// </summary>
        // /// <param name="clt"></param>
        // /// <param name="cancel"></param>
        // /// <exception cref="ExceptionCheck"></exception>
        // public virtual async Task LoadBaseEntity(
        //     IGlpiClient clt, 
        //     CancellationToken cancel = default)
        // {
        //     if (clt.Checker())      throw new ExceptionCheck(clt);
        //     if (clt.IsClone)        throw new System.Exception("Объект не должен быть клоном");
        //     
        //     IGlpiClient client = (IGlpiClient)clt.Clone();
        //     client.SetHeaderDefault();
        //
        //     int iteration = 0;            
        //     List<ClientResponse> responseMessages = new List<ClientResponse>();            
        //
        //     foreach (var entity in GetType().GetProperties()
        //                  .Where(w => w.GetCustomAttributes(typeof(BaseEntityAttribute), true).Any()))
        //     {
        //         long? id = (long?)GetType()
        //             .GetProperty(string.Join("", "Id", entity.Name))
        //             ?.GetValue(this);
        //
        //         if (id == null) continue;
        //
        //         clt.QueueRequest.Enqueue(
        //             new ClientRequest(
        //                 async () => await client.Client.GetAsync(string.Join("/", entity.Name, id), cancel),
        //                 response => responseMessages.Add(response), null, entity));
        //         
        //         iteration++;
        //     }
        //     
        //     var timeSpan = DateTime.Now + TimeSpan.FromSeconds(client.TimeOut);            
        //     
        //     while (responseMessages.Count != iteration) 
        //     {                
        //         if (cancel.IsCancellationRequested)                
        //             cancel.ThrowIfCancellationRequested();                
        //
        //         if (timeSpan < DateTime.Now) 
        //             throw new TimeoutException("Привышено время ожидания ответа от сервера!");
        //     }
        //    
        //
        //     foreach (ClientResponse response in responseMessages
        //                  .Where(w => w.Response.IsSuccessStatusCode))
        //         response
        //             .RequestedProperty
        //             .SetValue(this,
        //                 JsonConvert.DeserializeObject(await response.Response.Content.ReadAsStringAsync(cancel),
        //                     response.RequestedProperty.PropertyType));
        // }
        
        
        //
        // /// <summary>
        // /// Поиск объектов типа D
        // /// </summary>
        // /// <param name="clt"></param>
        // /// <param name="criterias"></param>
        // /// <param name="parameter"></param>
        // /// <param name="cancel"></param>
        // /// <returns></returns>
        // /// <exception cref="ExceptionCheck"></exception>
        // /// <exception cref="Exception"></exception>
        // /// <exception cref="TimeoutException"></exception>
        // public static async Task<ResponseSearch> GetAsync(
        //     IGlpiClient clt,
        //     IEnumerable<Criteria> criterias,
        //     Parameter parameter = null, 
        //     CancellationToken cancel = default)
        // {
        //     if (clt.Checker())      throw new ExceptionCheck(clt);
        //     if (clt.IsClone)        throw new System.Exception("Объект не должен быть клоном");
        //     
        //     IGlpiClient client = (IGlpiClient)clt.Clone();
        //     client.SetHeaderDefault();
        //     
        //     HttpResponseMessage response = null;
        //     ClientRequest clientRequest;
        //
        //
        //     if (parameter == null)
        //         clientRequest = new ClientRequest(
        //             async () => await client.Client.GetAsync($"search" +
        //                                                      $"/{typeof(TD).Name}" +
        //                                                      $"?{Criteria.GetUri(criterias)}",
        //                 cancel),
        //             a => response = a.Response);
        //     else
        //         clientRequest = new ClientRequest(
        //             async () => await client.Client.GetAsync(
        //                 $"search/{typeof(TD).Name}?{Criteria.GetUri(criterias)}&{parameter}", cancel),
        //             a => response = a.Response);
        //
        //     clt.QueueRequest.Enqueue(clientRequest);
        //
        //     var timeSpan = DateTime.Now + TimeSpan.FromSeconds(client.TimeOut);            
        //     
        //     while (response == null) 
        //     {                
        //         if (cancel.IsCancellationRequested)                
        //             cancel.ThrowIfCancellationRequested();                
        //
        //         if (timeSpan < DateTime.Now) 
        //             throw new TimeoutException("Привышено время ожидания ответа от сервера!");
        //     }
        //
        //     ResponseSearch seatchStart;
        //     ResponseSearch seatchEnd;
        //
        //     if (!response.IsSuccessStatusCode)
        //         throw new System.Exception(
        //             $"Status code:{response.StatusCode} " +
        //             $"content?:{await response.Content.ReadAsStringAsync(cancel)}");
        //     {
        //         seatchStart = 
        //             JsonConvert
        //                 .DeserializeObject<ResponseSearch>(await response.Content.ReadAsStringAsync(cancel));
        //         
        //         if (seatchStart == null || seatchStart.Count >= seatchStart.TotalCount) return seatchStart;
        //         HttpResponseMessage responseSearchEnd = null;
        //         if (parameter == null)
        //             clt.QueueRequest.Enqueue(new ClientRequest(
        //                 async () => await client.Client.GetAsync(
        //                     $"search" +
        //                     $"/{typeof(TD).Name}" +
        //                     $"?{Criteria.GetUri(criterias)}" +
        //                     $"&{new Parameter { range = new Range(0, seatchStart.TotalCount) }}",
        //                     cancel), 
        //                 a => responseSearchEnd = a.Response));
        //         else
        //         {
        //             parameter.range = new Range(0, seatchStart.TotalCount);
        //             clt.QueueRequest.Enqueue(
        //                 new ClientRequest(
        //                     async () => 
        //                         await client
        //                             .Client
        //                             .GetAsync($"search" +
        //                                       $"/{typeof(TD).Name}" +
        //                                       $"?{Criteria.GetUri(criterias)}" +
        //                                       $"&{parameter}", cancel), 
        //                     a => responseSearchEnd = a.Response));
        //         }
        //         
        //         timeSpan = DateTime.Now + TimeSpan.FromSeconds(client.TimeOut);  
        //         
        //         while (responseSearchEnd == null)
        //         {
        //             if (cancel.IsCancellationRequested) cancel.ThrowIfCancellationRequested();
        //             
        //             if (timeSpan < DateTime.Now) 
        //                 throw new TimeoutException("Привышено время ожидания ответа от сервера!");
        //         }
        //
        //         return responseSearchEnd.IsSuccessStatusCode
        //             ? JsonConvert
        //                 .DeserializeObject<ResponseSearch>(
        //                     await responseSearchEnd.Content.ReadAsStringAsync(cancel))
        //             : throw new System.Exception($"Status code:{response.StatusCode} " +
        //                                          $"content?:{await response.Content.ReadAsStringAsync(cancel)}");
        //
        //     }
        //
        // }        
        //
        /// <summary>
        /// Получить список объектов D
        /// </summary>
        /// <param name="glpiClient"></param>
        /// <param name="cancel"></param>
        /// <returns></returns>
        /// <exception cref="ExceptionCheck"></exception>
        // public static async Task<string> GetEnumerableJson(
        //     IClient clt, 
        //     CancellationToken cancel = default)=>        
        //      glpiClient.Checker()
        //         ? throw new ExceptionCheck(glpiClient)
        //         : JsonConvert.SerializeObject(await GetEnumerable(glpiClient, cancel));        
        
        /// <summary>
        /// Get date from uri
        /// </summary>
        /// <param name="clt"></param>
        /// <param name="endPoint"></param>
        /// <param name="cancel"></param>
        /// <returns></returns>
        /// <exception cref="ExceptionCheck"></exception>
        /// <exception cref="Exception"></exception>
        /// <exception cref="TimeoutException"></exception>
        // public static async Task<string> GetJsonFromUri(
        //     IGlpiClient clt,
        //     string endPoint, 
        //     CancellationToken cancel = default)
        // {            
        //     if (clt.Checker())      throw new ExceptionCheck(clt);
        //     if (clt.IsClone)        throw new System.Exception("Объект не должен быть клоном");
        //     
        //     IGlpiClient client = (IGlpiClient)clt.Clone();
        //     client.SetHeaderDefault();           
        //
        //     HttpResponseMessage response = null;
        //     ClientRequest req = new ClientRequest(async () => await client.Client.GetAsync(endPoint, cancel),
        //         r => response = r.Response);
        //     clt.QueueRequest.Enqueue(req);
        //
        //     var timeSpan = DateTime.Now + TimeSpan.FromSeconds(client.TimeOut);  
        //     
        //     while (response == null)
        //     {
        //         if (cancel.IsCancellationRequested)
        //             cancel.ThrowIfCancellationRequested();
        //         
        //         if (timeSpan < DateTime.Now) 
        //             throw new TimeoutException("Привышено время ожидания ответа от сервера!");
        //     }
        //
        //     return response.IsSuccessStatusCode
        //         ? await response.Content.ReadAsStringAsync(cancel)
        //         : throw new System.Exception(
        //             $"Status code:{response.StatusCode} " +
        //             $"content?:{await response.Content.ReadAsStringAsync(cancel)}");
        // }
        //
             
        //
        // /// <summary>
        // /// Добавляет объекты D в коллекцию GLPI
        // /// </summary>
        // /// <param name="clt"></param>
        // /// <param name="ds"></param>
        // /// <param name="cancel"></param>
        // /// <returns></returns>
        // /// <exception cref="ExceptionCheck"></exception>
        // /// <exception cref="Exception"></exception>
        // /// <exception cref="TimeoutException"></exception>
        // public static async Task<string> AddItems(
        //     IGlpiClient clt,
        //     IEnumerable<TD> ds, 
        //     CancellationToken cancel = default)
        // {
        //     if (clt.Checker())      throw new ExceptionCheck(clt);
        //     if (clt.IsClone)        throw new System.Exception("Объект не должен быть клоном");
        //     
        //     IGlpiClient client = (IGlpiClient)clt.Clone();
        //     client.SetHeaderDefault();
        //     
        //     JsonSerializerSettings settings = new JsonSerializerSettings
        //     {
        //         NullValueHandling = NullValueHandling.Ignore
        //     };
        //
        //
        //     StringContent content =
        //         new StringContent(JsonConvert.SerializeObject(
        //                 new { input = ds }, 
        //                 Formatting.Indented, settings),
        //             Encoding.UTF8, "application/json");
        //     
        //     HttpResponseMessage response = null;
        //     
        //     ClientRequest clientRequest = new ClientRequest(
        //         async () => await client.Client.PostAsync(typeof(TD).Name, content,cancel), 
        //         a => response = a.Response);
        //     
        //     clt.QueueRequest.Enqueue(clientRequest);
        //
        //     var timeSpan = DateTime.Now + TimeSpan.FromSeconds(client.TimeOut);  
        //     
        //     while (response == null)
        //     {
        //         if (cancel.IsCancellationRequested)
        //             cancel.ThrowIfCancellationRequested();
        //         
        //         if (timeSpan < DateTime.Now) 
        //             throw new TimeoutException("Привышено время ожидания ответа от сервера!");
        //     }
        //
        //     return response.IsSuccessStatusCode
        //         ? await response.Content.ReadAsStringAsync(cancel)
        //         : throw new System.Exception(
        //             $"Status code: {response.StatusCode}" +
        //             $" content: {await response.Content.ReadAsStringAsync(cancel)}");
        // }
        //
        // /// <summary>
        // /// Добавить объект
        // /// </summary>
        // /// <param name="clt"></param>
        // /// <param name="cancel"></param>
        // /// <returns></returns>
        // /// <exception cref="ExceptionCheck"></exception>
        // /// <exception cref="Exception"></exception>
        // /// <exception cref="TimeoutException"></exception>
        // public async Task<string> AddItem(
        //     IGlpiClient clt,            
        //     CancellationToken cancel = default)
        // {
        //     if (clt.Checker())      throw new ExceptionCheck(clt);
        //     if (clt.IsClone)        throw new System.Exception("Объект не должен быть клоном");
        //     
        //     IGlpiClient client = (IGlpiClient)clt.Clone();
        //     client.SetHeaderDefault();
        //     
        //     JsonSerializerSettings settings = new JsonSerializerSettings
        //     {
        //         NullValueHandling = NullValueHandling.Ignore
        //     };
        //
        //     StringContent content =
        //         new StringContent(JsonConvert.SerializeObject(
        //                 new { input = this },
        //                 Formatting.Indented, settings),
        //             Encoding.UTF8, "application/json");
        //     
        //     HttpResponseMessage response = null;
        //     
        //     ClientRequest clientRequest =
        //         new ClientRequest(async () => 
        //                 await client.Client.PostAsync(typeof(TD).Name, content, cancel),
        //             a => response = a.Response);
        //     
        //     clt.QueueRequest.Enqueue(clientRequest);
        //
        //     var timeSpan = DateTime.Now + TimeSpan.FromSeconds(client.TimeOut);  
        //     
        //     while (response == null)
        //     {
        //         if (cancel.IsCancellationRequested)
        //             cancel.ThrowIfCancellationRequested();
        //         
        //         if (timeSpan < DateTime.Now) 
        //             throw new TimeoutException("Привышено время ожидания ответа от сервера!");
        //     }
        //
        //     return response.IsSuccessStatusCode
        //         ? await response.Content.ReadAsStringAsync(cancel)
        //         : throw new System.Exception(
        //             $"Status code: {response.StatusCode} content: {await response.Content.ReadAsStringAsync(cancel)}");
        // }
        //
        // /// <summary>
        // /// Обновление объектов
        // /// </summary>
        // /// <param name="clt"></param>
        // /// <param name="ds"></param>
        // /// <param name="cancel"></param>
        // /// <returns></returns>
        // /// <exception cref="ExceptionCheck"></exception>
        // /// <exception cref="Exception"></exception>
        // /// <exception cref="TimeoutException"></exception>
        // public static async Task<IEnumerable<ResponseToChange>> UpdateItems(
        //     IGlpiClient clt,
        //     List<TD> ds,
        //     CancellationToken cancel = default)
        // {
        //     if (clt.Checker())      throw new ExceptionCheck(clt);
        //     if (clt.IsClone)        throw new System.Exception("Объект не должен быть клоном");
        //     
        //     IGlpiClient client = (IGlpiClient)clt.Clone();
        //     client.SetHeaderDefault();
        //     
        //     JsonSerializerSettings settings = new JsonSerializerSettings
        //     {
        //         NullValueHandling = NullValueHandling.Ignore
        //     };
        //
        //     List<Dictionary<string, object>> kv = new List<Dictionary<string, object>>();
        //     for (int index = 0; index < ds.Count(); index++)
        //     {
        //         var q = ds[index].ChangeProperty;
        //         q.Add("id", ds[index].Id);
        //         kv.Add(q);
        //     }
        //
        //     StringContent content = new StringContent(JsonConvert.SerializeObject(new { input = kv },Formatting.Indented, settings), Encoding.UTF8, "application/json");
        //     HttpResponseMessage response = null;
        //     ClientRequest clientRequest = new ClientRequest(async () => await client.Client.PutAsync(typeof(TD).Name, content,cancel), a => response = a.Response);
        //     clt.QueueRequest.Enqueue(clientRequest);
        //
        //     var timeSpan = DateTime.Now + TimeSpan.FromSeconds(client.TimeOut);  
        //     
        //     while (response == null)
        //     {
        //         if (cancel.IsCancellationRequested)
        //             cancel.ThrowIfCancellationRequested();
        //         
        //         if (timeSpan < DateTime.Now) 
        //             throw new TimeoutException("Привышено время ожидания ответа от сервера!");
        //     }
        //
        //     return response.IsSuccessStatusCode
        //         ? ResponseToChange.ParseItem(await response.Content.ReadAsStringAsync(cancel))
        //         : throw new System.Exception(
        //             $"Status code: {response.StatusCode} content: {await response.Content.ReadAsStringAsync(cancel)}");
        // }
        //
        // /// <summary>
        // /// Обновление объекта
        // /// </summary>
        // /// <param name="clt"></param>
        // /// <param name="cancel"></param>
        // /// <returns></returns>
        // /// <exception cref="ExceptionCheck"></exception>
        // /// <exception cref="Exception"></exception>
        // /// <exception cref="TimeoutException"></exception>
        // public async Task<ResponseToChange> UpdateItem(
        //     IGlpiClient clt,
        //     CancellationToken cancel = default)
        // {
        //     if (clt.Checker())      throw new ExceptionCheck(clt);
        //     if (clt.IsClone)        throw new System.Exception("Объект не должен быть клоном");
        //     
        //     IGlpiClient client = (IGlpiClient)clt.Clone();
        //     client.SetHeaderDefault();
        //     
        //     JsonSerializerSettings settings = new JsonSerializerSettings
        //     {
        //         NullValueHandling = NullValueHandling.Ignore
        //     };
        //
        //     HttpResponseMessage response = null;
        //
        //     StringContent content = new StringContent(
        //         JsonConvert.SerializeObject
        //         (
        //             new { input = ChangeProperty },
        //             Formatting.Indented,
        //             settings
        //         ),
        //         Encoding.UTF8,
        //         "application/json");
        //
        //     ClientRequest clientRequest = new ClientRequest(
        //         async () =>
        //             await client.Client.PutAsync(
        //                 string.Join("/", typeof(TD).Name, Id), content, cancel),
        //         a => response = a.Response);
        //     
        //     clt.QueueRequest.Enqueue(clientRequest);
        //
        //     var timeSpan = DateTime.Now + TimeSpan.FromSeconds(client.TimeOut);  
        //     
        //     while (response == null)
        //     {
        //         if (cancel.IsCancellationRequested)
        //             cancel.ThrowIfCancellationRequested();
        //         
        //         if (timeSpan < DateTime.Now) 
        //             throw new TimeoutException("Привышено время ожидания ответа от сервера!");
        //     }
        //
        //     return response.IsSuccessStatusCode
        //         ? ResponseToChange.Parse( await response.Content.ReadAsStringAsync(cancel))                
        //     : throw new System.Exception(
        //         $"Status code: {response.StatusCode} content: {await response.Content.ReadAsStringAsync(cancel)}"); 
        // }
        //
        // /// <summary>
        // /// Удаление объекта 
        // /// </summary>
        // /// <param name="clt"></param>
        // /// <param name="cancel"></param>
        // /// <returns></returns>
        // /// <exception cref="ExceptionCheck"></exception>
        // /// <exception cref="Exception"></exception>
        // /// <exception cref="TimeoutException"></exception>
        // public async Task<string> Delete(
        //     IGlpiClient clt,
        //     CancellationToken cancel = default)
        // {
        //     if (clt.Checker())      throw new ExceptionCheck(clt);
        //     if (clt.IsClone)        throw new System.Exception("Объект не должен быть клоном");
        //     
        //     IGlpiClient client = (IGlpiClient)clt.Clone();
        //     client.SetHeaderDefault();            
        //
        //     HttpResponseMessage response = null;
        //     
        //     ClientRequest clientRequest =
        //         new ClientRequest(
        //             async () =>
        //                 await client.Client.DeleteAsync(string.Join("/", typeof(TD).Name, Id), cancel),
        //             a => response = a.Response);
        //     clt.QueueRequest.Enqueue(clientRequest);
        //
        //     var timeSpan = DateTime.Now + TimeSpan.FromSeconds(client.TimeOut);  
        //     
        //     while (response == null)
        //     {
        //         if (cancel.IsCancellationRequested)
        //             cancel.ThrowIfCancellationRequested();
        //         
        //         if (timeSpan < DateTime.Now) 
        //             throw new TimeoutException("Привышено время ожидания ответа от сервера!");
        //     }
        //
        //     return response.IsSuccessStatusCode
        //         ? await response.Content.ReadAsStringAsync(cancel)
        //         : throw new System.Exception(
        //             $"Status code: {response.StatusCode} content: {await response.Content.ReadAsStringAsync(cancel)}");
        // }
        //
        // /// <summary>
        // /// Метод загрузки элеметов из объекта Links
        // /// </summary>
        // /// <param name="clt"></param>
        // /// <param name="properties">Список черных/белых типов</param>
        // /// <param name="isIgnoreProperties">Если false = список типов используется как белый список,если true список используется как черный спиок</param>
        // /// <param name="cancel"></param>
        // /// <exception cref="ExceptionCheck"></exception>
        // /// <exception cref="Exception"></exception>
        // /// <exception cref="TimeoutException"></exception>
        // public virtual async Task LoadFromLinkAsync(
        //     IGlpiClient clt, 
        //     IEnumerable<PropertyInfo> properties = null,
        //     bool? isIgnoreProperties = null,            
        //     CancellationToken cancel = default)
        // {
        //     if (Links == null || Links.Count == 0) return;
        //     
        //     if (clt.Checker())      throw new ExceptionCheck(clt);
        //     if (clt.IsClone)        throw new System.Exception("Объект не должен быть клоном");
        //     
        //     IGlpiClient client = (IGlpiClient)clt.Clone();
        //     client.SetHeaderDefault();            
        //
        //     HttpResponseMessage response = null;
        //
        //     IEnumerable<string>
        //         appendIgnore = //свойсва, которые будут игнорироваться по умолчанию через атрибут NoLinkAttribute
        //             GetType().GetProperties()
        //                 .Where(w => w.GetCustomAttributes(true).Contains(typeof(NoLinkAttribute)))
        //                 .Select(s => s.Name.ToLower());            
        //
        //     IEnumerable<string> propertiesStr =
        //         properties != null ? properties.Select(s => s.Name.ToLower()) : Array.Empty<string>();//строковое предстваления свойства
        //
        //     IEnumerable<Link> links = isIgnoreProperties switch
        //     {
        //         true => Links.Where(w => !appendIgnore.Contains(w.Rel) && !propertiesStr.Contains(w.Rel.ToLower())),
        //         false => Links.Where(w => !appendIgnore.Contains(w.Rel) && propertiesStr.Contains(w.Rel.ToLower())),
        //         _ => Links.Where(w => !appendIgnore.Contains(w.Rel))
        //     };
        //
        //     foreach (Link link in links)
        //     {
        //         PropertyInfo rel = GetType().GetProperty(link.Rel);//Получаем свойство
        //         if(rel == null || rel.GetCustomAttributes(typeof(NoLinkAttribute)).Any()) continue;//Проверка на существование или есть атрибут пропуска загрузки               
        //         var request = new ClientRequest(
        //             async () => await client.Client.GetAsync(
        //                 string.Join("", link.Address.Segments.Skip(client.Client.BaseAddress!.Segments.Length)),
        //                 cancel), a => response = a.Response);
        //         
        //         clt.QueueRequest.Enqueue(request); // отправка запроса в очерель запросов                
        //         
        //         var timeSpan = DateTime.Now + TimeSpan.FromSeconds(client.TimeOut);  
        //     
        //         while (response == null)
        //         {
        //             if (cancel.IsCancellationRequested)
        //                 cancel.ThrowIfCancellationRequested();
        //         
        //             if (timeSpan < DateTime.Now) 
        //                 throw new TimeoutException("Привышено время ожидания ответа от сервера!");
        //         }
        //
        //         if (response.IsSuccessStatusCode)
        //         {
        //             try
        //             {
        //                 // если ответ положительный, то идет запись объекта
        //                 rel.SetValue(this, JsonConvert.DeserializeObject(
        //                     await response.Content.ReadAsStringAsync(cancel),
        //                     rel.PropertyType));
        //             }
        //             catch (System.Exception er)
        //             {
        //                 //Debug.WriteLine($"{er.Message}\n{link.Rel}\n{link.Address}");
        //             }
        //         }
        //         response = null;
        //     }           
        // }
        //
        // #endregion

        #region Multies

         // public virtual async Task LoadBaseEntity(
        //     IGlpiMulti glpiMulti,
        //     IGlpiClient client, 
        //     CancellationToken cancel = default)
        // {
        //     if (glpiMulti.Checker()) throw new ExceptionCheck(glpiMulti);
        //     if (client.Checker()) throw new ExceptionCheck(client);
        //     
        //     int iteration = 0;
        //     List<ClientResponse> responseMessages = new List<ClientResponse>();
        //     
        //     
        //     foreach (var entity in GetType().GetProperties()
        //                  .Where(w => w.GetCustomAttributes(typeof(BaseEntityAttribute), true).Any()))  
        //     {
        //
        //         long? id = (long?)GetType().GetProperty($"Id{entity.Name}")
        //             ?.GetValue(this);
        //         if (id == null) continue;
        //
        //         glpiMulti.QueueRequest.Enqueue(new MultiRequest());
        //         glpiMulti.QueueRequest.Enqueue(new MultiRequest(
        //             async () => await client.Client.GetAsync($"{entity.Name}/{id}", cancel),
        //             a => responseMessages.Add(a), client, entity));
        //         iteration++;
        //     }
        //
        //     while (responseMessages.Count != iteration)
        //     {
        //         if (cancel.IsCancellationRequested)
        //             cancel.ThrowIfCancellationRequested();
        //     }
        //
        //     foreach (ClientResponse response in responseMessages.Where(w=>w.ResponseMessage.IsSuccessStatusCode))
        //     {                
        //         response.RequestedProperty.SetValue(this, await response.ResponseMessage.Content.ReadAsStringAsync(cancel));
        //     } 
        //     
        // }
        //
       
       
        //
        // /// <summary>
        // /// Получить объект D в формате JSON
        // /// </summary>
        // /// /// <param name="glpiMulti"> подключенный общий клиент к GLPI</param>
        // /// <param name="glpiClient"> подключенный клиент к GLPI</param>
        // /// <param name="parameter">Параметры запроса</param>
        // /// <param name="isClientOperator"></param>
        // /// <param name="cancel">Принудительная остановка процесса</param>
        // /// <exception cref="ExceptionCheck"></exception>
        // /// <exception cref="Exception"></exception>
        // public static async Task<string> GetJson(
        //     IGlpiMulti glpiMulti,
        //     IGlpiClient glpiClient,
        //     Parameter parameter, 
        //     bool isClientOperator = true,
        //     CancellationToken cancel = default)
        // {
        //     if (glpiMulti.Checker()) throw new ExceptionCheck(glpiMulti);            
        //     if (glpiClient.Checker()) throw new ExceptionCheck(glpiClient);            
        //     
        //     if (parameter == null) throw new System.Exception("Error parameter.");
        //     HttpResponseMessage response = null;
        //     MultiRequest multiRequest;
        //     if (isClientOperator)
        //     {
        //         glpiClient.SetHeaderDefault();
        //         multiRequest = new MultiRequest(
        //             () => glpiClient.Client.GetAsync($"{typeof(TD).Name}{parameter}", cancel),
        //             w => response = w, glpiClient);
        //     }
        //     else
        //     {
        //         glpiMulti.SetHeaderDefault();
        //         multiRequest = new MultiRequest(
        //             () => glpiMulti.Client.GetAsync($"{typeof(TD).Name}{parameter}", cancel),
        //             w => response = w, glpiClient);
        //     }
        //
        //     glpiMulti.QueueRequest.Enqueue(multiRequest);
        //
        //     while (response == null) 
        //     {
        //         if (cancel.IsCancellationRequested)
        //         {
        //             cancel.ThrowIfCancellationRequested();
        //         }                
        //     }
        //     
        //     if (response.IsSuccessStatusCode)
        //         return await Task.FromResult(await response.Content.ReadAsStringAsync(cancel));
        //     
        //     throw new System.Exception($"status code: {response.StatusCode} content: {await response.Content.ReadAsStringAsync(cancel)}");
        // }
        //
        //
        
        //
        // /// <summary>
        // /// 
        // /// </summary>
        // /// <param name="glpiMulti"></param>
        // /// <param name="glpiClient"></param>
        // /// <param name="parameter"></param>
        // /// <param name="isClientOperator"></param>
        // /// <param name="cancel"></param>
        // /// <returns></returns>
        // /// <exception cref="ExceptionCheck"></exception>
        // /// <exception cref="Exception"></exception>
        // public static async Task<TD> GetAsync(
        //     IGlpiMulti glpiMulti,
        //     IGlpiClient glpiClient,
        //     Parameter parameter,
        //     bool isClientOperator = true,
        //     CancellationToken cancel = default)
        // {
        //     if (glpiMulti.Checker()) throw new ExceptionCheck(glpiClient);
        //     
        //     if (glpiClient.Checker()) throw new ExceptionCheck(glpiClient);
        //    
        //     
        //     if (parameter?.id is null or < 0) throw new System.Exception("Error parameter.");
        //    
        //     try
        //     {
        //         return JsonConvert.DeserializeObject<TD>(await GetJson(glpiMulti, glpiClient, parameter,
        //             isClientOperator, cancel));
        //     }
        //     catch
        //     {
        //         throw new System.Exception("Json value null");
        //     }           
        //
        //     
        // }

        #endregion


        public int CompareTo(TD other) =>
            Id < other.Id ? -1 : Id > other.Id ? 1 : 0;
        
        public bool Equals(IDashboard other) =>
            other != null && Id == other.Id;
    }
}