using Newtonsoft.Json;

namespace Posh.E621.ApiObject;

/// <summary>
/// The flags on a post
/// </summary>
public class Flags
{
    /// <summary>
    /// Whether the post is pending approval
    /// </summary>
    [JsonProperty("pending")]
    public bool Pending { get; }

    /// <summary>
    /// Whether the post has been flagged
    /// </summary>
    [JsonProperty("flagged")]
    public bool Flagged { get; }

    /// <summary>
    /// Whether the post's notes are locked
    /// </summary>
    [JsonProperty("note_locked")]
    public bool NoteLocked { get; }

    /// <summary>
    /// Whether the post's status is locked
    /// </summary>
    [JsonProperty("status_locked")]
    public bool StatusLocked { get; }

    /// <summary>
    /// Whether the posts's rating is locked
    /// </summary>
    [JsonProperty("rating_locked")]
    public bool RatingLocked { get; }

    /// <summary>
    /// If the post is deleted
    /// </summary>
    [JsonProperty("deleted")]
    public bool Deleted { get; }
}
