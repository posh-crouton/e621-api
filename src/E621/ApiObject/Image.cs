using Newtonsoft.Json;

namespace Posh.E621.ApiObject;

public abstract class Image
{
    [JsonProperty("width")]
    public int Width { get; }
    
    [JsonProperty("height")]
    public int Height { get; }

    [JsonProperty("url")]
    public string Url { get; }
}
