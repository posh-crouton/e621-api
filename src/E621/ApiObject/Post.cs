using Newtonsoft.Json;
using Posh.E621.Enum;

namespace Posh.E621.ApiObject;

/// <summary>
/// Represents a post on the E621 website.
/// </summary>
public class Post
{
    [JsonProperty("id")]
    public int Id { get; }

    [JsonProperty("created_at")]
    public DateTime CreatedAt { get; }

    [JsonProperty("updated_at")]
    public DateTime UpdatedAt { get; }

    [JsonProperty("file")]
    public File File { get; }

    [JsonProperty("preview")]
    public Image Preview { get; }
    
    [JsonProperty("sample")]
    public Sample Sample { get; }
    
    [JsonProperty("score")]
    public Score Score { get; }

    [JsonProperty("tags")]
    public Tags Tags { get; }

    [JsonProperty("locked_tags")]
    public string[] LockedTags { get; }

    [JsonProperty("change_seq")]
    public int ChangeSeq { get; }

    [JsonProperty("flags")]
    public Flags Flags { get; }

    [JsonProperty("rating")]
    public Rating Rating { get; }

    [JsonProperty("fav_count")]
    public int FavCount { get; }

    [JsonProperty("pools")]
    public string[] Pools { get; }

    [JsonProperty("relationships")]
    public Relationships Relationships { get; }

    [JsonProperty("approver_id")]
    public int? ApproverId { get; }

    [JsonProperty("uploader_id")]
    public int UploaderId { get; }

    [JsonProperty("description")]
    public string Description { get; }

    [JsonProperty("comment_count")]
    public int CommentCount { get; }

    [JsonProperty("is_favorited")]
    public bool IsFavorited { get; }

    [JsonProperty("has_notes")]
    public bool HasNotes { get; }

    [JsonProperty("duration")]
    public int? Duration { get; }
}

