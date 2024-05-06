using Newtonsoft.Json;

namespace Posh.E621.ApiObject;

public class Score
{
    [JsonProperty("up")]
    public int Up { get; }

    [JsonProperty("down")]
    public int Down { get; }

    [JsonProperty("total")]
    public int Total { get; }
}
