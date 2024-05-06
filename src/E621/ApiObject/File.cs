namespace Posh.E621.ApiObject;

/// <summary>
/// An image or video file attached to an E621 post
/// </summary>
public class File : Image
{
    public string Ext { get; }
    public int Size { get; }
    public string Md5 { get; }
}
