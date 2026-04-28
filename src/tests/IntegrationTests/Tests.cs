namespace V0.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static V0Client GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("V0_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("V0_API_KEY environment variable is not found.");

        var client = new V0Client(apiKey);
        
        return client;
    }
}
