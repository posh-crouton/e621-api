using System.ComponentModel;

namespace Posh.E621.Enum;

/// <summary>
/// See <see href="https://e621.net/help/ratings"/> for explanations
/// on the specific meanings of ratings. 
/// </summary>
public enum Rating
{
    /// <summary>
    /// Post depicts explicit content
    /// </summary>
    [Description("e")]
    Explicit,

    /// <summary>
    /// Post is free of <see cref="Explicit"/> content, 
    /// but still questionable. 
    /// </summary>
    [Description("q")]
    Questionable,

    /// <summary>
    /// Post is free of <see cref="Explicit"/> and 
    /// <see cref="Questionable"/> content.
    /// </summary>
    [Description("s")]
    Safe
}

