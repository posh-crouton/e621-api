using Newtonsoft.Json;

namespace Posh.E621.ApiObject;

/// <summary>
/// A post's score as voted by viewers
/// </summary>
public class Score
{
    /// <summary>
    /// Number of "Up" votes on the post
    /// </summary>
    [JsonProperty("up")]
    public int Up { get; }

    /// <summary>
    /// Number of "Down" votes on the post
    /// </summary>
    [JsonProperty("down")]
    public int Down { get; }

    /// <summary>
    /// Total number of votes on the post. This is a response
    /// from the API and is not computed from <see cref="Up"/>
    /// and <see cref="Down"/>. 
    /// </summary>
    [JsonProperty("total")]
    public int Total { get; }
}
