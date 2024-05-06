using Newtonsoft.Json;

namespace Posh.E621.ApiObject;

/// <summary>
/// An image or video file attached to an E621 post
/// </summary>
public class File : Image
{
    [JsonProperty("ext")]
    public string Ext { get; }

    [JsonProperty("size")]
    public int Size { get; }

    [JsonProperty("md5")]
    public string Md5 { get; }
}
