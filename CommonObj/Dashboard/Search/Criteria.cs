using System.Text;
using CommonObj.Base;
using CommonObj.Dashboard.Administration;
using CommonObj.Dashboard.Common;
using CommonObj.Dashboard.Helpdesk;

namespace CommonObj.Dashboard.Search
{
    public class Criteria
    {
        private Criteria(int field,
                        bool meta,
                        Type type,
                        ESearchType searchtype,
                        string value)
        {
            this.field = field;
            this.meta = meta;
            itemtype = type.Name;
            this.searchtype = searchtype;
            this.value = value;
        }
        
        public static Criteria Create<TD>(int field, bool meta,ESearchType searchtype,string value) where TD: Dashboard<TD> => 
            new(field, meta, typeof(TD), searchtype, value);
        
        private Criteria(int field,
            bool meta,
            Type type,
            ESearchType searchtype,
            ELink elink,
            string value) :
            this(field, meta, type, searchtype, value) =>
            SetLink(elink);

        public static Criteria Create<TD>(int field, bool meta, ESearchType searchtype, ELink elink, string value)
            where TD : Dashboard<TD> =>
            new(field, meta, typeof(TD), searchtype, elink, value);

        public static Criteria Create(int field, bool meta, Type typeDash, ESearchType searchtype, string value) =>
            new(field, meta, typeDash, searchtype, value);

        public static Criteria Create(int field, bool meta, Type typeDash, ESearchType searchtype, ELink elink,
            string value) =>
            new(field, meta, typeDash, searchtype, elink, value);

        private void SetLink(ELink elink) =>
            link = GetELink(elink);

        private string GetELink(ELink eLink) => eLink switch
        {
            ELink.AND => "AND",
            ELink.OR => "OR",
            ELink.AND_NOT => "AND NOT",
            ELink.OR_NOT => "OR NOT",
            ELink.Continue => "Continue",
            _ => throw new ArgumentOutOfRangeException(nameof(eLink), eLink, null)
        };

        public int field { get; set; } = 0;
        public bool meta { get; set;} = false;
        public string itemtype { get; set;} = string.Empty;
        public string link { get;  set; } = string.Empty;
        public ESearchType searchtype { get; set;} 
        public string value { get; set;} = string.Empty;
        
       
        public enum ELink
        {
            AND,
            OR,
            AND_NOT,
            OR_NOT,
            Continue,
        }

        public enum ESearchType
        {
            contains,
            equals,
            notequals,
            lessthan, 
            morethan,
            under, 
            notunder,
            notcontains
        }        

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public string RU_TranslateSearchType() => searchtype switch
        {
            ESearchType.contains => "содержит",
            ESearchType.notcontains => "не содержит",
            ESearchType.equals => "равно",
            ESearchType.notequals => "не равно",
            ESearchType.lessthan => "меньше, чем",
            ESearchType.morethan => "больше, чем",
            ESearchType.under => "ниже, чем",
            ESearchType.notunder => "не ниже, чем",
            _ => throw new NotImplementedException(),
        };

        /// <summary>
        /// Сборка адреса
        /// </summary>
        /// <param name="criterias"></param>
        /// <returns></returns>
        public static string GetUri(IEnumerable<Criteria> criterias)
        {
            StringBuilder sb = new StringBuilder();
            Criteria[] criteriaArray = criterias.ToArray();
            for (int index = 0; index < criteriaArray.Length; index++)
            {
                Criteria criteria = criteriaArray[index];
                var objs = criteria.GetType().GetProperties().Where(w =>
                {
                    if (index == 0 & w.Name == "link") return false;

                    object obj = w.GetValue(criteria);

                    if (obj is string & !string.IsNullOrEmpty(obj?.ToString())) return true;
                    return obj is not string;
                })
                .Select(s =>
                string.Format(string.Format("criteria[{0}][{1}]={2}",
                                            index,
                                            s.Name.ToLower(),
                                            s.GetValue(criteria))));

                sb.Append(string.Join(BaseResource.SEPARATOR_AND, objs));
                if (index + 1 < criteriaArray.Length) sb.Append(BaseResource.SEPARATOR_AND);
            }
            return sb.ToString();
        }

        /// <summary>
        ///  Шаблон критейрий поиска по адресу
        /// </summary>
        /// <param name="value"></param>
        /// <param name="searchType"></param>
        /// <param name="isMeta"></param>
        /// <returns></returns>
        public static Criteria Default_Address(
            string value = "",
            ESearchType searchType = ESearchType.contains,
            bool isMeta = false, 
            ELink link = ELink.Continue) => 
            link == ELink.Continue
            ? new Criteria(101, isMeta, typeof(Location), searchType, value)
            : new Criteria(101, isMeta, typeof(Location), searchType, link, value);


        /// <summary>
        /// Шаблон критейрий поиска по статусу заявки
        /// </summary>
        /// <param name="status"></param>
        /// <param name="searchType">For ticket only SeatchType.equals</param>
        /// <param name="isMeta"></param>
        /// <param name="link"></param>
        /// <returns></returns>
        public static Criteria Default_Status_Ticket(Ticket.EStatus status = Ticket.EStatus.New,
            ESearchType searchType = ESearchType.equals,
            bool isMeta = false, ELink link = ELink.Continue) => link == ELink.Continue
            ? new Criteria(12, isMeta, typeof(Ticket), searchType, $"{(int)status}")
            : new Criteria(12, isMeta, typeof(Ticket), searchType, link, $"{(int)status}");

        /// <summary>
        /// myself парам не подходит!
        /// </summary>
        /// <returns></returns>
        public static Criteria Delault_Myself_Ticket(long my_id = 748) =>
            new Criteria(5, false, typeof(Ticket), ESearchType.equals, $"{my_id}");

        /// <summary>
        /// Не работает!!!
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        public static IEnumerable<Criteria> Delault_Myself_Ticket_Status(long my_id = 748,Ticket.EStatus status = Ticket.EStatus.New) =>
            new[]
            {
                new Criteria(5, false, typeof(Ticket), ESearchType.equals,$"{my_id}"),
                new Criteria(12, false, typeof(Ticket), ESearchType.equals, ELink.AND, ((int)status).ToString())
            };

    }
}
