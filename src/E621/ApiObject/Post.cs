using Posh.E621.Enum;

namespace Posh.E621.ApiObject;

/// <summary>
/// Represents a post on the E621 website.
/// </summary>
public class Post
{
    public int Id { get; }
    public DateTime CreatedAt { get; }
    public DateTime UpdatedAt { get; }
    public File File { get; }
    public Image Preview { get; }
    public Sample Sample { get; }
    public Score Score { get; }
    public Tags Tags { get; }
    public string[] LockedTags { get; }
    public int ChangeSeq { get; }
    public Flags Flags { get; }
    public Rating Rating { get; }
    public int FavCount { get; }
    public string[] Pools { get; }
    public Relationships Relationships { get; }
    public int? ApproverId { get; }
    public int UploaderId { get; }
    public string Description { get; }
    public int CommentCount { get; }
    public bool IsFavorited { get; }
    public bool HasNotes { get; }
    public int? Duration { get; }
}

