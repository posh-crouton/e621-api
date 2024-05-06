using Newtonsoft.Json;

namespace Posh.E621.ApiObject;

/// <summary>
/// Post's relationship to other posts
/// </summary>
public class Relationships
{
    /// <summary>
    /// The ID of this post's parent
    /// </summary>
    [JsonProperty("parent_id")]
    public int? ParentId { get; }
    
    /// <summary>
    /// Whether this post has children. 
    /// This is a response from the API and 
    /// is not computed from <see cref="Children.Length"/> 
    /// </summary>
    [JsonProperty("has_children")]
    public bool HasChildren { get; }

    /// <summary>
    /// Whether this post has active children
    /// </summary>
    [JsonProperty("has_active_children")]
    public bool HasActiveChildren { get; }

    /// <summary>
    /// IDs for this post's children
    /// </summary>
    [JsonProperty("children")]
    public int[] Children { get; }
}
