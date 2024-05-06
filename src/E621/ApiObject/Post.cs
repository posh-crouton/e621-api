using Newtonsoft.Json;
using Posh.E621.Enum;

namespace Posh.E621.ApiObject;

/// <summary>
/// Represents a post on the E621 website.
/// </summary>
public class Post
{
    /// <summary>
    /// Post's ID / primary key
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; }

    /// <summary>
    /// When the post was created
    /// </summary>
    [JsonProperty("created_at")]
    public DateTime CreatedAt { get; }

    /// <summary>
    /// When the post was last updated
    /// </summary>
    [JsonProperty("updated_at")]
    public DateTime UpdatedAt { get; }

    /// <summary>
    /// The image or video file attached to the post
    /// </summary>
    [JsonProperty("file")]
    public File File { get; }

    /// <summary>
    /// The preview image attached to the post 
    /// </summary>
    [JsonProperty("preview")]
    public Image Preview { get; }
    
    /// <summary>
    /// The sample image attached to the post
    /// </summary>
    [JsonProperty("sample")]
    public Sample Sample { get; }
    
    /// <summary>
    /// The post's score
    /// </summary>
    [JsonProperty("score")]
    public Score Score { get; }

    /// <summary>
    /// Tags applied to the post
    /// </summary>
    [JsonProperty("tags")]
    public Tags Tags { get; }

    /// <summary>
    /// Locked tags 
    /// </summary>
    [JsonProperty("locked_tags")]
    public string[] LockedTags { get; }

    /// <summary>
    /// Change sequence
    /// </summary>
    [JsonProperty("change_seq")]
    public int ChangeSeq { get; }

    /// <summary>
    /// Flags applied to the post
    /// </summary>
    [JsonProperty("flags")]
    public Flags Flags { get; }

    /// <summary>
    /// The post's rating
    /// </summary>
    [JsonProperty("rating")]
    public Rating Rating { get; }

    /// <summary>
    /// Number of users that have favourited the post
    /// </summary>
    [JsonProperty("fav_count")]
    public int FavCount { get; }

    /// <summary>
    /// Pools of which this post is a member. Pools are
    /// a group of posts representing a common theme, often 
    /// used to group collections such as web comics. 
    /// </summary>
    [JsonProperty("pools")]
    public string[] Pools { get; }

    /// <summary>
    /// This post's relationship to other posts
    /// </summary>
    [JsonProperty("relationships")]
    public Relationships Relationships { get; }

    /// <summary>
    /// ID of the user who approved this post
    /// </summary>
    [JsonProperty("approver_id")]
    public int? ApproverId { get; }

    /// <summary>
    /// ID of the user who uploaded this post
    /// </summary>
    [JsonProperty("uploader_id")]
    public int UploaderId { get; }

    /// <summary>
    /// Description of the post
    /// </summary>
    [JsonProperty("description")]
    public string Description { get; }

    /// <summary>
    /// Number of comments on the post
    /// </summary>
    [JsonProperty("comment_count")]
    public int CommentCount { get; }

    /// <summary>
    /// Whether the authenticated user has favourited this post
    /// </summary>
    [JsonProperty("is_favorited")]
    public bool IsFavorited { get; }

    /// <summary>
    /// Whether the post has notes
    /// </summary>
    [JsonProperty("has_notes")]
    public bool HasNotes { get; }

    /// <summary>
    /// The duration of the post, if it is a video
    /// </summary>
    [JsonProperty("duration")]
    public int? Duration { get; }
}

