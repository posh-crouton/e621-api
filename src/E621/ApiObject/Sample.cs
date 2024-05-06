using Newtonsoft.Json;

namespace Posh.E621.ApiObject;

public class Sample : Image
{
    /// <summary>
    /// Whether the post has a sample
    /// </summary>
    [JsonProperty("has")]
    public bool Has { get; }

    /// <summary>
    /// Unknown
    /// </summary>
    [JsonProperty("alternates")]
    public object Alternates => throw new NotImplementedException();
}
