using Newtonsoft.Json;

namespace Posh.E621.ApiObject;

public class Sample : Image
{
    [JsonProperty("has")]
    public bool Has { get; }

    [JsonProperty("alternates")]
    public object Alternates => throw new NotImplementedException();
}
