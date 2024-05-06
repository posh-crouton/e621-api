using System.ComponentModel;

namespace Posh.E621.Enum;

public enum Rating
{
    [Description("e")]
    Explicit,

    [Description("q")]
    Questionable,

    [Description("s")]
    Safe
}

