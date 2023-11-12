using System.Collections;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
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

        /// <summary>
        ///  
        /// </summary>
        /// <param name="clt">Init glpi client</param>
        /// <param name="cancel"></param>
        /// <returns></returns>
        /// <exception cref="ExceptionGLPI_ErrorCommon"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="TaskCanceledException"></exception>
        /// <exception cref="UriFormatException"></exception>
        public static async Task<IEnumerable<SearchOption>> ListSearchOptionsAsync(
            IClient clt,
            CancellationToken cancel = default)
        {             
            clt.SetHeaderDefault();

            HttpResponseMessage response =
                await clt.http.GetAsync(string.Join("/", value: new[] { LIST_SEARCH_OPTIONS, typeof(TD).Name }),
                    cancel);     

            string responseData = await response.Content.ReadAsStringAsync(cancel);

            return response.IsSuccessStatusCode
                ? SearchOption.Parse(JsonConvert.DeserializeObject<Dictionary<string, object>>(responseData) ??
                                     new Dictionary<string, object>())
                : throw new ExceptionGLPI_ErrorCommon(responseData, response.StatusCode);
        }
        
        /// <summary>
        /// Get object TD in format JSON
        /// </summary>
        /// <param name="clt">Inti glpi client</param>
        /// <param name="parameter">parameter request</param>
        /// <param name="cancel"></param>
        /// <returns></returns>
        /// <exception cref="ExceptionGLPI_ErrorCommon"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="TaskCanceledException"></exception>
        /// <exception cref="UriFormatException"></exception>
        public static async Task<string> GetJsonAsync(
            IClient clt,
            Parameter parameter,
            CancellationToken cancel = default)
        {            
            clt.SetHeaderDefault();

            clt.http.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue("utf-8"));
            HttpResponseMessage response =
                await clt.http.GetAsync(
                    string.Join(string.Empty, typeof(TD).Name, parameter.id == null ? "?" : string.Empty, parameter),
                    cancel);
            
            string responseData = await response.Content.ReadAsStringAsync(cancel);

            return response.IsSuccessStatusCode
                ? responseData
                : throw new ExceptionGLPI_ErrorCommon(responseData, response.StatusCode);
        }
        
        /// <summary>
        /// Get object TD
        /// </summary>
        /// <param name="clt">Init glpi client</param>
        /// <param name="parameter">parameter request</param>
        /// <param name="cancel"></param>
        /// <exception cref="Exception"></exception>
        /// <exception cref="ExceptionGLPI_ErrorCommon"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="TaskCanceledException"></exception>
        /// <exception cref="UriFormatException"></exception>
        public static async Task<TD?> GetItemAsync(
            IClient clt,
            Parameter parameter,
            CancellationToken cancel = default)
        {
            clt.SetHeaderDefault();

            return parameter.id is null or < 0
                ? throw new Exception("Error parameter. Id eq = null or < 0")
                : JsonConvert.DeserializeObject<TD>(await GetJsonAsync(clt, parameter, cancel));
        }

        /// <summary>
        /// Get object items TD
        /// </summary>
        /// <param name="clt">Init glpi client</param>
        /// <param name="parameter">parameter request</param>
        /// <param name="cancel"></param>
        /// <returns></returns>
        /// <exception cref="ExceptionGLPI_ErrorCommon"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="TaskCanceledException"></exception>
        /// <exception cref="UriFormatException"></exception>
        public static async Task<IEnumerable<TD>?> GetItemsAsync(
            IClient clt,
            Parameter parameter,
            CancellationToken cancel = default)
        {
            clt.SetHeaderDefault();

            HttpResponseMessage response =
                await clt.http.GetAsync(string.Join(string.Empty, typeof(TD).Name, parameter), cancel);

            string result = await response.Content.ReadAsStringAsync(cancel);

            return response.IsSuccessStatusCode
                ? JsonConvert.DeserializeObject<List<TD>>(result)
                : throw new ExceptionGLPI_ErrorCommon(result, response.StatusCode);
        }

        public static async Task<ResponseSearch?> GetItemsAsync(
            IClient clt,
            Parameter parameter,
            IEnumerable<Criteria> criteria,
            CancellationToken cancel = default)
        {
            clt.SetHeaderDefault();

            HttpResponseMessage response =
                await clt.http.GetAsync(
                    string.Join(string.Empty,SearchRequest,'/', typeof(TD).Name, '?', Criteria.GetUri(criteria), '&', parameter), cancel);
        
            string result = await response.Content.ReadAsStringAsync(cancel);
        
            return response.IsSuccessStatusCode
                ? JsonConvert.DeserializeObject<ResponseSearch>(result)
                : throw new ExceptionGLPI_ErrorCommon(result, response.StatusCode);
        }
        //
        public static async Task<ResponseSearch?> GetItemsAsync(
            IClient clt,            
            IEnumerable<Criteria> criteria,
            CancellationToken cancel = default)
        {
            clt.SetHeaderDefault();

            HttpResponseMessage response =
                await clt.http.GetAsync(
                    string.Join(string.Empty, SearchRequest, typeof(TD).Name, "?", Criteria.GetUri(criteria)), cancel);
        
            string result = await response.Content.ReadAsStringAsync(cancel);
        
            return response.IsSuccessStatusCode
                ? JsonConvert.DeserializeObject<ResponseSearch>(result)
                : throw new ExceptionGLPI_ErrorCommon(result, response.StatusCode);
        }
        
        /// <summary>
        /// Get all objects
        /// </summary>
        /// <param name="clt">Init glpi client</param>
        /// <param name="cancel"></param>
        /// <returns></returns>
        /// <exception cref="ExceptionGLPI_ErrorCommon"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="TaskCanceledException"></exception>
        /// <exception cref="UriFormatException"></exception>
        public static async Task<IEnumerable<TD>?> GetItemsAsync(
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clt">Init glpi client</param>
        /// <param name="endPoint"></param>
        /// <param name="cancel"></param>
        /// <returns></returns>
        /// <exception cref="ExceptionGLPI_ErrorCommon"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="TaskCanceledException"></exception>
        /// <exception cref="UriFormatException"></exception>
        public static async Task<string> LoadFromUri(IClient clt, string endPoint, CancellationToken cancel = default)
        {
            clt.SetHeaderDefault();

            HttpResponseMessage responsEnd = await clt.http.GetAsync(endPoint, cancel);
            string result = await responsEnd.Content.ReadAsStringAsync(cancel);
            return responsEnd.IsSuccessStatusCode
                ? result
                : throw new ExceptionGLPI_ErrorCommon(result, responsEnd.StatusCode);
        }

        /// <summary>
        ///  Send objects in glpi
        /// </summary>
        /// <param name="clt">Init client</param>
        /// <param name="objs">Objects for insert into glpi</param>
        /// <param name="cancel"></param>
        /// <returns></returns>
        /// <exception cref="ExceptionGLPI_ErrorCommon"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="TaskCanceledException"></exception>
        /// <exception cref="UriFormatException"></exception>
        public static async Task<string> AddItemsAsync(IClient clt, IEnumerable<TD> objs, CancellationToken cancel = default)
        {
            clt.SetHeaderDefault();
            
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };
            
            StringContent content =
                new StringContent(JsonConvert.SerializeObject(
                        new { input = objs },
                        Formatting.Indented, settings),
                    Encoding.UTF8, MIMO_APPLICATION_JSON);

            HttpResponseMessage response = await clt.http.PostAsync(typeof(TD).Name, content, cancel);

            string result = await response.Content.ReadAsStringAsync(cancel);

            return response.IsSuccessStatusCode
                ? result
                : throw new ExceptionGLPI_ErrorCommon(result, response.StatusCode);
        }

        /// <summary>
        ///  Send object in glpi
        /// </summary>
        /// <param name="clt">Init glpi client</param>
        /// <param name="obj">Object for insert info glpi</param>
        /// <param name="cancel"></param>
        /// <returns></returns>
        /// <exception cref="ExceptionGLPI_ErrorCommon"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="TaskCanceledException"></exception>
        /// <exception cref="UriFormatException"></exception>
        public static Task<string> AddItemAsync(IClient clt, TD obj, CancellationToken cancel = default) =>
            AddItemsAsync(clt, new[] { obj }, cancel);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clt"></param>
        /// <param name="objsUpdate"></param>
        /// <param name="cancel"></param>
        /// <returns></returns>
        /// <exception cref="ExceptionGLPI_ErrorCommon"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="TaskCanceledException"></exception>
        /// <exception cref="UriFormatException"></exception>
        public static async Task<string> UpdateItemsAsync(IClient clt, IEnumerable<TD> objsUpdate, CancellationToken cancel = default)
        {
            clt.SetHeaderDefault();
            
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };
            
            StringContent content =
                new StringContent(JsonConvert.SerializeObject(
                        new { input = objsUpdate },
                        Formatting.Indented, settings),
                    Encoding.UTF8, MIMO_APPLICATION_JSON);

            HttpResponseMessage response = await clt.http.PutAsync(typeof(TD).Name, content, cancel);

            string result = await response.Content.ReadAsStringAsync(cancel);

            return response.IsSuccessStatusCode
                ? result
                : throw new ExceptionGLPI_ErrorCommon(result, response.StatusCode);
        }

        public static Task<string> UpdateItemAsync(IClient clt, TD objUpdate, CancellationToken cancel = default) =>
            UpdateItemsAsync(clt, new[] { objUpdate }, cancel);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="clt"></param>
        /// <param name="objsDel"></param>
        /// <param name="isForcePurge">If the itemtype have a trashbin, you can force purge (delete finally)</param>
        /// <param name="isHistory">Set to false to disable saving of deletion in global history</param>
        /// <param name="cancel"></param>
        /// <returns></returns>
        /// <exception cref="ExceptionGLPI_ErrorCommon"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="TaskCanceledException"></exception>
        /// <exception cref="UriFormatException"></exception>
        public static async Task<string> DeleteItemsAsync(IClient clt, IEnumerable<TD> objsDel, bool isForcePurge = false,
            bool isHistory = true, CancellationToken cancel = default)
        {
            clt.SetHeaderDefault();
            
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            StringContent content =
                new StringContent(JsonConvert.SerializeObject(
                        new
                        {
                            input = objsDel.Select(s => new { id = s.Id }),
                            force_purge = isForcePurge,
                            history = isHistory
                        },
                        Formatting.Indented, settings),
                    Encoding.UTF8, MIMO_APPLICATION_JSON);
            
            var request = new HttpRequestMessage(HttpMethod.Delete, typeof(TD).Name);
            request.Content = content;
            HttpResponseMessage response = await clt.http.SendAsync(request, cancel);
            string result = await response.Content.ReadAsStringAsync(cancel);

            return response.IsSuccessStatusCode
                ? result
                : throw new ExceptionGLPI_ErrorCommon(result, response.StatusCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clt"></param>
        /// <param name="objDel"></param>
        /// <param name="isForcePurge">If the itemtype have a trashbin, you can force purge (delete finally)</param>
        /// <param name="isHistory">Set to false to disable saving of deletion in global history</param>
        /// <param name="cancel"></param>
        /// <returns></returns>
        /// <exception cref="ExceptionGLPI_ErrorCommon"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="HttpRequestException"></exception>
        /// <exception cref="TaskCanceledException"></exception>
        /// <exception cref="UriFormatException"></exception>
        public static Task<string> DeleteItemAsync(IClient clt, TD objDel, bool isForcePurge = false,
            bool isHistory = true, CancellationToken cancel = default) =>
            DeleteItemsAsync(clt, new[] { objDel }, isForcePurge, isHistory, cancel);
        
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
                        object loadCollectVal;
                        bool isSingle;

                        try
                        {
                            loadCollectVal = JsonConvert.DeserializeObject(data, singleVal.PropertyType);
                            isSingle = true;
                        }
                        catch
                        {
                            loadCollectVal = JsonConvert.DeserializeObject(data, collectVal.PropertyType);
                            isSingle = false;
                        }

                        if (isSingle)
                        {
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
                        else
                        {
                            foreach (var val in (IList)loadCollectVal)
                            {
                                objects.Add(val);
                            }
                        }
                    }                            
                    else throw new ExceptionGLPI_ErrorCommon(data, response.StatusCode);
                }                              
            }
        }

        public int CompareTo(TD? other) =>
            Id < other?.Id ? -1 : Id > other?.Id ? 1 : 0;
        
        public bool Equals(IDashboard? other) =>
            other != null && Id == other.Id;
    }
}