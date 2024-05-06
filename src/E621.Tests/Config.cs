using System.Reflection.Metadata;
using System.Text.Json;

namespace Posh.E621.Tests;

internal static class Config
{
    public static string Username { get; } 
    public static string ApiKey { get; }

    static Config()
    {
        string configFilePath = Path.Combine(Directory.GetCurrentDirectory(), "config.json");
        string jsonString = File.ReadAllText(configFilePath);
        using (JsonDocument document = JsonDocument.Parse(jsonString))
        {
            JsonElement root = document.RootElement;
            Username = root.GetProperty("username").ToString();
            ApiKey = root.GetProperty("apiKey").ToString();
        }
    }
}
