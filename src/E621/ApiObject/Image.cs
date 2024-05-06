using Newtonsoft.Json;

namespace Posh.E621.ApiObject;

/// <summary>
/// Base class representing any image or video
/// </summary>
public abstract class Image
{
    /// <summary>
    /// Number of pixels from left to right
    /// </summary>
    [JsonProperty("width")]
    public int Width { get; }
    
    /// <summary>
    /// Number of pixels from top to bottom
    /// </summary>
    [JsonProperty("height")]
    public int Height { get; }

    /// <summary>
    /// URL of the image
    /// </summary>
    [JsonProperty("url")]
    public string Url { get; }
}
