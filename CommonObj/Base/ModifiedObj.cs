namespace CommonObj.Base;

public class ModifiedObj
{
    public string VariableName { get; }
    public object InitialValue { get; }
    public IList<object> History => new List<object>();

    public ModifiedObj(string variableName, object initialValue)
    {
        VariableName = variableName;
        InitialValue = initialValue;
    }
}