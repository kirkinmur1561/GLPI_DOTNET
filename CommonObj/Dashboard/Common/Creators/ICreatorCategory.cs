using CommonObj.Dashboard.Administration;

namespace CommonObj.Dashboard.Common.Creators
{
    public interface ICreatorCategory:ICreator<ITILCategory>
    {
        int StartLevelDefault { get; set; }
        int Remove(int level);
        IEnumerable<ITILCategory> GetSubLevel();
    }
}