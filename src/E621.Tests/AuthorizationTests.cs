using Posh.E621.Tests;

namespace E621.Tests;

[TestClass]
public class AuthorizationTests
{
    [TestMethod]
    public void TestAuthorization()
    {
        Assert.IsTrue(new Client(Config.Username, Config.ApiKey, "C# E621 API Wrapper Test Suite").TestConnection().Result);
    }
}
