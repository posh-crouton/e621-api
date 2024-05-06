using Newtonsoft.Json;

namespace Posh.E621.ApiObject;

public class Tags
{
    [JsonProperty("general")]
    public string[] General { get; }

    [JsonProperty("artist")]
    public string[] Artist { get; }

    [JsonProperty("copyright")]
    public string[] Copyright { get; }

    [JsonProperty("character")]
    public string[] Character { get; }

    [JsonProperty("species")]
    public string[] Species { get; }

    [JsonProperty("invalid")]
    public string[] Invalid { get; }

    [JsonProperty("meta")]
    public string[] Meta { get; }

    [JsonProperty("lore")]
    public string[] Lore { get; }
}
