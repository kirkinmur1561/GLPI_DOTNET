using CommonObj.Base;
using CommonObj.Dashboard.Common;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace CommonObj.Dashboard.Administration
{
    public class Location : Dashboard<Location>, IEquatable<Location>,IComparer<string>
    {
        public Location()
        {

        }
        
        [JsonProperty(BaseJsonProperty.COMPLETENAME)]
        public string CompleteName { get; set; }
        
        [JsonProperty(BaseJsonProperty.LEVEL)]
        public int? Level { get; set; }
        
        [JsonProperty(BaseJsonProperty.ANCESTORS_CACHE)]
        public string CacheAncestors { get; set; }
        
        [JsonProperty(BaseJsonProperty.SONS_CACHE)]
        public string SonsCache { get; set; }
        
        [JsonProperty(BaseJsonProperty.ADDRESS)]
        public string Address { get; set; }
        
        [JsonProperty(BaseJsonProperty.POSTCODE)]
        public string Postcode { get; set; }
        
        [JsonProperty(BaseJsonProperty.TOWN)]
        public string Town { get; set; }
        
        [JsonProperty(BaseJsonProperty.STATE)]
        public string State { get; set; }
        
        [JsonProperty(BaseJsonProperty.COUNTRY)]
        public string Country { get; set; }
        
        [JsonProperty(BaseJsonProperty.BUILDING)]
        public string Building { get; set; }
        
        [JsonProperty(BaseJsonProperty.ROOM)]
        public string Room { get; set; }
        
        [JsonProperty(BaseJsonProperty.LATITUDE)]
        public string Latitude { get; set; }
        
        [JsonProperty(BaseJsonProperty.LONGITUDE)]
        public string Longitude { get; set; }
        
        [JsonProperty(BaseJsonProperty.ALTITUDE)]
        public object Altitude { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Location);
        }

        public bool Equals(Location other)
        {
            return other != null &&
                   Id == other.Id &&
                   IdEntity == other.IdEntity &&
                   IsRecursive == other.IsRecursive &&
                   Name == other.Name &&
                   Comment == other.Comment &&
                   IdLocation == other.IdLocation &&
                   IdUsersTech == other.IdUsersTech &&
                   IdGroupsTech == other.IdGroupsTech &&
                   IdManufacturer == other.IdManufacturer &&
                   IsDeleted == other.IsDeleted &&
                   IsTemplate == other.IsTemplate &&
                   TemplateName == other.TemplateName &&
                   DateMod == other.DateMod &&
                   IdUser == other.IdUser &&
                   IdGroup == other.IdGroup &&
                   TicketTco == other.TicketTco &&
                   DateCreation == other.DateCreation &&
                   CompleteName == other.CompleteName &&
                   Level == other.Level &&
                   CacheAncestors == other.CacheAncestors &&
                   SonsCache == other.SonsCache &&
                   Address == other.Address &&
                   Postcode == other.Postcode &&
                   Town == other.Town &&
                   State == other.State &&
                   Country == other.Country &&
                   Building == other.Building &&
                   Room == other.Room &&
                   Latitude == other.Latitude &&
                   Longitude == other.Longitude;

        }

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
            hash.Add(CompleteName);
            hash.Add(Level);
            hash.Add(CacheAncestors);
            hash.Add(SonsCache);
            hash.Add(Address);
            hash.Add(Postcode);
            hash.Add(Town);
            hash.Add(State);
            hash.Add(Country);
            hash.Add(Building);
            hash.Add(Room);
            hash.Add(Latitude);
            hash.Add(Longitude);
            return hash.ToHashCode();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Location left, Location right)
        {
            return EqualityComparer<Location>.Default.Equals(left, right);
        }

        public static bool operator !=(Location left, Location right)
        {
            return !(left == right);
        }

        public int Compare(string x, string y)
        {
            int l;
            int r;
            if (int.TryParse(x, out l))
            {
                if (int.TryParse(y, out r)) return l == r ? 0 : l < r ? -1 : 1;
                return -1;
            }

            if (int.TryParse(y, out r)) return 1;
            return 0;
        }  
       
    }



    public class LocationCreator:ICreator<Location>

    {
    private List<Location> _selectedPoint = new();

    public LocationCreator(IEnumerable<Location> workCollection) =>
        WorkCollection = workCollection;

    public IEnumerable<Location> WorkCollection { get; }
    public int StartLevelDefault { get; set; } = 1;

    public IEnumerable<Location> SelectedPoint() =>
        _selectedPoint;


    public bool Append(Location item)
    {
        if (_selectedPoint.Contains(item)) return false;
        if (_selectedPoint.Select(s => s.Level).Contains(item.Level))
        {
            Remove(item.Level ?? 1);
            _selectedPoint.Add(item);
        }
        else _selectedPoint.Add(item);

        return true;
    }

    public int Remove(int level) =>
        _selectedPoint.RemoveAll(r => r.Level >= level);

    public int Remove(Location item) =>
        Remove(item.Level ?? StartLevelDefault);

    public IEnumerable<Location> GetSubLevel()
    {
        if (!_selectedPoint.Any()) return WorkCollection.Where(w => w.Level == StartLevelDefault);
        var _last = _selectedPoint!.LastOrDefault();

        if (_last!.SonsCache.Length < 4) return Enumerable.Empty<Location>();

        var data =
            JsonSerializer
                .Deserialize<Dictionary<string, object>>(_last.SonsCache)
                ?.Skip(1)
                .Select(s => s.Value.ToString())
            ?? Enumerable.Empty<string>();

        return WorkCollection.Where(w =>
            w.Level == _last.Level + 1 && data.Contains(w.Id.ToString()));
    }



    public override string ToString() =>
        string.Join(" > ", _selectedPoint.Select(s => s.Name));
    }
}
