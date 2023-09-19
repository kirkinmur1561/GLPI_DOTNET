namespace CommonObj.Dashboard.Common
{
    public interface ICreator<TD>
    {
        IEnumerable<TD> SelectedPoint();
        bool Append(TD item);
        int Remove(TD item);
    }
}