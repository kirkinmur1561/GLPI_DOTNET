using CommonObj.Dashboard.Administration;

namespace CommonObj.Dashboard.Common.Creators
{
    public interface ICreatorLocation:ICreator<Location>
    {
        int StartLevelDefault { get; set; }
        int Remove(int level);
        IEnumerable<Location> GetSubLevel();
    }

    public interface ICrTest<T> : ICreator<T> where T : class
    {
        int StartLevelDefault { get; set; }
        int Remove(int level);
        IEnumerable<T> GetSubLevel();
    }
}