using Newtonsoft.Json;

namespace Posh.E621.ApiObject;

/// <summary>
/// An image or video file attached to an E621 post
/// </summary>
public class File : Image
{
    /// <summary>
    /// File name extension (not including ".")
    /// </summary>
    [JsonProperty("ext")]
    public string Ext { get; }

    /// <summary>
    /// The size of the file, in bytes
    /// </summary>
    [JsonProperty("size")]
    public int Size { get; }

    /// <summary>
    /// Unknown
    /// </summary>
    [JsonProperty("md5")]
    public string Md5 { get; }
}
