using MicrosoftAzureSentinel.Api.Test.Extensions;

namespace MicrosoftAzureSentinel.Api.Test;

public class ConnectorTests(ITestOutputHelper testOutputHelper) : TestBase(testOutputHelper)
{
	[Fact]
	public async Task GetConnectorsAsync_SimpleQuery_Succeeds()
	{
		var response = await Client
			.Connectors
			.GetAsync(
				TestConfig.SubscriptionId,
				TestConfig.ResourceGroupName,
				TestConfig.WorkspaceName,
				default
			)
			.ConfigureAwait(true);

		response.CheckValues();
		response.Values.Should().OnlyContain(x => x.Kind != null);
	}
}
