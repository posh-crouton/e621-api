using Newtonsoft.Json;

namespace Posh.E621.ApiObject;

public class Relationships
{
    [JsonProperty("parent_id")]
    public int? ParentId { get; }
    
    [JsonProperty("has_children")]
    public bool HasChildren { get; }

    [JsonProperty("has_active_children")]
    public bool HasActiveChildren { get; }

    [JsonProperty("children")]
    public int[] Children { get; }
}
