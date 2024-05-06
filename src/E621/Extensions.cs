namespace Posh.E621;

internal static class Extensions
{
    public static void PopulateHeaders(this HttpRequestMessage request, Dictionary<string, string> headers)
    {
        foreach (KeyValuePair<string,string> kvp in headers)
        {
            request.Headers.Add(kvp.Key, kvp.Value);
        }
    }
}
