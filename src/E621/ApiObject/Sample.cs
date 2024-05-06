namespace Posh.E621.ApiObject;

public class Sample : Image
{
    public bool Has { get; }
    public object Alternates => throw new NotImplementedException();
}
