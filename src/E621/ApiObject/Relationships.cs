namespace Posh.E621.ApiObject;

public class Relationships
{
    public int? ParentId { get; }
    public bool HasChildren { get; }
    public bool HasActiveChildren { get; }
    public int[] Children { get; }
}
