using Posh.E621;

namespace E621;

public class Client
{
    private readonly string _username;
    private readonly string _apiKey;
    private readonly string _userAgent;

    /// <summary>
    ///     Constructs authorization headers from the provided information. 
    ///     If the information changes, you will need to instantiate a new client.
    /// </summary>
    /// <param name="username">Username for the e621 website.</param>
    /// <param name="apiKey">
    ///     A valid API key for the e621 website. You can find and generate API keys at 
    ///     https://e621.net/users/<your-id>/api_key/view. NB: Your user ID is an integer
    ///     - it is not the same as your username. 
    /// </param>
    /// <param name="userAgent">
    ///     User-Agent header for HTTP requests. Required by the e621 API to prevent abuse
    ///     and enable contact in the event of problems. You are encouraged by e621 to include
    ///     your e621 username in this header so that e621 can contact you if your usage
    ///     causes problems. 
    /// </param>
    public Client(string username, string apiKey, string userAgent)
    {
        _username = username;
        _apiKey = apiKey;
        _userAgent = userAgent;
    }

    internal async Task<bool> TestConnection()
    {
        using HttpClient client = new();
        HttpRequestMessage request = new(HttpMethod.Get, "https://e621.net/posts.json?limit=1");
        request.PopulateHeaders(GetHeaders());
        HttpResponseMessage response = await client.SendAsync(request);
        return response.IsSuccessStatusCode;
    }

    private Dictionary<string, string> GetHeaders()
    {
        byte[] authHeaderBytes = System.Text.Encoding.UTF8.GetBytes($"{_username}:{_apiKey}");
        string authHeaderContent = Convert.ToBase64String(authHeaderBytes);

        return new() {
            { "Authorization", $"Basic {authHeaderContent}" },
            { "User-Agent", _userAgent }
        };
    }
}
