using Newtonsoft.Json;

namespace Posh.E621.ApiObject;

public class Tags
{
    /// <summary>
    /// General tags on the post
    /// </summary>
    [JsonProperty("general")]
    public string[] General { get; }

    /// <summary>
    /// Tags attributing this post to artists
    /// </summary>
    [JsonProperty("artist")]
    public string[] Artist { get; }

    /// <summary>
    /// Tags declaring the copyright holders of content
    /// in the post
    /// </summary>
    [JsonProperty("copyright")]
    public string[] Copyright { get; }

    /// <summary>
    /// Tags specifying characters appearing in the post
    /// </summary>
    [JsonProperty("character")]
    public string[] Character { get; }

    /// <summary>
    /// Tags specifying species present in the post
    /// </summary>
    [JsonProperty("species")]
    public string[] Species { get; }

    /// <summary>
    /// Invalid tags
    /// </summary>
    [JsonProperty("invalid")]
    public string[] Invalid { get; }

    /// <summary>
    /// E621 meta tags
    /// </summary>
    [JsonProperty("meta")]
    public string[] Meta { get; }

    /// <summary>
    /// Tags describing character/world lore. 
    /// Used to provide information that cannot be covered by 
    /// TWYS (Tag What You See) and correct information that 
    /// TWYS is providing incorrectly. 
    /// </summary>
    [JsonProperty("lore")]
    public string[] Lore { get; }
}
