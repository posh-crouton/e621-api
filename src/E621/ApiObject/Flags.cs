using Newtonsoft.Json;

namespace Posh.E621.ApiObject;

public class Flags
{
    [JsonProperty("pending")]
    public bool Pending { get; }

    [JsonProperty("flagged")]
    public bool Flagged { get; }

    [JsonProperty("note_locked")]
    public bool NoteLocked { get; }

    [JsonProperty("status_locked")]
    public bool StatusLocked { get; }

    [JsonProperty("rating_locked")]
    public bool RatingLocked { get; }

    [JsonProperty("deleted")]
    public bool Deleted { get; }
}
